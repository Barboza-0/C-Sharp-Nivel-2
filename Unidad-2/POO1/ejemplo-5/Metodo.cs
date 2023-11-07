using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_5
{
    internal class Metodo
    {
        public Metodo(string nombre)
        {
            this.nombre = nombre;
        }
        //Constructor para setear nombre..

        private string nombre;

        //Metodo
        public string saludar()
        {
            return "Hola soy " + nombre;
        }
        //Fin de metodo..
    }
}
