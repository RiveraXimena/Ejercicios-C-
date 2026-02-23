using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            //Console.WriteLine("Hello world!");
            Console.WriteLine("Escribe el nombre de una mascota y te dare su sonido ");
            string userValue = Console.ReadLine();

            Mascota myValue;

            if (Enum.TryParse<Mascota>(userValue, true, out myValue))
            {

                switch (myValue)
                {
                    case Mascota.Perro:
                        Console.WriteLine("Ladra");
                        break;
                    case Mascota.Gato:
                        Console.WriteLine("Maulla");
                        break;
                    case Mascota.Loro:
                        Console.WriteLine("Imita sonidos");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ese nobre no se encuentra en el programa");
            }


            Console.ReadLine();

        }
    }

    enum Mascota
    {
        Perro,
        Gato, Loro
    }

}
