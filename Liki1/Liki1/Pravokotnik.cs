using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki1
{
    internal class Pravokotnik
    {
        //        Dodajte projektu nov razred Pravokotnik.Vsebuje naj privatne izvodove
        //spremenljivke x1, y1 (koordinati zgornjega levega kota) in x2,y2(koordinati
        //spodnjega desnega kota)-vse so cela števila.Vsebuje naj tudi konstruktor razreda s
        //parametri (x1p, y1p, x2p, y2p). Nato v njem definirajte lastnosti
        // X1, Y1 in X2, Y2.       
        //Dodajte metode StranicaA (izračuna dolžino stranice a) in StranicaB(izračuna dolžino
        //straniceB ter Ploščina (izračuna ploščino pravokotnika). 

        int x1;
        int y1;
        int x2;
        int y2;
        public Pravokotnik(int x1p,int y1p,int x2p,int y2p)
        {
            x1= x1p;
            y1= y1p;
            x2= x2p;
            y2= y2p;
        }

        public int X1 { get => x1; set => x1 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y2 { get => y2; set => y2 = value; }
        public int StranicaA()
        {
            return Math.Abs(x2 - x1);
        }
        public int StranicaB()
        {
            return Math.Abs(y2 - y1);
        }
        public int Ploščina()
        {
            return StranicaA() * StranicaB();
        }
    }
}
