using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BMI
{
    internal class Pacient : Osoba
    {
        private double obvodpasu;
        public double ObvodPasu
        {
            get
            {
                return obvodpasu;
            }
            set
            {
                obvodpasu = value;
                if (obvodpasu > 10)
                {
                    obvodpasu = obvodpasu / 100;
                }
            }
        }
        public Pacient(string jmeno, string prijmeni, int hmotnost, double vyska, double obvodpasu) : base(jmeno, prijmeni, hmotnost, vyska)//dedi se z osoby, obvod novej
        {
            ObvodPasu = obvodpasu;
        }

        private double ABSI()
        {
            double x = 2.0 / 3.0;
            return ObvodPasu / (Math.Pow(BMI(), x) * Math.Sqrt(Vyska));
        }
        public override string ToString()
        {
            return base.ToString() + "\n Obvod pasu je: " + ObvodPasu + "\n ABSI: " + ABSI().ToString();
        }
    }
}
