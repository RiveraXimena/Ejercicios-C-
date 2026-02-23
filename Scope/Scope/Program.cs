using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    internal class Program
    {
        //private static string k = "";
        static void Main(string[] args)
        {
            /*string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine("l: " + l);
            }
            //Console.WriteLine(i);
            
            Console.WriteLine("Pasa del: " + j);
            //Console.WriteLine("k: " + k);

            Metodo();*/


            Mascotas mascotas = new Mascotas();
            mascotas.Algo();

            Console.ReadLine(); 
        }

        /*static void Metodo()
        {
            Console.WriteLine("k del metodo: " + k);
        }*/
    }

    class Mascotas
    {
        public void Algo()
        {
            Console.WriteLine(Metodo());
        }

        private string Metodo()
        {
            return "Hola!";
        }
    }
}
