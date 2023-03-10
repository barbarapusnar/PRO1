using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Program
    {
        static Soba dnevnaSoba;
        static Soba kuhinja;
        static Soba jedilnica;
        static Zunanji vrt;
        static Zunanji sprednje;
        static Zunanji zadnje;
        static Lokacija trenutnaPozicija;
        static void PremakniSe(Lokacija novaLokacija)
        {
            trenutnaPozicija = novaLokacija;
            Console.WriteLine(trenutnaPozicija.Opis());
        }
        static void Main(string[] args)
        {
            UstvariHišo();
            trenutnaPozicija = dnevnaSoba;
            PremakniSe(dnevnaSoba);
            string odg = "";
            //od tukaj
            while (odg != "K")
            {
                Console.WriteLine("Kam naj grem? K=konec");
                odg = Console.ReadLine();
                Lokacija nova = null;
                if (odg.ToUpper() == "K")
                {
                    Console.WriteLine("Lep sprehod");
                }
                else
                {
                    int n = int.Parse(odg);
                    nova = new Lokacija(trenutnaPozicija.izhodi[n].ime);
                    switch (nova.ime)
                    {
                        case "dnevna soba":
                            nova = dnevnaSoba; break;
                        case "kuhinja":
                            nova = kuhinja; break;
                        case "jedilnica":
                            nova = jedilnica; break;
                        case "sprednje dvorišče":
                            nova = sprednje; break;
                        case "zadnje dvorišče":
                            nova = zadnje; break;
                        case "vrt":
                            nova = vrt; break;
                    }
                    PremakniSe(nova);
                }//do tukaj ponavljamo
            }
        }
        static void UstvariHišo()
        {
            dnevnaSoba = new Soba("dnevna soba", "starinskih tepih");
            kuhinja = new Soba("kuhinja", "srebrn pribor");
            jedilnica = new Soba("jedilnica", "lončen lonec");
            vrt = new Zunanji("vrt", false);
            sprednje = new Zunanji("sprednje dvorišče", true);
            zadnje = new Zunanji("zadnje dvorišče", false);

            dnevnaSoba.izhodi = new Lokacija[2];
            dnevnaSoba.izhodi[0] = sprednje;
            dnevnaSoba.izhodi[1] = jedilnica;

            kuhinja.izhodi = new Lokacija[2];
            kuhinja.izhodi[0] = dnevnaSoba;
            kuhinja.izhodi[1] = zadnje;

            jedilnica.izhodi = new Lokacija[2];
            jedilnica.izhodi[0] = dnevnaSoba;
            jedilnica.izhodi[1] = kuhinja;

            vrt.izhodi = new Lokacija[2];
            vrt.izhodi[0] = sprednje;
            vrt.izhodi[1] = zadnje;

            sprednje.izhodi = new Lokacija[2];
            sprednje.izhodi[0] = dnevnaSoba;
            sprednje.izhodi[1] = vrt;

            zadnje.izhodi = new Lokacija[2];
            zadnje.izhodi[0] = vrt;
            zadnje.izhodi[1]=kuhinja;

        }
    }
}
