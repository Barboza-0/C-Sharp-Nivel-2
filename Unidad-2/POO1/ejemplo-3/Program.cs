using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];

            for(int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();
                Console.Write("Ingrese el codigo de articulo: "); articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el precio del articulo: "); articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el codigo de marca (1 - 10): "); articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            Venta venta = new Venta();
            Console.Write("Venta.. Ingrese el codigo de cliente: "); venta.CodigoCliente = int.Parse(Console.ReadLine());
            while(venta.CodigoCliente != 0)
            {
                Console.Write("Ingrese el codigo de articulo: "); venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad :"); venta.Cantidad = int.Parse(Console.ReadLine());

                //Proceso...

                Console.Write("Venta.. Ingrese el codigo de cliente: "); venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
