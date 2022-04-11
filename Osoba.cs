using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_BMI
{
    internal class Osoba
    {
        private string jmeno;
        private string prijmeni;
        private int hmotnost;
        private double vyska;
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Hmotnost
        {
            get
            {
                return hmotnost;
            }
            set
            {
                if (hmotnost <= 0 && hmotnost > 300)
                {
                    MessageBox.Show("HMOTNOST JE MIMO ROZSAH!");
                }
                else
                {
                    hmotnost = value;
                }
            }
        }
        public double Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                vyska = value;
                if (vyska > 10)
                {
                    vyska = vyska / 100;
                }
            }
        }
        public Osoba(string jmeno, string prijmeni, int hmotnost, double vyska)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Hmotnost = hmotnost;
            Vyska = vyska;
        }

        public double BMI()
        {
            double bmi;
            bmi = (Hmotnost) / (Vyska * Vyska);
            return bmi;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} má hmotnost: {2} kg \n Vyska je: {3} m. \n BMI je: {4}", Jmeno, Prijmeni,Hmotnost, Vyska, BMI());
        }
    }
}
