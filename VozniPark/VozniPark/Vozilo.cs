using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VozniPark
{
    internal abstract class Vozilo
    {
        //imajo proizvajalca, model, leto izdelave in barvo
        protected string proizvajalec;
        protected string model;
        protected int leto;
        protected string barva;

        public string Proizvajalec { get => proizvajalec; 
            set => proizvajalec = value; }
        public string Model { get => model; set => model = value; }
        public int Leto { get => leto; set => leto = value; }
        public string Barva { get => barva; set => barva = value; }
    }
}
