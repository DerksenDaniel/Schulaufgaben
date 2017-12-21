using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOKursverwaltung
{
    public partial class Kurs : Form1
    {
        List<Teilnehmer> listTeilnehmer;
        private string bezeichnung;
        private int count;
        private DateTime datum;
        private int id;

        public Kurs()
        {
        }

       

        public override string ToString()
        {
            return bezeichnung;
        }
        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }
    }
}
