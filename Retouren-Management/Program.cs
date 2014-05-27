using System;
using System.Windows.Forms;
using ApplicationSettings;

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
                Application.Run(new frm_Config());          //Wenn keine Einstellungen vorhanden sind
            else
                Application.Run(new frm_Start());           //Wenn Einstellungen vorhanden sind 
        }


        private static MySettings set;

        /// <summary>
        /// Speicherort der Einstellungen der Anwendung
        /// </summary>
        internal static MySettings Settings
        {
            get { return set; }
            set { set = value; }
        }
    }
}
