using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvropskoPrvenstvo
{
    internal class Ekipa
    {
        string ime;
        int štTekem;
        int štZmag;
        int štNeodločenih;
        int daniGoli;
        int prejetiGoli;
        public Ekipa(string i)
        {
            ime = i;
            štTekem = 0;štZmag = 0;štNeodločenih = 0;
            prejetiGoli = 0;daniGoli = 0;
        }
        public void VnesiRezultat(int d, int p)
        {
            //ta ekipa je dala d golov in prejela p golov
            štTekem++;
            if (d > p)
                štZmag++;
            else
                if (d == p)
                  štNeodločenih++;
            daniGoli += d;
            prejetiGoli += p;
        }
        public int ŠteviloTočk()
        {
            return 3 * štZmag + štNeodločenih;
        }
        public int GolRazlika()
        {
            return daniGoli - prejetiGoli;
        }
        public void Izpis()
        {
            Console.WriteLine(ime+"\t"+ŠteviloTočk()+"\t"+GolRazlika()+
                "\t"+daniGoli);
        }
        public bool BoljšaEkipa(Ekipa druga)
        {
            if (this.ŠteviloTočk() > druga.ŠteviloTočk())
                return true;
            if (this.ŠteviloTočk() == druga.ŠteviloTočk() &&
                this.GolRazlika() > druga.GolRazlika())
                return true;
            if (this.ŠteviloTočk() == druga.ŠteviloTočk() &&
                this.GolRazlika() == druga.GolRazlika() &&
                this.daniGoli > druga.daniGoli)
                return true;
            return false;
        }
        public string Ime { get => ime; set => ime = value; }
        public int ŠtTekem { get => štTekem; set => štTekem = value; }
        public int ŠtZmag { get => štZmag; set => štZmag = value; }
        public int ŠtNeodločenih { get => štNeodločenih; set => štNeodločenih = value; }
        public int DaniGoli { get => daniGoli; set => daniGoli = value; }
        public int PrejetiGoli { get => prejetiGoli; set => prejetiGoli = value; }
    }
}
