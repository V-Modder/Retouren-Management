﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retouren_Management
{
    public partial class frm_Config : Form
    {
        public frm_Config()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txt_output.Text = fbd.SelectedPath;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Retouren_Management.Program.Settings.DbPath = txt_dbpath.ToString();
            Retouren_Management.Program.Settings.Database = txt_db.ToString();
            Retouren_Management.Program.Settings.Dbuser = txt_user.ToString();
            Retouren_Management.Program.Settings.Dbpass = txt_pass.ToString();
            Retouren_Management.Program.Settings.Outputfolder = txt_output.Text;
            Retouren_Management.Program.Settings.Save();
            Application.Restart();
        }
    }
}
