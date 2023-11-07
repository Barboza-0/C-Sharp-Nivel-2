using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos nueva persona.
            Persona player = new Persona();
            //Le damos una edad con la funcion.
            player.Edad = 23;
            int edad = player.Edad;

            Console.WriteLine("La edad de la persona es " + edad);
            Console.ReadKey();
        }
    }
}
