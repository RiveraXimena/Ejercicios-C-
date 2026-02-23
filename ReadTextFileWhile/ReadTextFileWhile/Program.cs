using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }
                myReader.Close();
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("No se encontro el archivo, estas seguro que el Directorio existe?");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("No se encuentra el archivo, estas seguro que es el archivo correcto?");
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo no esta funcionando correctamente: {0}", e.Message);
            }

            finally 
            {

            }
            Console.ReadLine();
        }
    }
}
