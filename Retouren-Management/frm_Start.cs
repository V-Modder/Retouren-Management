using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using Utilities;

namespace Retouren_Management
{
    public partial class frm_Start : Form
    {
        #region Windows-API imports & Variablen
        private bool bIsRotated = false;
        private bool bIsStarted = false;
        globalKeyboardHook gkh = new globalKeyboardHook();
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
        /// frm_Start wird geschlossen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Retouren_Management.Program.Settings.Save();
        }

        /// <summary>
        /// frm_Start wird geöffnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Start_Load(object sender, EventArgs e)
        {
            this.Location = Retouren_Management.Program.Settings.Frm_Start_Position;
            pic_doc.Image = RotateImage(pic_doc.Image, new PointF(pic_doc.Image.Width / 2, pic_doc.Image.Height / 2), 270);
            gkh.HookedKeys.Add(Keys.F7);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        }

        /// <summary>
        /// frm_Start wird verschoben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Start_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && bIsRotated)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Retouren_Management.Program.Settings.Frm_Start_Position = this.Location;
            }
        }

        /// <summary>
        /// Wird ausgelöst, wenn zum Form zurückgekehrt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Start_VisibleChanged(object sender, EventArgs e)
        {
            if (bIsStarted)
            {
                gkh.hook();
                bIsStarted = false;
            }
        }

        /// <summary>
        /// btn_start wurde gedrückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            Start();
        }

        /// <summary>
        /// frm_Start wird verschoben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left && bIsRotated)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Retouren_Management.Program.Settings.Frm_Start_Position = this.Location;
            }
        }

        /// <summary>
        /// Globaler Tastatur Hook
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
                Start();
        }

        /// <summary>
        /// De/Aktiviert das Verschieben von frm_Start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_doc_Click(object sender, EventArgs e)
        {
            if (bIsRotated)
            {
                pic_doc.Image = RotateImage(pic_doc.Image, new PointF(pic_doc.Image.Width / 2, pic_doc.Image.Height/2), 270);
                bIsRotated = false;
            }
            else
            {
                pic_doc.Image = RotateImage(pic_doc.Image, new PointF(pic_doc.Image.Width / 2, pic_doc.Image.Height / 2), 90);
                bIsRotated = true;
            }
        }
        #endregion  
      
        #region Klassen Methoden
        //<see cref="System.Console.WriteLine(System.String)"/>
        /// <summary>
        /// Erstellt eine Bitmap, die nur gedreht wurde
        /// </summary>
        /// <param name="image">Das <see cref="System.Drawing.Image"/>, welches gedreht werden soll</param>
        /// <param name="offset">Der <see cref="System.Drawing.PointF"/>, um den gedreht wird</param>
        /// <param name="angle">Die Anzahl an Grad, in die im Uhrzeigersinn gedreht werden soll</param>
        /// <returns>Eine neue <see cref="System.Drawing.Bitmap"/> der selben Größe, nur gedreht</returns>
        /// <exception cref="System.ArgumentNullException">Aufgerufen wenn <see cref="image"/> null ist.</exception>
        private static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));
            return rotatedBmp;
        }

        /// <summary>
        /// Started frm_Suchen
        /// </summary>
        private void Start()
        {
            frm_Suchen s = new frm_Suchen(this);
            s.Show();
            gkh.unhook();
            this.Hide();
            bIsStarted = true;
        }
        #endregion
    }
}
