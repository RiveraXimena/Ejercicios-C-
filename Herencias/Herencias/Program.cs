using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro Carro1 = new Carro();
            Carro1.Marca = "Nissan";
            Carro1.Modelo = "Coche";
            Carro1.Color = "Blanco";
            Carro1.Año = 2006;

            printVehicleDetails(Carro1);

            Remolque myRemolque = new Remolque();
            myRemolque.Marca = "Ford";
            myRemolque.Modelo = "F267";
            myRemolque.Color = "Blanco";
            myRemolque.Año = 2007;
            myRemolque.Capacidad = 1000;

            printVehicleDetails(myRemolque);

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehiculo vehiculo)
        {
            Console.WriteLine("Los detalles del vehiculo son: {0}", vehiculo.FormatMe());
        }
    }

    abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Año { get; set; }

        public abstract string FormatMe();
    }

    class Carro : Vehiculo
    {
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.Marca, this.Modelo, this.Color, this.Año);
        }
    }

    class Remolque : Vehiculo
    {
        public int Capacidad { get; set; }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Unidades", this.Marca, this.Modelo, this.Capacidad);
        }
    }
}