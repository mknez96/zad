using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad
{
    class Trosak
    {
        public double Cijena;
        public string VrstaTroska;

        public void Unos(string cijena, string vrstaTroska)
        {
            Cijena = double.Parse(cijena);
            VrstaTroska = vrstaTroska;
        }

        public string Ispis(List<Trosak> mojaLista)
        {
            string rezultat = "";
            rezultat = Cijena + "kn" + " - " + VrstaTroska;
            return rezultat;
        }
    }
}