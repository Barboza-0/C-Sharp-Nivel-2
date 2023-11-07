using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_5
{
    internal class Gato : AnimalDomestico
    {
        //Sobreescritura de métodos..
        public override string Comunicarse()
        {
            return "Miau... Miau...";
        }
    }
}
