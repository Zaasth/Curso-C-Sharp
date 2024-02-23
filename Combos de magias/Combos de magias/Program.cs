using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combos_de_magias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lista = "Amigos\r\nAnimar Objetos\r\nArma espiritual\r\nChicote de espinhos\r\nDisfarce\r\nEncontrar familiar\r\nEspinhos\r\nGraxa\r\nHex\r\nManto do cruzado\r\nMetamorfose\r\nMuralha de energia\r\nNuvem enevoada\r\nPalavra de poder matar\r\nRaio ardente\r\nSopro do dragão  ";
            string nome;
            string magia;


            Console.WriteLine("Me diga seu nome.");
            nome = Console.ReadLine();
            /*if (nome == "Wellinton" || nome == "wellinton")
            {
                Console.WriteLine("Bem vindo mestre " + nome + " ao ajudante de combos, digite um dos comando abaixo para que eu possa te ajudar :)");
                Console.WriteLine("---------------");
                Console.WriteLine("/lista (Vai te dar uma lista das magias disponíveis para combo");
                Console.WriteLine("---------------");
                string lista2 = Console.ReadLine();
            }
            */

                Console.WriteLine("Bem vindo mestre " + nome + " ao ajudante de combos, digite um dos comando abaixo para que eu possa te ajudar :)");
                Console.WriteLine("---------------");
                Console.WriteLine("/lista (Vai te dar uma lista das magias disponíveis para combo");
                Console.WriteLine("---------------");
                string lista1 = Console.ReadLine();
            

            if (lista1 == "/lista" || lista1 == "/Lista")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Essa é a lista de magias disponíveis:");
                Console.WriteLine(lista);
                Console.WriteLine("---------------");
                Console.WriteLine("Agora digite uma magia disponível que te informarei algum combo dela :D");
                
            }
            else
            {
                Console.WriteLine("Não reconheço esse comando.");
            }

            magia = Console.ReadLine();
            Console.WriteLine("---------------");

            if (magia == "Amigos" || magia == "amigos")
            {
                Console.WriteLine("A magia amigos comba com a magia 'disfarce'");
                Console.WriteLine("Descrição sobre o combo:");
                Console.WriteLine("Com amigos combinado com disfarce você pode sair pelas ruas do seu rpg enganando a todos\r\ne no final da duração da magia 'amigos' eles vão ficar proucurando uma pessoa que não existe.");
            }
            if (magia == "Disfarce" || magia == "disfarce")
            {
                Console.WriteLine("A magia disfarce comba com a magia 'amigos'");
                Console.WriteLine("Descrição sobre o combo:");
                Console.WriteLine("Com amigos combinado com disfarce você pode sair pelas ruas do seu rpg enganando a todos\r\ne no final da duração da magia 'amigos' eles vão ficar proucurando uma pessoa que não existe.");
            }
            else
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Essa magia não é válida");
            }








            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
