using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_Dados
{
    internal class Program
    {

        enum Menu
        {
            Rolar = 1, Inicio, Sair
        }
        static void Main(string[] args)
        {

            inicio();


            void inicio()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Dado dados = new Dado();


                Console.WriteLine("Escolha quantas vezes deseja rolar o dado:");
                dados.quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("=====================");
                Console.WriteLine("Escolha quantos lados esse dado vai ter: ");
                dados.lados = int.Parse(Console.ReadLine());

                Console.WriteLine("=====================");
                Console.WriteLine($"Aperte enter para confimar a rolagem do {dados.quantidade}D{dados.lados}: ");
                Console.ReadLine();

                Console.Clear();
                dados.rolar();

                menuzin();


                void menuzin()
                {
                    Console.WriteLine("=====================");
                    Console.WriteLine("1- Rolar novamente\n2- Voltar ao inicio\n3- Sair do App");
                    Console.WriteLine("=====================");
                    int index = int.Parse(Console.ReadLine());
                    Menu opçãoescolhida = (Menu)index;
                    Console.Clear();

                    switch (opçãoescolhida)
                    {
                        case Menu.Rolar:
                            Console.Clear();
                            dados.rolar();
                            menuzin();
                            break;
                        case Menu.Inicio:
                            inicio();
                            break;
                        case Menu.Sair:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }

                menuzin();

            }
        }
    }
}
