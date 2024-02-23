using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Estruturas_de_repetição_exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int horario1 = 7;
            int horario2 = 17;

            for (horario1 = 7; horario1 <= horario2; horario1++) 
            { 
                Console.WriteLine("O mercado está em horário de funcionamento.");
                Console.WriteLine($"Horário atual {horario1} horas");
                Thread.Sleep(200);
            }

            Console.WriteLine("O mercado está fechado.");

            Console.ReadLine();
        }
    }
}
