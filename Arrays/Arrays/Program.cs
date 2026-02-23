using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            numeros[0] = 4;
            numeros[1] = 8;
            numeros[2] = 12;
            numeros[3] = 16;
            
            Console.WriteLine(numeros.Length);

            /*int[] numeros = new int[] { 4, 8, 12, 16 };
            Console.WriteLine(numeros[1].ToString());
            Console.ReadLine();*/

            /*string[] nombres = new string[] { "Ximena", "Diego", "Jose", "Lorena" };
            foreach (string nombre in nombres)
            { 
                Console.WriteLine(nombre);
            }
            Console.ReadLine();*/

            /*
            string zig = "Bajo la luna gita las cosas la estan mirando" + 
                "y ella no puede mirarlas";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);
            */
            Console.ReadLine();
        }
    }
}
