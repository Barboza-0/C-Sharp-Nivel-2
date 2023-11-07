using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_3
{
    internal class Program
    {
        //Tipos de valor y de referencia..
        static void Main(string[] args)
        {
            Persona Person1 = new Persona();
            Persona Person2 = Person1; //Apunta al mismo objeto que Person1 y cambiará el estado de Person1.

            Person1.Nombre = "Julio";
            Person2.Nombre = "Maxi";

            Console.WriteLine(Person1.Nombre);
            Console.ReadKey();
        }
    }
}
