using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el nombre de una mascota para ver su sonido:");
            string userValue = Console.ReadLine();
            switch (userValue.ToUpper())
            {
                case "PERRO":
                    Console.WriteLine("Ladra");
                    break;
                case "GATO":
                    Console.WriteLine("Maulla");
                    break;
                case "LORO":
                    Console.WriteLine("Imita sonidos");
                    break;
                default:
                    Console.WriteLine("Does not compute");
                    break;
            }
            Console.ReadLine();
        }
    }
}
