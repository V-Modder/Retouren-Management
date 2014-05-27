using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Retouren_Management
{
    public partial class frm_Config : Form
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public frm_Config()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btn_search wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txt_output.Text = fbd.SelectedPath;
        }

        /// <summary>
        /// btn_save wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            using (Rijndael myRijndael = Rijndael.Create())
            {
                Retouren_Management.Program.Settings.DbPath = txt_dbpath.Text;
                Retouren_Management.Program.Settings.Database = txt_db.Text;
                Retouren_Management.Program.Settings.Dbuser = txt_user.Text;
                Retouren_Management.Program.Settings.Dbpass = txt_pass.Text;
                Retouren_Management.Program.Settings.Outputfolder = txt_output.Text;
                Retouren_Management.Program.Settings.Save();
                Application.Restart();
            }
        }
    }
}
