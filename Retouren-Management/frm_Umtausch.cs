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
    public partial class frm_Umtausch : Form
    {
        public string sMessage;

        public frm_Umtausch()
        {
            InitializeComponent();
        }

        private void btn_fertig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdb_5xl_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sonstiges.Checked)
                txt_sonstiges.Enabled = true;
            else
                txt_sonstiges.Enabled = false;
            RadioButton r = (RadioButton)sender;
            sMessage = r.Text;
        }

        private void txt_sonstiges_TextChanged(object sender, EventArgs e)
        {
            sMessage = txt_sonstiges.Text;
        }

        private void frm_Umtausch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    this.Close();
                    break;
                case Keys.F5:
                    rdb_s.Checked = true;
                    break;
                case Keys.F6:
                    rdb_m.Checked = true;
                    break;
                case Keys.F7:
                    rdb_l.Checked = true;
                    break;
                case Keys.F8:
                    rdb_xl.Checked = true;
                    break;
                case Keys.F9:
                    rdb_xxl.Checked = true;
                    break;
                case Keys.F10:
                    rdb_3xl.Checked = true;
                    break;
                case Keys.F11:
                    rdb_4xl.Checked = true;
                    break;
                case Keys.F12:
                    rdb_5xl.Checked = true;
                    break;
                case Keys.F13:
                    rdb_massanfertigung.Checked = true;
                    break;
            }
        }
    }
}
