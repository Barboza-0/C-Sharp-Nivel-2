using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructor constructor = new Constructor("Negro", "Metalico");
            //Crea una instancia vacia de un objeto..
            //Con la sobrecarga se puede usar varios constructores..
            Constructor constructor1 = new Constructor();


        }
    }
}
