using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_8
{
    abstract class Persona
    {
        //No se pueden crear instancias en Main Program..
    }
    sealed class Personas
    {
        //No puede heredar a otras clases..
    }
    static class Person
    {
        //No se crean instancias, no puede heredar de otras ni pueden heredar de ella..
        //Se usa para llamar métodos como Console.WriteLine();
        //Console es una clase..... WriteLine() es un método
        //La clase y los métodos tienen que ser static
    }
}
