using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Luokkakaavio
{
    public class Auto : Moottoriajoneuvo
    {
        public Kuljettaja kuljettaja;

        public Auto()
        {
            this.Tyyppi = "Henkilöauto";
        }

        public Auto(String merkki, String malli ) : base( merkki, malli )
        {
        }

        public override string kutsumanimi()
        {
            return Tyyppi + ": " + Merkki + " " + Malli;
        }
    }
}