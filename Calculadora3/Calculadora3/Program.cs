using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora3
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potência, Raíz, Sair }

        static void Main(string[] args)
        {
            bool Escolheusair = false;
            while (!Escolheusair)
            {
                Console.WriteLine("Seja bem vindo a calculadora, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Sair");
                string index1 = Console.ReadLine();
                int index2 = int.Parse(index1);
                Menu OpçãoEscolhida = (Menu)index2;

                switch (OpçãoEscolhida)
                {
                    case Menu.Soma:
                        Console.WriteLine("Gay");
                        break;
                    case Menu.Subtração:
                        break;
                    case Menu.Divisão:
                        break;
                    case Menu.Multiplicação:
                        break;
                    case Menu.Potência:
                        break;
                    case Menu.Raíz:
                        break;
                    case Menu.Sair:
                        Escolheusair = true;
                        Console.WriteLine("teste");
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
            Console.WriteLine("Tu é gay");
            
        }
    }
}
