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
            DateTime fecha = DateTime.Now;

            //DateTime fecha2 = new DateTime();
            //fecha.AddDays(1);
            //fecha.AddYears(1);
            //fecha.ToLongTimeString();
            //fecha.ToShortTimeString();
            
            Console.WriteLine("La fecha es " + fecha.ToString()); //ToString("d/m/y")

            Console.ReadKey();
        }
    }
}
