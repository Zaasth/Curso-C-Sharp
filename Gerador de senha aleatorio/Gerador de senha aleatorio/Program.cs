using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_senha_aleatorio
{
    enum Menu
    {
        Gerar =1, Configurar, SenhasSalvas, SalvarNovaSenha, Infos, Sair
    }

    enum Menu2
    {
        Comprimento = 1, Caracteres, Ambíguos, Numeros, caractersEspeciais, Letras
    }

    internal class Program
    {

        List<string> SenhaSalvas = new List<string>() 
        {

        };

        [STAThread]

        static void Main(string[] args)
        {
            
            Console.Title = "Gerador De Senhas";
            Senha GeradorSenha = new Senha();
            GeradorSenha.inicio();
        }




        static void configurar()
        {
            Console.WriteLine("Escolha o que configurar: ");
            Console.WriteLine("1- Comprimento Da Senha\n2- Seleção De Caracteres\n3- Exclusão de Caracteres Ambíguos");
            int index = int.Parse(Console.ReadLine());
            Menu2 opçãoEscolhida = (Menu2)index;

            switch (opçãoEscolhida)
            {
                case Menu2.Comprimento:
                    Console.WriteLine("Escolha o tamanho da senha");
                    Senha senha = new Senha();
                    senha.comprimento = int.Parse(Console.ReadLine());
                    break;
                case Menu2.Caracteres:
                    break;
                case Menu2.Ambíguos:
                    break;
                case Menu2.Numeros:
                    break;
                case Menu2.caractersEspeciais:
                    break;
                case Menu2.Letras:
                    break;
                default:
                    break;
            }



        }

    }
}
