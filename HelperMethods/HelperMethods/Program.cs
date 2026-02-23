using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string Valor = Formula("Mundo");
            string Valor = Formula("Ximena");
            Console.WriteLine(Valor);
            Console.ReadLine();
        }

        private static string Formula()
        {
            return "Hola mundo!";
        }

        private static string Formula(string nombre)
        {
            return String.Format("Hola, {0}!", nombre);
        }
    }
}
