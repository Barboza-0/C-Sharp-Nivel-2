using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_dominio
{
    internal class Auto : Vehiculo
    {
        public Auto()
        {
            Chasis = new Chasis();
        }
        public Chasis Chasis { get; }
        public int Año { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Motor Motor { get; set; }
    }
}
