using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Gestor_de_clientes
{
    internal class Program
    {
        
        struct Clientes
        {
            public string Nome;
            public string email;
            public string cpf;
        }

        enum Dados
        {
            Nome =1, Cpf, Email, Todos
        }

        enum Menu
        {
            Listagem =1, Adicionar, Remover, Sair
        }

        static void Main(string[] args)
        {
            //TITULO DO CONSOLE E COR DAS LETRAS
            Console.Title = "Gestão de clientes";
            Console.ForegroundColor = ConsoleColor.Yellow;

            //FUNÇÃO QUE DA INICIO AO APP
            inicio();

            //FUNÇÃO COM O INICIO DO APP
            void inicio()
            {
               
                Console.WriteLine("Selecione uma das opções:");
                Console.WriteLine("1- Listagem\n2- Adicionar\n3- Remover\n4- Sair Do App");

     
                int index = int.Parse(Console.ReadLine());
                Menu opçãoselecionada = (Menu)index;

              

                if (index == 1 || index == 2 || index == 3 || index == 4)
                {

                    switch (opçãoselecionada)
                    {
                        case Menu.Listagem:
                            Console.Clear();
                            LerArquivo();
                            break;
                        case Menu.Adicionar:
                            Console.Clear();
                            Adicionar();
                            break;
                        case Menu.Remover:
                            Console.Clear();
                            Remover();
                            break;
                        case Menu.Sair:
                            Environment.Exit(0);
                            break;
                        default:
                           
                            break;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(500);
                    Console.Clear();
                    inicio() ;
                }
            }

            //FUNÇÃO COM A FEATURE PARA ADICIONAR DADOS NO ARQUIVO.
            void Adicionar()
            {

              
                        Console.WriteLine("Digite o nome de um novo cliente");
                        Clientes c2 = new Clientes();
                        c2.Nome = Console.ReadLine();
                        StreamWriter addInfos = File.AppendText($"nome.txt");
                        addInfos.WriteLine("Nome do cliente: " + c2.Nome);
                        addInfos.Close();
                        

                        StreamWriter addInfos2 = File.AppendText($"cpf.txt");
                        Console.WriteLine("Agora adicione o Cpf do cliente");
                        c2.cpf = Console.ReadLine();
                        addInfos2.WriteLine($"Cpf do cliente [{c2.Nome}]: " + c2.cpf);
                        addInfos2.Close();

                        StreamWriter addInfos3 = File.AppendText($"email.txt");
                        Console.WriteLine("Agora adicione o email do cliente");
                        c2.email = Console.ReadLine();
                        addInfos3.WriteLine($"Email do cliente [{c2.Nome}]: " + c2.email);
                        addInfos3.Close();

                        Console.WriteLine("===========================");
                        Console.WriteLine("Informações adicionadas com sucesso, pressione enter para voltar ao menu.");
                        Console.ReadLine() ;
                        Console.Clear() ;
                        inicio();


            }

            //FUNÇÃO COM A FEATURE PARA LER OS DADOS DO ARQUIVO.
            void LerArquivo()
            {
                Console.WriteLine("Escolha qual dos dados você quer a informação:");
                Console.WriteLine("1- Nome\n2- Cpf\n3- Email\n4- Todos");
                int index1 = int.Parse(Console.ReadLine());
                Dados dados = (Dados)index1;

                if (index1 == 1 || index1 == 2 || index1 == 3 || index1 == 4)
                {

                    switch (dados)
                    {
                        case Dados.Nome:
                            Console.Clear();
                            StreamReader ler = new StreamReader("nome.txt");
                            var leitura = ler.ReadToEnd();
                            ler.Close();
                            Console.WriteLine(leitura);


                            Console.WriteLine("===========================");
                            Console.WriteLine("Todos os nomes foram apresentados, para voltar ao menu aperte enter.");
                            Console.ReadLine();
                            Console.Clear();
                            inicio();
                            break;
                        case Dados.Cpf:

                            Console.Clear();
                            StreamReader ler1 = new StreamReader("cpf.txt");
                            var leitura1 = ler1.ReadToEnd();
                            ler1.Close();
                            Console.WriteLine(leitura1);


                            Console.WriteLine("===========================");
                            Console.WriteLine("Todos os cpfs foram apresentados, para voltar ao menu aperte enter.");
                            Console.ReadLine();
                            Console.Clear();
                            inicio();

                            break;
                        case Dados.Email:

                            Console.Clear();
                            StreamReader ler3 = new StreamReader("email.txt");
                            var leitura3 = ler3.ReadToEnd();
                            ler3.Close();
                            Console.WriteLine(leitura3);


                            Console.WriteLine("===========================");
                            Console.WriteLine("Todos os emails foram apresentados, para voltar ao menu aperte enter.");
                            Console.ReadLine();
                            Console.Clear();
                            inicio();

                            break;
                        case Dados.Todos:

                            StreamReader lerall = new StreamReader("nome.txt");
                            var leituraall = lerall.ReadToEnd();
                            lerall.Close();
                            Console.WriteLine(leituraall);


                            Console.WriteLine("===========================");

                            Console.WriteLine("");
                            StreamReader lerall1 = new StreamReader("cpf.txt");
                            var leituraall1 = lerall1.ReadToEnd();
                            lerall1.Close();
                            Console.WriteLine(leituraall1);


                            Console.WriteLine("===========================");

                            Console.WriteLine("");
                            StreamReader lerall3 = new StreamReader("email.txt");
                            var leituraall3 = lerall3.ReadToEnd();
                            lerall3.Close();
                            Console.WriteLine(leituraall3);


                            Console.WriteLine("===========================");
                            Console.WriteLine("Todos os dados foram apresentados, para voltar ao menu aperte enter.");
                            Console.ReadLine();
                            Console.Clear();
                            inicio();

                            break;
                        default:
                            break;
                    }

                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(500);
                    Console.Clear();
                    LerArquivo();

                }
                

            }
            void Remover()
            {
                Console.WriteLine("Qual arquivo você deseja remover o conteudo dele por inteiro?");
                Console.WriteLine("1- Nomes dos clientes\n2- Cpf dos clienstes\n3- Email dos clientes");
                int index1 = int.Parse(Console.ReadLine());

                if (index1 == 1 || index1 == 2 || index1 == 3 )
                {

                    switch (index1)
                    {
                        case 1:
                            Console.Clear();
                            StreamWriter apagarNome = new StreamWriter("nome.txt");
                            apagarNome.WriteLine("");
                            apagarNome.Close();

                            Console.WriteLine("Contéudos do arquivo deletado com sucesso, aperte enter para voltar ao Menu.");
                            Console.ReadLine();
                            Console.Clear();
                            inicio();
                            break;
                        case 2:
                            Console.Clear();
                            StreamWriter apagarCpf = new StreamWriter("cpf.txt");
                            apagarCpf.WriteLine("");
                            apagarCpf.Close();

                            Console.WriteLine("Contéudos do Arquivo deletado com sucesso, aperte enter para voltar ao Menu.");
                            Console.ReadLine();
                            Console.Clear();
                            inicio();
                            break;

                        case 3:
                            Console.Clear();
                            StreamWriter apagarEmail = new StreamWriter("email.txt");
                            apagarEmail.WriteLine("");
                            apagarEmail.Close();

                            Console.WriteLine("Contéudos do Arquivo deletado com sucesso, aperte enter para voltar ao Menu.");
                            Console.ReadLine();
                            Console.Clear();
                            inicio();
                            break;
                        default:
                            break;
                    }
                    

                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(500);
                    Console.Clear();
                    Remover();

                }

                
               

            }
        }
    }
}
