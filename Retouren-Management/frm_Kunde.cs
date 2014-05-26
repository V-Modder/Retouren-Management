using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Retouren_Management
{
    public partial class frm_Kunde : Form
    {
        private int kndnr = 0;
        private frm_Start start;

        public frm_Kunde(int KundenNr, frm_Start Start)
        {
            InitializeComponent();
            this.kndnr = KundenNr;
            this.start = Start;
        }

        private void frm_Kunde_Load(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("server=" + Retouren_Management.Program.Settings.DbPath +
                                                           ";database=" + Retouren_Management.Program.Settings.Database +
                                                           ";UID=" + Retouren_Management.Program.Settings.Dbuser +
                                                           ";password=" +Retouren_Management.Program.Settings.Dbpass);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(@"select trechnung.crechnungsnr, trechnung.tkunde_kkunde, trechnung.tBestellung_kBestellung, 
                                                    tkunde.kkunde, tkunde.ckundennr, tkunde.cvorname, tkunde.cname, tkunde.cfirma, tkunde.cstrasse, 
                                                    tkunde.cplz, tkunde.cort, tkunde.cland 
                                                    from trechnung
                                                    inner join tkunde
                                                    on trechnung.tKunde_kKunde=tkunde.kkunde
                                                    where trechnung.crechnungsnr=" + kndnr.ToString(), myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                string iBestellung = "0";
                while (myReader.Read())
                {
                    txt_rechnungsnr.Text = myReader["crechnungsnr"].ToString();
                    txt_kundennr.Text = myReader["tkunde_kkunde"].ToString();
                    txt_vorname.Text = myReader["cvorname"].ToString();
                    txt_name.Text = myReader["cname"].ToString();
                    txt_firma.Text = myReader["cfirma"].ToString();
                    txt_strasse.Text = myReader["cstrasse"].ToString();
                    txt_plz.Text = myReader["cplz"].ToString();
                    txt_ort.Text = myReader["cort"].ToString();
                    txt_land.Text = myReader["cland"].ToString();
                    iBestellung = myReader["tBestellung_kBestellung"].ToString();
                }
                myReader.Close();
                myCommand = new SqlCommand(@"select tArtikel_kArtikel, fVKPreis
                                            from tbestellpos
                                            where tBestellung_kBestellung=" + iBestellung, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    dgv_artikel.Rows.Add(myReader["tArtikel_kArtikel"].ToString(), myReader["fVKPreis"].ToString());
                }
                myReader.Close();
                txt_zuruck.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void frm_Kunde_FormClosing(object sender, FormClosingEventArgs e)
        {
            start.Show();
        }

        private string createTextFile()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Datum: %s\n\n", DateTime.Now.Date.ToShortDateString());
            sb.AppendFormat("Rechnungs-Nr: %s\n", txt_rechnungsnr);
            sb.AppendFormat("Kunden-Nr   : %s\n", txt_kundennr);
            sb.AppendFormat("%s\n%s %s\n%s\n%s, %s\n%s", txt_firma.Text, txt_vorname.Text, txt_name.Text, txt_strasse.Text, txt_plz.Text, txt_ort.Text, txt_land.Text);
            sb.AppendLine("\nArtikel\n");
            foreach (DataGridViewRow row in dgv_artikel.Rows)
            {
                sb.AppendLine(row.Cells[0].ToString() + "\t" + row.Cells[1].ToString());
            }
            sb.AppendFormat("\nArtikel zurück\n%s\n", txt_zuruck.Text);
            return sb.ToString();
        }

        private void btn_erstattung_Click(object sender, EventArgs e)
        {
            Erstattung();
        }

        private void Erstattung()
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path.Combine(Retouren_Management.Program.Settings.Outputfolder, txt_rechnungsnr.Text + ".txt"));
                sw.Write(createTextFile() + "Erstattung!");
                sw.Close();
                start.Show();
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_umtausch_Click(object sender, EventArgs e)
        {
            Umtausch();
        }

        private void Umtausch()
        {
            try
            {
                frm_Umtausch umtausch = new frm_Umtausch();
                umtausch.ShowDialog();
                StreamWriter sw = new StreamWriter(Path.Combine(Retouren_Management.Program.Settings.Outputfolder, txt_rechnungsnr.Text + ".txt"));
                sw.Write(createTextFile() + "Umtausch:\n" + umtausch.sMessage);
                sw.Close();
                start.Show();
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void frm_Kunde_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
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
    }
}
