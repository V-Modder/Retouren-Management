using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Retouren_Management
{
    public partial class frm_Kunde : Form
    {
        private int kndnr = 0;
        private frm_Start start;

        public frm_Kunde(int KundenNr, frm_Start Start)
        {
            InitializeComponent();
            this.kndnr = KundenNr;
            this.start = Start;
        }

        private void frm_Kunde_Load(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("user id=" + Retouren_Management.Program.Settings.Dbuser +
                                       ";password=" + Retouren_Management.Program.Settings.Dbpass +
                                       ";server=" + Retouren_Management.Program.Settings.DbPath +
                                       ";Trusted_Connection=yes;" +
                                       "database=" + Retouren_Management.Program.Settings.Database +
                                       ";connection timeout=30");
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(@"select trechnung.crechnungsnr, trechnung.tkunde_kkunde, trechnung.tBestellung_kBestellung, 
                                                    tkunde.kkunde, tkunde.ckundennr, tkunde.cvorname, tkunde.cname, tkunde.cfirma, tkunde.cstrasse, 
                                                    tkunde.cplz, tkunde.cort, tkunde.cland 
                                                    from trechnung
                                                    inner join tkunde
                                                    on trechnung.tKunde_kKunde=tkunde.kkunde
                                                    where trechnung.crechnungsnr=" + kndnr.ToString(), myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            string iBestellung = "0";
            while (myReader.Read())
            {
                txt_rechnungsnr.Text = myReader["crechnungsnr"].ToString();
                txt_kundennr.Text = myReader["tkunde_kkunde"].ToString();
                txt_vorname.Text = myReader["cvorname"].ToString();
                txt_name.Text = myReader["cname"].ToString();
                txt_firma.Text = myReader["cfirma"].ToString();
                txt_strasse.Text = myReader["cstrasse"].ToString();
                txt_plz.Text = myReader["cplz"].ToString();
                txt_ort.Text = myReader["cort"].ToString();
                txt_land.Text = myReader["cland"].ToString();
                iBestellung = myReader["tBestellung_kBestellung"].ToString();
            }
            myCommand = new SqlCommand(@"select tArtikel_kArtikel
                                         from tbestellpos
                                         where tBestellung_kBestellungs=" + iBestellung , myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                chk_artikel.Items.Add(myReader["tArtikel_kArtikel"].ToString());
            }
        }

        private void frm_Kunde_FormClosing(object sender, FormClosingEventArgs e)
        {
            start.Show();
        }
    }
}
