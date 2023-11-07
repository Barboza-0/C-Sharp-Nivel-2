using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_1
{
    internal class Program
    {
        //Herencia..
        static void Main(string[] args)
        {
            Persona person1 = new Persona();
            Lider leader1 = new Lider();

            leader1.Nombre = "Luis Enrique";
            leader1.Apellido = "Muñoz Benavidez";
            leader1.Puesto = "dueño de la empresa";

            Console.WriteLine("El señor " + leader1.Nombre + " " + leader1.Apellido + " es " + leader1.Puesto);
            Console.ReadKey();
        }
    }
}
