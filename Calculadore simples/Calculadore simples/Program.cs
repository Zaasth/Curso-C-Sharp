using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadore_simples
{
    internal class Program
    {

        enum Menu
        {
            Lista = 1, Calculadora, Voltar
        }

        static void Main(string[] args)
        {

            menu();
            somas();

            void somas()
            {
                Console.WriteLine("=========================");
                Console.WriteLine("Digite seu primeiro número:");
                float input1 = float.Parse(Console.ReadLine());

                Console.WriteLine("=========================");
                Console.WriteLine("Agora digite o operador aritimetico:");
                string input2 = Console.ReadLine();

                Console.WriteLine("=========================");
                Console.WriteLine("Digite seu segundo número:");
                float input3 = float.Parse(Console.ReadLine());

                Console.WriteLine("=========================");
                Console.WriteLine("O resultado foi:");

                switch (input2)
                {

                    case "-":
                        Console.WriteLine(input1 - input3);
                        break;
                    case "+":
                        Console.WriteLine(input1 + input3);
                        break;
                    case "/":
                        Console.WriteLine(input1 / input3);
                        break;
                    case "*":
                        Console.WriteLine(input1 * input3);
                        break;

                    default:
                        checar();
                        break;
                }
            }

            void checar()
            {
                Console.WriteLine("Essa não é uma opção válida, digite novamente");
                somas();
            }
            
            void menu()
            {
                Console.WriteLine("=========================");
                Console.WriteLine("Escolha uma das opções:");
                Console.WriteLine("1-Lista\n2-Calculadora\n3-Voltar");
                Console.WriteLine("=========================");
                int escolha = int.Parse(Console.ReadLine());
                Menu opcaoselecionada = (Menu)escolha;
                Console.WriteLine("Você escolheu a opção: " + opcaoselecionada);

                switch (opcaoselecionada)
                {
                    case Menu.Lista:
                        Console.WriteLine("=========================");
                        Console.WriteLine("+\tAdição\r\n-\tSubtração\r\n*\tMultiplicação\r\n/\tDivisão\r\n%\tMódulo (resto da divisão)");
                        Console.WriteLine("=========================");
                        break;
                    case Menu.Voltar:
                        menu();
                        break;
                    case Menu.Calculadora:
                        somas();
                        break;
                    default:
                        Console.WriteLine("=========================");
                        Console.WriteLine("Opção inválida, escolha uma opção válida");
                        menu();
                        break;
                }
            }



            //Console.WriteLine(input1);





            Console.ReadLine();
        }
    }
}
