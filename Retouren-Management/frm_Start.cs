using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Retouren_Management
{
    public partial class frm_Start : Form
    {
        #region Windows-API imports
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        #endregion

        #region Form control
        /// <summary>
        /// Konstruktor
        /// </summary>
        public frm_Start()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btn_start wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            frm_Suchen s = new frm_Suchen(this);
            s.Show();
            this.Hide();
        }

        /// <summary>
        /// frm_Start wird verschoben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Start_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && chk_move.Checked)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
}
