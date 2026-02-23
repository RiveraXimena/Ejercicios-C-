using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro myCar = new Carro();

            Carro Carro2 = myCar;

            Carro Carro3 = new Carro("Nissan", "Coche", 2006, "Blanco");

            Carro2 = null;
            myCar = null;

            Carro.MyMethod();
        }
    }

    class Carro 
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
        public double PrecioOriginal { get; set; }

        public Carro() 
        {
            this.Marca = "Nissan";
        }

        public Carro(string marca, string modelo, int año, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
        }

        /*public Carro(string Otro, string modelo, int año, string color)
        {
            Marca = Otro;
            Modelo = modelo;
            Año = año;
            Color = color;
        }
        */
        public static void MyMethod()
        {
            
        }
    }
}
