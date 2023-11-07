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
            AutoDeportivo Corvette = new AutoDeportivo();
            Corvette.Marca = "Chevrolet";
            Corvette.Motor = "V8";
            Corvette.Modelo = "Corvette";

            Console.WriteLine("El " + Corvette.Marca + " " + Corvette.Modelo + " tiene un motor " + Corvette.Motor);
            Console.ReadKey();
        }
    }
}
