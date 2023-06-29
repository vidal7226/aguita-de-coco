using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4
{
    internal class Programa2
    {

        static void Main(string[] args)
        {

            // Creamos un objeto coche
            Coche c = new Coche(1, "BMW", "4", 100, 12000);

            // get de precio de coche
            Console.WriteLine(c.precio);

            // get de marca de coche
            Console.WriteLine(c.marca);

            // Modifico el precio del coche con el set
            c.precio = 15000;

            // Vuelvo a mostrar para ver si se ha modificado
            Console.WriteLine(c.precio);

            // Muestro el estado completo
            Console.WriteLine(c.ToString());

            Console.ReadLine();
        }
    }
}
