using System;
using System.Windows.Forms;

namespace Retouren_Management
{
    public partial class frm_Suchen : Form
    {
        #region Class variables
        private frm_Start start;
        private bool bGoBack = true;
        #endregion

        #region Form control
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Start">Das aufrufende Hauptformular</param>
        public frm_Suchen(frm_Start Start)
        {
            InitializeComponent();
            this.start = Start;
        }

        /// <summary>
        /// btn_suchen wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_suchen_Click(object sender, EventArgs e)
        {
            this.Suchen();
        }

        /// <summary>
        /// frm_Suchen wird geschlossen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Suchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && bGoBack)
                start.Show();
        }

        /// <summary>
        /// Erkennt ob F2 grdrückt wurde, während das Form den Fokus hat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Suchen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                this.Close();
        }

        /// <summary>
        /// frm_Suchen wird geöffnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Suchen_Load(object sender, EventArgs e)
        {
            txt_rechnungsnr.Focus();
        }

        /// <summary>
        /// Erkennt ob Enter grdrückt wurde, während txt_rechnungsnr den Fokus hat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_rechnungsnr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                this.Close();
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F4)
                this.Suchen();
        }
        #endregion

        /// <summary>
        /// Öffnet das frm_Kunde mit der eingegebenen Rechnungs-Nr
        /// </summary>
        private void Suchen()
        {
            frm_Kunde knd = new frm_Kunde(Convert.ToInt32(txt_rechnungsnr.Text), start);
            knd.Show();
            bGoBack = false;
            this.Close();
        }
    }
}
