using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_4
{
    internal class Program
    {
        //Colecciones..
        static void Main(string[] args)
        {
            Personas person1 = new Personas();
            Personas person2 = new Personas();
            Personas person3 = new Personas();
            List<Personas> listaPersonas = new List<Personas>();

            person1.Nombre = "Iván";
            person2.Nombre = "Luciana";
            person3.Nombre = "Julio";
            listaPersonas.Add(person1);
            listaPersonas.Add(person2);
            listaPersonas.Add(person3);
            Console.WriteLine(listaPersonas[2].Nombre);
            listaPersonas.Remove(person3);

            Console.WriteLine("Hay un total de " + listaPersonas.Count);
            Console.WriteLine(person1.Nombre + " y " + listaPersonas[1].Nombre);

            foreach (Personas item in listaPersonas)
            {
                Console.WriteLine("Nombre: " + item.Nombre);
            }

            Console.ReadKey();
        }
    }
}
