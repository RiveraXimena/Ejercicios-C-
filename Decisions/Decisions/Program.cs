using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Porfavor escribe algo y preciona Enter");
            string Valores;
            Valores = Console.ReadLine();
            Console.WriteLine("Escribiste: " + Valores);*/

            Console.WriteLine("Que prefieres, el numero 1, 2 o 3?");
            string Valores = Console.ReadLine();

            //string message = "";
            //if (Valores == "1")
            //{ 
            //    message = "Ganaste una paleta";
            //    //Console.WriteLine("Ganaste una paleta");
            //    //Console.ReadLine();
            //}
            //else if (Valores == "2")
            //    message = "Ganaste un lapiz";
            //else if (Valores == "3")
            //    message = "Suerte para la proxima.";
            //else
            //    message = "No entendimos prueba de nuevo";
            //Console.WriteLine(message);

            string message = (Valores == "1") ? "Paleta" : "Dulce";
            Console.WriteLine("Ganaste: {0}", message, Valores);
            Console.ReadLine();
        }
    }
}
