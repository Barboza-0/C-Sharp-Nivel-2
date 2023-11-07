using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_3
{
    internal class Articulo
    {
        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }

        private int codigoMarca;
        //Se crea un metodo aparte porque va del 1 al 10 y las demas variables no tienen limite de precio ni de codigo de articulo.

        public int CodigoMarca
        {
            get { return codigoMarca;}
            set
            {
                if(value > 0 && value <= 10)
                    codigoMarca = value;
                else
                    codigoMarca = 0;
            }
        }
    }
}
