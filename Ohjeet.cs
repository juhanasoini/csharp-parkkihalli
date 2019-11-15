using System;
using System.Collections.Generic;

namespace Luokkakaavio
{
    static class Ohjeet
    {

        public static List<string> TulostaOhjeet()
        {
            Console.WriteLine("|------------------------|");
            Console.WriteLine("| [p] = parkkeeraa auto  |");
            Console.WriteLine("| [n] = nouda auto       |");
            Console.WriteLine("| [l] = listaa autot     |");
            Console.WriteLine("| [t] = listaa tarkemmin |");
            Console.WriteLine("| [o] = näytä ohjeet     |");
            Console.WriteLine("|------------------------|\n");

            List<string> vaihtoehdot = new List<string>();
            vaihtoehdot.Add("p");
            vaihtoehdot.Add("n");
            vaihtoehdot.Add("l");
            vaihtoehdot.Add("t");
            vaihtoehdot.Add("o");
            vaihtoehdot.Add("c");

            return vaihtoehdot;
        }
    }
}
