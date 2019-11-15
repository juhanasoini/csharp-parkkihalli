using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Luokkakaavio.Rajapinnat
{
    public interface iAjoneuvo
    {

        //public Ajoneuvo()
        //{

        //}
        //public Ajoneuvo(String merkki, String malli)
        //{
        //    this.Merkki = merkki;
        //    this.Malli = malli;
        //}

        string Merkki { get; set; }

        string Malli { get; set; }

        string Tyyppi { get; set; }

        string kutsumanimi();
    }
}