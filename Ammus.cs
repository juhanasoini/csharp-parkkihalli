using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokkakaavio
{
    class Ammus
    {
        int saldo = 0;
        string tyyppi = "";

        public Ammus( string tyyppi, int saldo = 0 )
        {
            tyyppi = tyyppi;
            saldo = saldo;
        }
    }
}
