using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader myStreamRead =
                new System.IO.StreamReader("Hola.txt");

            string line = myStreamRead.ReadLine();

            Console.WriteLine(line);

            myStreamRead.Close();
            Console.ReadLine();
        }
    }
}
