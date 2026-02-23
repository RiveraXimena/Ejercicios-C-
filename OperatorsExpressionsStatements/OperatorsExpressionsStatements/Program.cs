using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b;

            x = 1;
            y = 8;
            a = 2;
            b = 4;

            x = 1 + 8;
            x = 4 - 2;
            x = 8 * 4;

            if (x == y)
            {
            }
            if (x > y)
            {
            }
            if (x < y)
            {
            }
            if (x >= y)
            {
            }
            if (x <= y)
            {
            }

            if ((x > y) && (a > b)) 
            { 
            }

            if ((x > y) || (a > b))
            {
            }

            string message = (x == 1) ? "Paleta" : "Dulce";

            Console.WriteLine("Hola");
        }
    }
}
