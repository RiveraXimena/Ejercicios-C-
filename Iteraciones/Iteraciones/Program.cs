using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Iteraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 18; i++)
            {
                //Console.WriteLine(i.ToString());

                if (i == 8)
                {
                    Console.WriteLine("Lo encontraste");
                    break;
                }
            }

            for (int Valor = 0; Valor < 12; Valor++)
            {
                Console.WriteLine(Valor);
            }
                Console.ReadLine();
        }
    }
}
