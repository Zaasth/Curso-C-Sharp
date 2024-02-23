using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace estruturas_de_repetições_exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float velocidade = 0.0f;
            float velocidademáxima = 200f;

            for (velocidade = 0; velocidade <= velocidademáxima; velocidade += 10)
            {
                Console.WriteLine($"O carro de corrida está a {velocidade} Km/h");
                Thread.Sleep(200);
            }
            Console.WriteLine("====================");
            Console.WriteLine("O carro chegou ao limite de velocidade que é 200km/h");

            Console.ReadLine();

            
        }
    }
}
