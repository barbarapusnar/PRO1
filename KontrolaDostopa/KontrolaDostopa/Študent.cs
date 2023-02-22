using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaDostopa
{
    internal class Študent
    {
        private string študentID;
        public string ŠtudentID { get => študentID; set => študentID = value; }
        private string ime; //atribut
        //lastnost
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string naslov;
        public string Naslov { get => naslov; set => naslov = value; }
        private int starost;
        public int Starost
        {
            get { return starost; }
            set { 
            if (value>=18)
                    starost = value;
            else
                    starost = -1;
            }
        }
        private double povprečnaOcena;
        public double PovprečnaOcena
        { 
         get { return povprečnaOcena; }
        }

        

        public Študent()
        {
            študentID = "1234";
            ime = "Janez Novak";
            naslov = "Cankarjeva 5, Nova Gorica";
            starost = 19;
            povprečnaOcena = 7.5;
        }
        public void Izpis()
        {
            Console.WriteLine("*******ŠTUDENT*********");
            Console.WriteLine("ID        "+študentID);
            Console.WriteLine("Ime       "+ime);
            Console.WriteLine("Naslov    "+naslov);
            Console.WriteLine("Starost   "+starost);
            Console.WriteLine("Povprečje "+povprečnaOcena);
            Console.WriteLine("***********************");
        }
    }
}
