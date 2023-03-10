using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Soba:Lokacija
    {
        string dekoracija;
        public Soba(string i, string v) : base(i)
        {
            dekoracija = v;
        }
        public new string Opis()
        {
            string r = base.Opis();
            r += Environment.NewLine;
            r += "Vidiš " + dekoracija + Environment.NewLine;
            return r;
        }
    }
}
