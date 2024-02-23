using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{

    enum opcao { Criar = 1, Deletar, Listar, Editar, Sair}

    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Lista\n4-Editar\n5-Sair");
            Console.WriteLine("----------------");
            int index = int.Parse(Console.ReadLine());
            opcao opacaoselecionada = (opcao)index;
            //Console.WriteLine(opacaoselecionada);

            escolhas();





            Console.ReadLine();

            void escolhas()
            {
                switch (opacaoselecionada)
                {
                    case opcao.Criar:

                        break;
                    case opcao.Deletar:
                        break;
                    case opcao.Listar:
                        Console.WriteLine("----------------");
                        Console.WriteLine("Essas são as listas de magias disponíves:");
                        Console.WriteLine("Amigos\r\nAnimar Objetos\r\nArma espiritual\r\nChicote de espinhos\r\nDisfarce\r\nEncontrar familiar\r\nEspinhos\r\nGraxa\r\nHex\r\nManto do cruzado\r\nMetamorfose\r\nMuralha de energia\r\nNuvem enevoada\r\nPalavra de poder matar\r\nRaio ardente\r\nSopro do dragão");
                        break;
                    case opcao.Editar:
                        break;
                    case opcao.Sair:
                        break;
                    default:
                        Console.WriteLine("Essa não é uma opção válida");
                        Console.WriteLine("Digite uma nova opção");
                        int opcao2 = int.Parse(Console.ReadLine());
                        opacaoselecionada = (opcao)opcao2;
                        escolhas();
                        break;
                }
            }

        }
    }
}
