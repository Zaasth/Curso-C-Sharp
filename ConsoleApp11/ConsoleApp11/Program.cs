using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contagem = 1000;

            while (contagem >= 1) 
            {
                contagem--;
                Console.WriteLine($"Falta {contagem} segundos pro foguete ser lançado");
                Thread.Sleep(5);
   
                if (contagem <= 10)
                {
                    Thread.Sleep(1000);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O FOGUETE FOI LANÇADO!");
            Console.ReadLine();
        }
    }
}
