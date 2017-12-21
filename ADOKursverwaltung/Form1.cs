using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOKursverwaltung
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        List<Teilnehmer> listTeilnehmerTemp;
        List<Kurs> listKurse;

        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = Properties.Settings.Default.DbPfad;

            listKurse = new List<Kurs>();
            listTeilnehmerTemp = new List<Teilnehmer>();
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            con.Open();
            buttonAnzeigen.Enabled = false;
            //Kurse einlesen
            OleDbCommand com;
            com = con.CreateCommand();
            com.CommandText = "tKurs";
            com.CommandType = CommandType.TableDirect;

            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                listKurse.Add(kursErstellen(dr));
            }
            comboBoxKurse.DataSource = listKurse;
            dr.Close();

            //Teilnehmer einlesen
            OleDbCommand com2;
            com2 = con.CreateCommand();
            com2.CommandText = "tTeilnehmer";
            com2.CommandType = CommandType.TableDirect;
            OleDbDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read() == true)
            {
                listTeilnehmerTemp.Add(teilnehmerErstellen(dr2));
            }

        }

        private Kurs kursErstellen(OleDbDataReader dr)
        {
            Kurs k = new Kurs();
            int i = 0;
            k.Id = Convert.ToInt32(check(dr[i++]));
            k.Bezeichnung = Convert.ToString(check(dr[i++]));
            k.Datum = Convert.ToDateTime(check(dr[i++]));
   
            return k;
        }

        private Teilnehmer teilnehmerErstellen(OleDbDataReader dr2)
        {
            Teilnehmer t = new Teilnehmer();
            int i = 0;
            t.Id = Convert.ToInt32(check(dr2[i++]));
            t.Nachname = Convert.ToString(check(dr2[i++]));
            t.Vorname = Convert.ToString(check(dr2[i++]));
            t.Email = Convert.ToString(check(dr2[i++]));

            return t;
        }
        private object check(object o)
        {
            if (o != DBNull.Value)
            {
                return o;
            }
            else
            {
                return null;
            }
        }

       private void comboBoxKurse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kurs k = (Kurs)comboBoxKurse.SelectedItem;
            textBoxIdKurs.Text = Convert.ToString(k.Id);
            textBoxBezeichnung.Text = Convert.ToString(k.Bezeichnung);
            textBoxDatum.Text = Convert.ToString(k.Datum);

            
        }
    }
}
