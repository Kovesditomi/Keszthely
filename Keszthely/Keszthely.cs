using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszthely
{
    internal class Keszthely
    {
        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Rajtszam { get; set; }
        public string Neme { get; set; }
        public string Eletkor { get; set; }
        public TimeSpan Uszas { get; set; }
        public TimeSpan ElsoDepo { get; set; }
        public TimeSpan Kerekpar { get; set; }
        public TimeSpan MasodikDepo { get; set; }
        public TimeSpan Futas { get; set; }
        public TimeSpan Osszesido { get; set; }
        public Keszthely(string s)
        {
            string[] v = s.Split(';');
            Nev = v[0];
            SzuletesiEv = int.Parse(v[1]);
            Rajtszam = int.Parse(v[2]);
            Neme = v[3];
            Eletkor = v[4];
            Uszas = TimeSpan.Parse(v[5]);
            ElsoDepo = TimeSpan.Parse(v[6]);
            Kerekpar = TimeSpan.Parse(v[7]);
            MasodikDepo = TimeSpan.Parse(v[8]);
            Futas = TimeSpan.Parse(v[9]);
        }
        public override string ToString()
        {
            return $"Név: {Nev}, Születési év:{SzuletesiEv}, Rajtszám:{Rajtszam}, Neme:{Neme}, Életkor:{Eletkor}, Úszás:{Uszas},Első Depó:{ElsoDepo}, Kerékpár:{Kerekpar}, Második Depó:{MasodikDepo},Futás:{Futas}";
        }
    }
}
