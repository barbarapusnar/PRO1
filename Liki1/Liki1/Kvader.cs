using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki1
{
    internal class Kvader:Pravokotnik
    {
        int višina;
        public Kvader(int x1p,int y1p,int x2p,int y2p,int vk):base(x1p,y1p,x2p,y2p)
        {
            višina = vk;
        }
        public int Prostornina()
        {
            return base.Ploščina() * višina;
        }
        public int Površina()
        {
            return 2 * base.Ploščina() +
                   2 * base.StranicaA() * višina +
                   2 * base.StranicaB() * višina;
        }
    }
}
