using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono1 = new Telefono("6S PRO", "Red Magic");
            Console.Write("Ingrese su numero telefonico: "); telefono1.NumeroTelefonico = Console.ReadLine();
            Console.Write("Ingrese el codigo de operador (1 - 3): "); telefono1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine(telefono1.llamar("Maxi"));
            Console.Write(telefono1.llamar());
            Console.ReadKey();
        }
    }
}
