using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Luokkakaavio
{
    public class Moottoripyora : Moottoriajoneuvo
    {
        public Moottoripyora()
        {
            this.Tyyppi = "Moottoripyörä";
        }
        public Moottoripyora(String merkki, String malli) : base(merkki, malli)
        {
        }
        //public override string kutsumanimi()
        //{
        //    return Tyyppi + ": " + Merkki + " " + Malli;
        //}
    }
}