using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luokkakaavio.Rajapinnat;

namespace Luokkakaavio
{
    class Parkkeeraaja
    {
        Moottoriajoneuvo ajoneuvo;
        int vaihe = 1;
        bool parkissa = false;
        //bool noudettu = false;
        public Moottoriajoneuvo parkkeeraa()
        {
            Console.WriteLine("Parkkeeraa");
            while(!parkissa)
            {
                if( vaihe == 1 )
                    kysyTyyppi();
                else if( vaihe == 2 )
                    kysyMerkki();
                else if( vaihe == 3 )
                    kysyMalli();
            }
            
            return ajoneuvo;
        }

        public void kysyTyyppi()
        {
            string[] vaihtoehdot = { "a", "m" };
            
            string tyyppi = "-1";
            while( !vaihtoehdot.Contains(tyyppi) )
            {
                Console.WriteLine("[a] auto\n"
                                + "[m] moottoripyörä\n");

                Console.Write("Anna ajoneuvon tyyppi: ");
                tyyppi = Console.ReadLine();
            }

            switch (tyyppi)
            {
                case "a":
                    ajoneuvo = new Auto();
                    break;
                case "m":
                    ajoneuvo = new Moottoripyora();
                    break;
                //case "p":
                //    ajoneuvo = new Polkupyora();
                //    break;
            }

            this.vaihe = 2;
        }

        public void kysyMerkki()
        {
            string merkki = "";
            while(merkki == "" )
            {
                if (ajoneuvo is Auto)
                    Console.Write("Anna auton merkki: ");
                else if (ajoneuvo is Moottoripyora)
                    Console.Write("Anna motskarin merkki: ");

                merkki = Console.ReadLine();
            }

            this.ajoneuvo.Merkki = merkki;
            this.vaihe = 3;
        }

        public void kysyMalli()
        {
            string malli = "";
            while(malli == "" )
            {
                if (ajoneuvo is Auto)
                    Console.Write("Anna auton malli: ");
                else if (ajoneuvo is Moottoripyora)
                    Console.Write("Anna motskarin malli: ");

                malli = Console.ReadLine();
            }

            ajoneuvo.Malli = malli;
            parkissa = true;
        }

        public int kysyRuutu()
        {
            int ruutu = -1;
            while( ruutu == -1 )
            {
                try
                {
                    Console.Write("Anna ajoneuvon ruutu: ");
                    ruutu = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine( "Ruutu ei ole kelvollinen" );
                    ruutu = -1;
                }                
            }

            return ruutu;
        }
    }
}
