using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Retouren_Management
{
    public partial class frm_Kunde : Form
    {
        #region Klassen Variablen
        private int rechnr = 0;
        private frm_Start start;
        private WaWiConnector myConnection;
        #endregion

        #region Form Handling
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="RechnungsNr">Die Rechnungs-Nr aus frm_Suchen</param>
        /// <param name="Start">Das aufrufende Hauptformular</param>
        public frm_Kunde(int RechnungsNr, frm_Start Start)
        {
            InitializeComponent();
            this.rechnr = RechnungsNr;
            this.start = Start;
        }

        /// <summary>
        /// frm_Kunde wird geöffnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Kunde_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new WaWiConnector();
                int kBestellung = 0;
                Hashtable ht = myConnection.ExecuteQKunde(rechnr, ref kBestellung);
                if (ht.Count != 0)
                {
                    txt_rechnungsnr.Text = ht["crechnungsnr"].ToString();
                    txt_kundennr.Text = ht["tkunde_kkunde"].ToString();
                    txt_vorname.Text = ht["cvorname"].ToString();
                    txt_name.Text = ht["cname"].ToString();
                    txt_firma.Text = ht["cfirma"].ToString();
                    txt_strasse.Text = ht["cstrasse"].ToString();
                    txt_plz.Text = ht["cplz"].ToString();
                    txt_ort.Text = ht["cort"].ToString();
                    txt_land.Text = ht["cland"].ToString();
                    txt_zahlung.Text = ht["czahlungsname"].ToString();

                    string[][] st = myConnection.ExecuteQArtikel(kBestellung);
                    for (int i = 0; i < st[0].Length; i++)
                    {
                        dgv_artikel.Rows.Add(st[0][i], st[1][i]);
                    }
                    st = null;
                }
                dgv_zuruck.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        /// <summary>
        /// frm_Kunde wird geschlossen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Kunde_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Dispose();
            start.Show();
        }
        
        /// <summary>
        /// Erkennt ob eine Taste grdrückt wurde, während das Form den Fokus hat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Kunde_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    start.Show();
                    this.Close();
                    break;
                case Keys.F3:
                    Umtausch();
                    break;
                case Keys.F4:
                    Erstattung();
                    break;
            }
        }

        /// <summary>
        /// btn_erstattung wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_erstattung_Click(object sender, EventArgs e)
        {
            Erstattung();
        }

        /// <summary>
        /// btn_umtausch wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_umtausch_Click(object sender, EventArgs e)
        {
            Umtausch();
        }

        /// <summary>
        /// EAN wurde eingegeben und Enter wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_zuruck_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dgv_zuruck[e.ColumnIndex, e.RowIndex].Value != null && dgv_zuruck[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
            {
                try
                {
                    dgv_zuruck[e.ColumnIndex + 1, e.RowIndex].Value = myConnection.ExecuteQArtikelNr(dgv_zuruck[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            CheckAllDataValid();
        }
        #endregion

        #region Klassen Methoden
        /// <summary>
        /// Prüft ob alle Artikelnummern erfasst wurden
        /// </summary>
        private void CheckAllDataValid()
        {
            foreach (DataGridViewRow row in dgv_zuruck.Rows)
            {
                if((row.Cells[1].Value == null || row.Cells[1].Value.ToString() == "") && !row.IsNewRow)
                {
                    btn_erstattung.Enabled = false;
                    btn_umtausch.Enabled = false;
                    return;
                }
            }
            btn_erstattung.Enabled = true;
            btn_umtausch.Enabled = true;
        }

        /// <summary>
        /// Generiert eine Textdatei, die die Daten des Kundens, der Artikel, der Retoure und das Datum enthält
        /// </summary>
        /// <returns>Die Textdatei als formatierter String</returns>
        private string createTextFile()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Datum: {0}\n\n", DateTime.Now.Date.ToShortDateString());
            sb.AppendFormat("Rechnungs-Nr: {0}\n", txt_rechnungsnr.Text);
            sb.AppendFormat("Kunden-Nr : {0}\n", txt_kundennr.Text);
            sb.AppendFormat("{0}\n{1} {2}\n{3}\n{4}, {5}\n{6}\n\n", txt_firma.Text, txt_vorname.Text, txt_name.Text, txt_strasse.Text, txt_plz.Text, txt_ort.Text, txt_land.Text);
            sb.AppendLine("\nArtikel\n------------------------------\n");
            foreach (DataGridViewRow row in dgv_artikel.Rows)
            {
                sb.AppendLine(row.Cells[0].Value.ToString() + "\t" + row.Cells[1].Value.ToString());
            }
            sb.Append("\nArtikel zurück\n------------------------------\n\n\n");
            foreach (DataGridViewRow row in dgv_zuruck.Rows)
            {
                sb.AppendLine(row.Cells[1].Value.ToString());
            }
            sb.Append("\n");
            return sb.ToString();
        }

        /// <summary>
        /// Erstellt eine Textdatei und fügt ein Vermerk zur Erstattung bei
        /// </summary>
        private void Erstattung()
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path.Combine(Retouren_Management.Program.Settings.Outputfolder, txt_rechnungsnr.Text + ".txt"));
                sw.Write(createTextFile() + "************************************\n*           Erstattung             *\n************************************");
                sw.Close();
                start.Show();
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        /// <summary>
        /// Erstellt eine Textdatei und fügt ein Vermerk auf die neue Größe hinzu
        /// </summary>
        private void Umtausch()
        {
            try
            {
                frm_Umtausch umtausch = new frm_Umtausch();
                umtausch.ShowDialog();
                StreamWriter sw = new StreamWriter(Path.Combine(Retouren_Management.Program.Settings.Outputfolder, txt_rechnungsnr.Text + ".txt"));
                sw.Write(createTextFile() + "************************************\n*            Umtausch              *\n************************************\n\n" + "Neue Größe: " + umtausch.sMessage);
                sw.Close();
                start.Show();
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        #endregion
    }
}
