using ConsoleApp1;
using Microsoft.VisualBasic;
using System.Net.Http.Headers;

class Program
{
    class Oseba
    {
        private string ime;
        private string priimek;

        //javna metoda razreda
        public void NastaviIme(string ime, string priimek)
        {
            this.ime = ime;
            this.priimek = priimek;
        }

        //javna lastnost razreda
        public string PolnoIme
        {
            get { return ime+" "+priimek; }
            set 
            { 
                string zacasna = value; 
                //celotno ime razdelimo na posamezne besede in jih 
                //shranimo v tabelo
                string[] imena=zacasna.Split(' ');
                ime=imena[0];
                priimek=imena[1];
            }
        }
    }
        
    static void Main(string[] args)
    {
        Oseba o1 = new Oseba();
        o1.NastaviIme("Janez", "Novak");
        Console.WriteLine("Polno ime osebe: " + o1.PolnoIme);
        Oseba o2 = new Oseba();
        o2.NastaviIme("Peter", "Leban");
        Console.WriteLine("Polno ime osebe: " + o2.PolnoIme);
    }   
}
        
