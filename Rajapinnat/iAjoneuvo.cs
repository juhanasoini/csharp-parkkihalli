using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Luokkakaavio.Rajapinnat
{
    public interface iAjoneuvo
    {
        string Merkki { get; set; }

        string Malli { get; set; }

        string Tyyppi { get; set; }

        string kutsumanimi();
    }
}