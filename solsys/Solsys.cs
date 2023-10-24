using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solsys
{
    class Solsys
    {
        public string BolygoNeve { get; set; }
        public int HoldjainakSzama { get; set; }
        public double TerfogataAFoldhozKepest { get; set; }

        public Solsys(string s) 
        { 
            string[] v = s.Split(';');
            this.BolygoNeve = v[0];
            this.HoldjainakSzama = int.Parse(v[1]);
            this.TerfogataAFoldhozKepest = double.Parse(v[2]);
        }

    }
}
