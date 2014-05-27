using System.IO;
using System.Web.Script.Serialization;

namespace ApplicationSettings
{
    public class MySettings : AppSettings<MySettings>
    {
        private string dbPath;
        private string dbuser;
        private string dbpass;
        private string outputfolder;
        private string database;

        /// <summary>
        /// Gibt den Pfad zur Datenbank wieder, oder legt diesen fest
        /// </summary>
        public string DbPath
        {
            get { return dbPath; }
            set { dbPath = value; }
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
        /// Gibt den Ausgabeordner an, oder legt diesen Fest
        /// </summary>
        public string Outputfolder
        {
            get { return outputfolder; }
            set { outputfolder = value; }
        }

        /// <summary>
        /// Gibt den Name der Datenbank an, oder legt diesen Fest
        /// </summary>
        public string Database
        {
            get { return database; }
            set { database = value; }
        }
    }

    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.jsn";

        public void Save(string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
        }

        public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
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
