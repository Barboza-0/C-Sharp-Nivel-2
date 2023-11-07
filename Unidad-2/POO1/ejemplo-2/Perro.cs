using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2
{
    internal class Perro
    {
        private string nombre;
        private string color;
        private string raza;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Raza 
        {
            get { return raza; }
            set { raza = value; }
        }
    }
}
