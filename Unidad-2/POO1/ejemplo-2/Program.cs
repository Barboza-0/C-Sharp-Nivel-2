using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro dog1 = new Perro();
            Console.Write("Ingrese el nombre de su mascota canina: "); dog1.Nombre = Console.ReadLine();
            Console.Write("Ingrese el color de su mascota canina: "); dog1.Color = Console.ReadLine();
            Console.Write("Ingrese la raza de su mascota canina: "); dog1.Raza = Console.ReadLine();

            Console.WriteLine(dog1.Nombre + " es un(a) " + dog1.Raza + " de color " + dog1.Color);
            Console.ReadKey();
        }
    }
}
