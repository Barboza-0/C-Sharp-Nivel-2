using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodo persona = new Metodo("Iván");
            
            Console.WriteLine(persona.saludar());
            Console.ReadKey();
        }
    }
}
