using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese cuanto tiene la botella (0 - 100): ");
            Botella bot1 = new Botella(int.Parse(Console.ReadLine()));
            Console.WriteLine("Se recargó " + bot1.DifCapacidad + " el total es de " + bot1.recarga());
            Console.ReadKey();
        }
    }
}
