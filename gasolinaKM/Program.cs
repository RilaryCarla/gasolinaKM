using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasolinaKM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do litro da gasolina: ");
            double gasolina = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distância percorrida: ");
            double distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distância que o carro anda por litro: ");
            double consumo = double.Parse(Console.ReadLine());

            double litro = distancia / consumo;

            double gasto = litro * gasolina;

            Console.WriteLine("O gasto total será de: " + gasto);
            Console.ReadKey();
        }
    }
}
