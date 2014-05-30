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
        private string ConnectionStr = "server=" + Retouren_Management.Program.Settings.DbPath +
                                       ";database=" + Retouren_Management.Program.Settings.Database +
                                       ";UID=" + Retouren_Management.Program.Settings.Dbuser +
                                       ";password=" + Retouren_Management.Program.Settings.Dbpass;

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

        private const string qArtikelNr = @"SELECT cArtNr, cBarcode 
                                           FROM tartikel 
                                           WHERE cBarcode=";

        public WaWiConnector()
        {
            myConnection = new SqlConnection(ConnectionStr);
        }

        ~WaWiConnector()
        {
            myConnection.Close();
        }

        public void Dispose()
        {
            myConnection.Close();
        }

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
                kBestellung = Convert.ToInt32(myReader["tBestellung_kBestellung"].ToString());
            }
            myReader.Close();
            myCommand.Dispose();
            return rtn;
        }

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
    }
}
