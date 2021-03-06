﻿using System;
using System.Windows.Forms;

namespace Retouren_Management
{
    public partial class frm_Umtausch : Form
    {
        /// <summary>
        /// Gibt zurück welcher Punkt ausgewählt wurde
        /// </summary>
        public string sMessage;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public frm_Umtausch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Erkennt ob F3, F5-F13 gedrückt wurden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Umtausch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    this.Close();
                    break;
                case Keys.F5:
                    rdb_s.Checked = true;
                    this.Close();
                    break;
                case Keys.F6:
                    rdb_m.Checked = true;
                    this.Close();
                    break;
                case Keys.F7:
                    rdb_l.Checked = true;
                    this.Close();
                    break;
                case Keys.F8:
                    rdb_xl.Checked = true;
                    this.Close();
                    break;
                case Keys.F9:
                    rdb_xxl.Checked = true;
                    this.Close();
                    break;
                case Keys.F10:
                    rdb_3xl.Checked = true;
                    this.Close();
                    break;
                case Keys.F11:
                    rdb_4xl.Checked = true;
                    this.Close();
                    break;
                case Keys.F12:
                    rdb_5xl.Checked = true;
                    this.Close();
                    break;
                case Keys.F13:
                    rdb_massanfertigung.Checked = true;
                    this.Close();
                    break;
            }

        }

        /// <summary>
        /// btn_fertig wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fertig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Einer der RadioButtons wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_5xl_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sonstiges.Checked)
                txt_sonstiges.Enabled = true;
            else
                txt_sonstiges.Enabled = false;
            RadioButton r = (RadioButton)sender;
            sMessage = r.Text;
        }

        /// <summary>
        /// Der Text in txt_sonstiges wurde geändert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_sonstiges_TextChanged(object sender, EventArgs e)
        {
            sMessage = txt_sonstiges.Text;
        }
    }
}
