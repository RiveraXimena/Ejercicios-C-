using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona un numero entre el 1 y 100");
            string userValue = Console.ReadLine();
            
            int compareValue = int.Parse(userValue);
            
            if ((compareValue < 1) || (compareValue > 100))
                Console.WriteLine("El numero que escribiste esta fuera del rango");
            else if ((compareValue == 42) || (compareValue > 90))
                Console.WriteLine("Encontraste el numero especial");
            else
                Console.WriteLine("No encontraste numeros especiales");
            Console.ReadLine();
        }
    }
}
