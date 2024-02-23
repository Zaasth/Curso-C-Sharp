using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_senha_aleatorio
{
    enum MenuConfig
    {
        Comprimento =1 ,Especiais, Voltar, Sair
    }

    internal class Senha
    {

        public int comprimento = 10; //Padrão
        public int letras = 1; //1 = Maiuscula, 2 = Minuscula, 3 = As Duas 
        public bool numerosescolha = true; //True = Tem numeros, false = não tem
        public bool caractersEspeciais = true; //Mesma coisa da de cima

        string[] especiais1 = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", ":", ";", "'", "<", ">", ",", ".", "?", "/", "~", "`" };
        string[] alfabeto = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "ç"};
        string[] alfabetomaisculo = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Ç" };
        string[] Caracterspermitidos = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", ":", ";", "'", "<", ">", ",", ".", "?", "/", "~", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "ç", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Ç", "1", "2", "3", "4", "5", "6","7","8","9" };
        string[] SóMaisuculos = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", ":", ";", "'", "<", ">", ",", ".", "?", "/", "~", "`", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Ç", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        List<string> senhacopiar = new List<string>()
        {

        };
       
        public void inicio()
        {
            Senha GeradorSenha = new Senha();

            Console.WriteLine("Bem vindo ao gerador de senhas, selecione uma das opções:");
            Console.WriteLine("1- Gerar Senha\n2- Configurar Geração De Senhas\n3- Senhas Salvas\n4- Salvar Nova Senha\n5- Informações\n6- Sair do app");
            int index1 = int.Parse(Console.ReadLine());
            Menu opçãoescolhida = (Menu)index1;

            switch (opçãoescolhida)
            {
                case Menu.Gerar:
                    Console.Clear();
                    GerarSenha();
                    break;
                case Menu.Configurar:
                    Console.Clear();
                    Configurar();
                    break;
                case Menu.SenhasSalvas:
                    break;
                case Menu.SalvarNovaSenha:
                    break;
                case Menu.Infos:
                    break;
                case Menu.Sair:
                    break;
                default:
                    break;
            }

            void Configurar()
            {
                Console.WriteLine("1- Tamanho Da Senha\n2- Caracters Especiais\n3- Voltar\n4- Sair");
                int index = int.Parse(Console.ReadLine());
                MenuConfig opçãoescolhida1 = (MenuConfig)index;

                switch (opçãoescolhida1)
                {
                    case MenuConfig.Comprimento:
                        Console.Clear();
                        Console.WriteLine("Defina o tamanho da senha:");
                        GeradorSenha.comprimento = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tamanho configurado, aperte enter para gerar a senha.");
                        Console.ReadLine();
                        Console.Clear() ;
                        GerarSenha();
                        break;
                    case MenuConfig.Especiais:
                        Console.Clear();
                        Console.WriteLine("Deseja que a senha tenha caracters especiais?");
                        Console.WriteLine("1- Sim\n2- Não");
                        string escolhido = Console.ReadLine();

                        switch (escolhido)
                        {
                            case "1":
                                GeradorSenha.caractersEspeciais = true;
                                Console.WriteLine("Caracters configurada, aperte enter para voltar.");
                                Console.ReadLine();
                                Configurar();
                                break;
                            case "2":
                                GeradorSenha.caractersEspeciais = false;
                                Console.WriteLine("Caracters configurada, aperte enter para voltar.");
                                Console.ReadLine();
                                Configurar();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Opção inválida, aperte enter para voltar");
                                Console.ReadLine();
                                Configurar();
                                break;
                        }

                        break;
                    case MenuConfig.Voltar:
                        Console.Clear();
                        inicio();
                        break;
                    case MenuConfig.Sair:
                        break;
                    default:
                        break;
                }


            }

            void GerarSenha()
            {


                Random especiais = new Random();
                Random Geraralfabeto = new Random();
                Random GerarAlfabetoMaisculo = new Random();
                Random numeros = new Random();
                Random numeros2 = new Random();

                Random permitidos = new Random();

                Console.WriteLine("Senha gerada:");
                Console.WriteLine("===========================");



                if (letras == 3 && numerosescolha == true && caractersEspeciais == true)
                {
                    for (int i90 = 0; i90 < GeradorSenha.comprimento; i90++)
                    {
                        
                        var oi = Caracterspermitidos[permitidos.Next(0, 90)];
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(oi.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                        Clipboard.SetText(oi.ToString());
                    }
                }
                else if (letras == 1 && numerosescolha == true && caractersEspeciais == true)
                {
                    for (int i91 = 0; i91 < GeradorSenha.comprimento; i91++)
                    {

                        string oi1 = SóMaisuculos[permitidos.Next(0, 63)];
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(oi1.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                        senhacopiar.Add(oi1);

                    }

                }
                else if (letras == 2 && numerosescolha == true && caractersEspeciais == true)
                {

                }


                Console.WriteLine("");
                Console.WriteLine("===========================");
                Console.WriteLine("1- Menu Inicial\n2- Salvar Senha\n3- Sair");
                Console.ReadLine();
                foreach (var item in senhacopiar)
                {
                    Console.Write(item);
                    
                }
                int index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        Console.Clear();
                        inicio();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            }



       

            
            

        }
    }

   
}
