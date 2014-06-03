using System;
using System.Collections;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retouren_Management
{
    class WaWiConnector : IDisposable
    {
        private SqlConnection myConnection;

        #region Abfragen
        private string ConnectionStr = "server=" + Retouren_Management.Program.Settings.DbPath +
                                       ";database=" + Retouren_Management.Program.Settings.Database +
                                       ";UID=" + Retouren_Management.Program.Settings.Dbuser +
                                       ";password=" + Retouren_Management.Program.Settings.GetDbpass();

        private const string qKunde = @"SELECT trechnung.crechnungsnr, trechnung.tkunde_kkunde, trechnung.tBestellung_kBestellung, 
                                        tkunde.kkunde, tkunde.ckundennr, tkunde.cvorname, tkunde.cname, tkunde.cfirma, tkunde.cstrasse, 
                                        tkunde.cplz, tkunde.cort, tkunde.cland 
                                        FROM trechnung
                                        INNER JOIN tkunde
                                        ON trechnung.tKunde_kKunde=tkunde.kkunde
                                        WHERE trechnung.crechnungsnr=";

        private const string qArtikel = @"SELECT cArtNr, fVKPreis
                                          FROM tbestellpos
                                          WHERE tBestellung_kBestellung=";

        private const string qArtikelNr = @"SELECT cArtNr 
                                           FROM tartikel 
                                           WHERE cBarcode=";

        private const string qZahlungsArt = @"select tzahlungsart.cname 
                                                from tbestellung
                                                inner join tzahlungsart 
                                                on convert(varchar(20),tbestellung.kzahlungsart)=tzahlungsart.kzahlungsart
                                                where tbestellung.kBestellung=";
        #endregion

        /// <summary>
        /// Konstruktor
        /// </summary>
        public WaWiConnector()
        {
            myConnection = new SqlConnection(ConnectionStr);
        }

        /// <summary>
        /// Destruktor
        /// </summary>
        ~WaWiConnector()
        {
            myConnection.Close();
        }

        /// <summary>
        /// Aufräumen
        /// </summary>
        public void Dispose()
        {
            myConnection.Close();
        }

        /// <summary>
        /// Gibt die Artikel anhand der BestellNr zurück
        /// </summary>
        /// <param name="kBestellung">BestellKey</param>
        /// <returns>A string array (ArtNr, VKPreis)</returns>
        public string[][] ExecuteQArtikel(int kBestellung)
        {
            List<string> artnr = new List<string>();
            List<string> preis = new List<string>();
            if (myConnection.State != System.Data.ConnectionState.Open)
                myConnection.Open();
            SqlCommand myCommand = new SqlCommand(qArtikel + kBestellung, myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            
            while (myReader.Read())
            {
                artnr.Add(myReader["cArtNr"].ToString());
                preis.Add(myReader["fVKPreis"].ToString());
            }
            myReader.Close();
            myCommand.Dispose();
            string[][] s = new string[2][];
            s[0] = artnr.ToArray();
            s[1] = preis.ToArray();
            return s;
        }

        /// <summary>
        /// Gibt den Kunden anhand der RechnungsNr zurück
        /// </summary>
        /// <param name="RechnungsNr">Rechnungs-Nummer</param>
        /// <param name="kBestellung">returns BestellKey</param>
        /// <returns>Hashtable mit Kundendaten</returns>
        public Hashtable ExecuteQKunde(int RechnungsNr, ref int kBestellung)
        {
            Hashtable rtn = new Hashtable();
            if (myConnection.State != System.Data.ConnectionState.Open)
                myConnection.Open();
            SqlCommand myCommand = new SqlCommand(qKunde + RechnungsNr.ToString(), myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                rtn.Add("crechnungsnr", myReader["crechnungsnr"].ToString());
                rtn.Add("tkunde_kkunde", myReader["tkunde_kkunde"].ToString());
                rtn.Add("cvorname", myReader["cvorname"].ToString());
                rtn.Add("cname", myReader["cname"].ToString());
                rtn.Add("cfirma", myReader["cfirma"].ToString());
                rtn.Add("cstrasse", myReader["cstrasse"].ToString());
                rtn.Add("cplz", myReader["cplz"].ToString());
                rtn.Add("cort", myReader["cort"].ToString());
                rtn.Add("cland", myReader["cland"].ToString());
                rtn.Add("czahlungsname", ExecuteQZahlungsArt(myReader["tBestellung_kBestellung"].ToString()));
                kBestellung = Convert.ToInt32(myReader["tBestellung_kBestellung"].ToString());
            }
            myReader.Close();
            myCommand.Dispose();
            return rtn;
        }

        /// <summary>
        /// Gibt die ArtikelNr anhand der EAN zurück
        /// </summary>
        /// <param name="EANcode">EAN-Code</param>
        /// <returns>Artikel Nummer</returns>
        public string ExecuteQArtikelNr(string EANcode)
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
                myConnection.Open();
            SqlCommand myCommand = new SqlCommand(qArtikelNr + EANcode, myConnection);
            SqlDataReader rdr = myCommand.ExecuteReader();
            rdr.Close();
            myCommand.Dispose();
            return rdr["cArtNr"].ToString();
        }

        /// <summary>
        /// Gibt die ZahlungsMethode anhand der BestellNr zurück
        /// </summary>
        /// <param name="kBestellung"></param>
        /// <returns></returns>
        private string ExecuteQZahlungsArt(string kBestellung)
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
                myConnection.Open();
            SqlCommand myCommand = new SqlCommand(qArtikelNr + kBestellung, myConnection);
            SqlDataReader rdr = myCommand.ExecuteReader();
            rdr.Close();
            myCommand.Dispose();
            return rdr["cname"].ToString();
        }
    }
}
