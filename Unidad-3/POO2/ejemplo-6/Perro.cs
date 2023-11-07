using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_6
{
    internal class Perro : AnimalDomestico, Ladrador
    {
        public string volar()
        {
            return "Ladra fuertemente..";
        }
    }
}
