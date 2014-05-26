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
    }
}
