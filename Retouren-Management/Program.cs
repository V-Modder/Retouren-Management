using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Retouren_Management
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Settings = new MySettings();
            Settings = MySettings.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Settings.Database == null || Settings.Dbpass == null || Settings.DbPath == null ||
                Settings.Dbuser == null || Settings.Outputfolder == null)
                Application.Run(new frm_Config());
            else
                Application.Run(new frm_Start());
        }


        private static MySettings set;

        internal static MySettings Settings
        {
            get { return set; }
            set { set = value; }
        }
    }
}
