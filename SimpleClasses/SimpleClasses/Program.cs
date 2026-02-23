using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro CarroNuevo = new Carro();

            CarroNuevo.Marca = "Nissan";
            CarroNuevo.Modelo = "Coche";
            CarroNuevo.Año = 2006;
            CarroNuevo.Color = "Blanco";

            Console.WriteLine("{0} - {1} - {2}", CarroNuevo.Marca, CarroNuevo.Modelo, CarroNuevo.Color);

            //double ValorOficial = determinarValorOficial(CarroNuevo);

            Console.WriteLine("Valor del carro: {0:c}", CarroNuevo.determinarValorOficial());
            Console.ReadLine();
        }

        private static double determinarValorOficial(Carro _carro)
        {
            double carroValor = 100.0;
            return carroValor;
        }
    }

    class Carro 
    { 
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }

        public double determinarValorOficial()
        {
            double carroValor = 100.0;
            if (this.Año > 1990)
                carroValor = 10000.0;
            else
                carroValor = 2000.0;
            return carroValor;
        }

    }
}
