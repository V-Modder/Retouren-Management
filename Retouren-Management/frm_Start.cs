using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Retouren_Management
{
    public partial class frm_Start : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frm_Start()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            frm_Suchen s = new frm_Suchen(this);
            s.Show();
            this.Hide();
        }

        private void frm_Start_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && chk_move.Checked)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
