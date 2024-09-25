using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    public class Orszag
    {
        public string orszag { get; set; }
        public int terulet { get; set; }
        public int nepessegg { get; set; }
        public string fovaros { get; set; }
        public int fmepesseg { get; set; }



        public Orszag(string sor)
        {
            string[] darab = sor.Split(';');
            this.orszag = darab[0];
            this.terulet= Convert.ToInt32(darab[1]);
            this.nepessegg = Convert.ToInt32(darab[2]);
            this.fovaros = darab[3];
            this.fmepesseg = Convert.ToInt32(darab[4]);
        }
    }
}
