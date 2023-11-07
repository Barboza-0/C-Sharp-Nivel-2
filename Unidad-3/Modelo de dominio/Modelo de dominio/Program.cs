using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_dominio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            auto1.Motor = new Motor();
            Console.WriteLine(auto1.Motor.Encender());
            Console.ReadKey();
        }
    }
}
