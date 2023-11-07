using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_7
{
    internal class Sobrecarga
    {
        //Sobrecarga de Metodos..

        private string nombre;

        public string Nombre(string name)
        {
            return "Hola " + name + ", soy Iván";
        }
    }
}
