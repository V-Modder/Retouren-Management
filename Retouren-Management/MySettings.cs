using System.IO;
using System.Drawing;
using System.Text;
using System.Web.Script.Serialization;

namespace ApplicationSettings
{
    public class MySettings : AppSettings<MySettings>
    {
        private string dbPath;
        private string database;
        private string dbuser;
        private string dbpass;
        private string outputfolder;
        private Point frm_Start_Position;

        /// <summary>
        /// Gibt den Pfad zur Datenbank wieder, oder legt diesen fest
        /// </summary>
        public string DbPath
        {
            get { return dbPath; }
            set { dbPath = value; }
        }

        /// <summary>
        /// Gibt den Name der Datenbank an, oder legt diesen Fest
        /// </summary>
        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        /// <summary>
        /// Gibt den Buntzer der Datenbank wieder, oder legt diesen fest
        /// </summary>
        public string Dbuser
        {
            get { return dbuser; }
            set { dbuser = value; }
        }

        /// <summary>
        /// Gibt das Passwort der Datenbank wieder, oder legt dieses fest
        /// </summary>
        public string Dbpass
        {
            get { return dbpass; }
            set { dbpass = value; }
        }

        /// <summary>
        /// Gibt den Ausgabeordner wieder, oder legt diesen Fest
        /// </summary>
        public string Outputfolder
        {
            get { return outputfolder; }
            set { outputfolder = value; }
        }

        /// <summary>
        /// Gibt die Position des frm_Start wieder, oder legt diesen Fest
        /// </summary>
        public Point Frm_Start_Position
        {
            get { return frm_Start_Position; }
            set { frm_Start_Position = value; }
        }

    }

    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.jsn";

        public void Save(string fileName = DEFAULT_FILENAME)
        {
            StringBuilder sb = new StringBuilder();
            new JavaScriptSerializer().Serialize(this, sb);
            sb.Replace("\",", "\",\n");
            File.WriteAllText(fileName, sb.ToString());
            sb.Clear();
        }

        public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
        {
            StringBuilder sb = new StringBuilder();
            new JavaScriptSerializer().Serialize(pSettings, sb);
            sb.Replace("\",", "\",\n");
            File.WriteAllText(fileName, sb.ToString());
            sb.Clear();
        }

        public static T Load(string fileName = DEFAULT_FILENAME)
        {
            T t = new T();
            if (File.Exists(fileName))
                t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
            return t;
        }
    }
}
