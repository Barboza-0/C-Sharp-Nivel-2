using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_1
{
    internal class Persona
    {
        //Atributos
        private int edad;
        private float sueldo;
        private string nombre;
        // O miembros de la clase Persona.

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        //Funcion para guardar edad. (Esta no es la manera correcta)

        //public void setEdad(int e)
        //{
            //edad = e;
        //}

        //Funcion para mostrar edad. (Esta no es la manera correcta)

        //public int getEdad()
        //{
            //return edad;
        //}
    }
}
