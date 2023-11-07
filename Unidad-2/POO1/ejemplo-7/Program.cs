using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sobrecarga persona = new Sobrecarga();

            Console.WriteLine(persona.Nombre("Maxi"));
            Console.ReadKey();
        }
    }
}
