using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_4
{
    internal class Constructor
    {
        //
        public Constructor(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        //Constructor para tener datos fijos..

        //
        public Constructor()
        {

        }
        //Sobrecargar el constructor..

        private string color;
        private string material;

        //Destructor
        ~Constructor()
        {
            //Proceso...
        }
        //
    }
}
