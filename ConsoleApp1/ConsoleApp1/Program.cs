using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1;

            /*digiteSeuNome();
            idade();
            repeat();
            */
            Console.WriteLine("digite o valor");
            ChamarPreço(int.Parse(Console.ReadLine()));
            Console.ReadLine();

            void idade()
            {
                //float b = float.Parse(input1); Outra forma de converter


                if (input1 >= 0 && input1 <= 12)
                {
                    Console.WriteLine("Você é uma criança");
                }
                else if (input1 <= 17 && input1 >= 13)
                {
                    Console.WriteLine("Você é um adolecente");
                }
                else if (input1 >= 18 && input1 <= 49)
                {
                    Console.WriteLine("Você é um adulto");
                }
                else if(input1 >= 50 && input1 <= 130)
                {
                    Console.WriteLine("Você é um idoso");
                }
                else if (input1 >= 131)
                {
                    Console.WriteLine("Você é um dinossauro de tão velho que é");
                }
                else
                {
                    Console.WriteLine("Esse não é um número válido");
                }
                repeat();
            }


            void digiteSeuNome()
            {
                Console.WriteLine("-----------"); 
                Console.WriteLine("Digite sua idade:");
                input1 = int.Parse(Console.ReadLine());
            }

            void repeat()
            {
                digiteSeuNome();
                idade();
            }
            void ChamarPreço(int preço)
            {
                preço = preço 
                Console.WriteLine("O preço é " + preço);
            }

        }
    }
}
