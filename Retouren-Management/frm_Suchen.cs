using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retouren_Management
{
    public partial class frm_Suchen : Form
    {
        private frm_Start start;
        private bool bGoBack = true;

        public frm_Suchen(frm_Start Start)
        {
            InitializeComponent();
            this.start = Start;
        }

        private void txt_rechnungsnr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Suchen();
        }

        private void btn_suchen_Click(object sender, EventArgs e)
        {
            this.Suchen();
        }

        private void Suchen()
        {
            frm_Kunde knd = new frm_Kunde(Convert.ToInt32(txt_rechnungsnr.Text), start);
            knd.Show();
            bGoBack = false;
            this.Close();
        }

        private void frm_Suchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && bGoBack)
                start.Show();
        }
    }
}
