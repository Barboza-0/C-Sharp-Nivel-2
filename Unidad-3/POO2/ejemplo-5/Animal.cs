using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_5
{
    internal class Animal
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public virtual string Comunicarse()
        {
            return "Ruido... Ruido...";
        }

    }
}
