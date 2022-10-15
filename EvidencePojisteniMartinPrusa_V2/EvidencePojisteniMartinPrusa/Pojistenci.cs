using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniMartinPrusa
{
    internal class Pojistenci
    {
        private string Jmeno { get; set; }
        private string Prijmeni { get; set; }
        private int Vek { get; set; }
        private int Telefon { get; set; }
        public string jmeno { get { return Jmeno; } set { Jmeno = value; } }
        public string prijmeni { get { return Prijmeni; } set { Prijmeni = value; } }


        public Pojistenci(string jmeno, string prijmeni, int vek, int telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;

            
        }

        public override string ToString()
        {
            return Jmeno + "\t " + Prijmeni + "\t " + Vek + "\t " + Telefon;
        }
    }
}
