using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_7
{
    internal class Auto : Vehiculo
    {
        public Auto()
        {
            Chasis chasis = new Chasis();
        }
        public string Marca { get; set; }


        //Composición algo con lo que nace
        public Chasis Chasis { get; }

        //Agregación algo que se le agrega
        public Motor Motor { get; set; }
    }
}
