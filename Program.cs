using System;
using System.Globalization;

namespace CarroGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car;

            Console.Write("Informe quantos quilômetros você andou: ");
            double distancia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Informe a quantidade de gasolina necessária para encher o tanque: ");
            double tanque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            car = new Carro(distancia, tanque);
            double kmlitro = car.KmPorLitro();

            Console.Write("\nO seu carro faz " + kmlitro.ToString("F2", CultureInfo.InvariantCulture) + " km por litro");            
        }
    }
}
