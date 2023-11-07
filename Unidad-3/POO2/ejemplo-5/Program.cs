using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_5
{
    internal class Program
    {
        //Sobreescritura de métodos..
        static void Main(string[] args)
        {
            Gato cat1 = new Gato();
            cat1.Nombre = "Gata";
            Perro dog1 = new Perro();
            dog1.Nombre = "Lulú";

            List<Animal> animales = new List<Animal>();
            animales.Add(cat1);
            animales.Add(dog1);

            Animal a1 = cat1;
            Gato cat2 = (Gato)a1;
            Console.WriteLine(cat2.Nombre);
            
            Console.WriteLine(cat1.Nombre + " hace " + cat1.Comunicarse());
            Console.WriteLine(dog1.Nombre + " hace " +  dog1.Comunicarse());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.Comunicarse());
            }
            //POLIMORFISMO reacciones distintas al mismo estimulo en este caso, todos los animales se comunican pero con distintos ruidos..
            Console.ReadKey();
        }
    }
}
