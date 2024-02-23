using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace combos1
{
    internal class Program
    {
        //CÓDIGO RODANDO
        static void Main(string[] args)
        {
            string escolha;
            string lista = "Amigos\r\nAnimar Objetos\r\nArma espiritual\r\nChicote de espinhos\r\nDisfarce\r\nEncontrar familiar\r\nEspinhos\r\nGraxa\r\nHex\r\nManto do cruzado\r\nMetamorfose\r\nMuralha de energia\r\nNuvem enevoada\r\nPalavra de poder matar\r\nRaio ardente\r\nSopro do dragão  ";
            string nome;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            if (nome == "Wellinton" || nome == "wellinton")
            {
                Console.WriteLine("Olá mestre " + nome + " Seja bem vindo, sou Enma a sua auxiliar de combos.");
            }
            else if (nome != "Wellinton" || nome != "wellinton")
            {
                Console.WriteLine("Olá " + nome + " Seja bem vindo, sou Enma a sua auxiliar de combos.");
            }

            listagem();
            combos();


            Console.ReadLine();
            // FIM DO CÓDIGO RODANDO

            //FUNÇÃO LISTAGEM

            void listagem()
            {
                string input2;
                Console.WriteLine("Digite o comando /lista para ver a lista de magias disponívels para combo.");
                Console.WriteLine("-------------");
                input2 = Console.ReadLine();
                if (input2 == "/lista" || input2 == "/Lista")
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine(lista);
                    Console.WriteLine("-------------");
                    Console.WriteLine("Agora é só escolher uma dessas magias e digitar.");
                }
                else
                {
                    checar();
                }
            }
            //FUNÇÃO COMBOS

            void combos()
            {
                escolha = Console.ReadLine();
                if (escolha == "amigos" || escolha == "Amigos" || escolha == "disfarce" || escolha == "Disfarce")
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine("A magia 'amigos' comba com a magia 'disfarce', veja abaixo uma breve descrição:");
                    Console.WriteLine("-------------");
                    Console.WriteLine("Ativando a magia disfarce e depois usando amigos em alguém você pode\r\nenganar quem você quiser sem se preocupar em ser pego, pq a pessoa vai proucurar alguém\r\nque não existe por conta da magia 'disfarce'.");
                }
                else if (escolha == "animar objetos" || escolha == "Animar objetos" || escolha == "manto do cruzado" || escolha == "Manto do cruzado")
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine("A magia 'animar objetos' comba com a magia 'manto do cruzado', veja abaixo uma breve descrição:");
                    Console.WriteLine("-------------");
                    Console.WriteLine("Usando a magia animar objetos para animar o máximo de objetos minusculos possível você com manto do cruzado consegue fazer esses objetos pequenos causarem um dano adicionar por conta do manto do carrasco\r\npor que esses objetos também são considerados criaturas.");
                }
                else if (escolha == "Encontrar familiar" || escolha == "encontrar familiar" || escolha == "Sopro do dragão" || escolha == "sopro do dragão")
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine("A magia 'Econtrar' comba com a magia 'Sopro do dragão', veja abaixo uma breve descrição:");
                    Console.WriteLine("-------------");
                    Console.WriteLine("Usando a magia encontrar familiar fora de combate você invoca algum familiar que possua uma boca e durante\r\no combate você usa a magia sopro do dragão no familar, assim sei grupo vai ter um dano em área constante gastando só a ação do familiar.");
                }
                else
                {
                    checar2();
                }
            }
            //FUNÇÃO PRA CHECAR SE DIGITOU /LISTA
            void checar()
            {
                listagem();
            }
            //FUNÇÃO PARA CHECAR SE DIGITOU ALGO VALIDO NOS COMBOS
            void checar2()
            {
                Console.WriteLine("Essa magia não está disponível, tente outra");
                combos();
            }
        }
    }
}
