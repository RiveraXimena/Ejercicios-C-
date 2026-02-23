using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Ve a tu c:\\drive";

            //string myString = "Tu eres\"intelligente\"verdad?";

            //string myString = "Todo lo que necesito \nes dejar de pensar";

            //string myString = string.Format("{0}!", "Naturaleza");

            //string myString = string.Format("Make: {0} (Model: {1})", "Lamborgini", "123HGB");

            //string myString = string.Format("{0:C}", 202.18);

            //string myString = string.Format("{0:N}", 3141618);

            //string myString = string.Format("{0:P}", .1802);

            //string myString = string.Format("Numero Celular: {0: (###) ###-####}", 2851123368);

            /*string myString = "";

            for (int i = 0; i < 50; i++)
            {

                //myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();
            }*/

            /*StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 50; i++) 
            {
                myString.Append("--");
                myString.Append(i);
            }*/

            string myString = " Ese verano fue el mejor verano que tuve ";

            //myString = myString.Substring(0, 10);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            myString = String.Format("Antes: {0} -- Despues: {1}", myString.Length, myString.Trim().Length);


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
