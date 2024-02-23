using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        enum nomes { Wellinton, Matheus, João, Carlos, Thais, Ana }

        static void Main(string[] args)
        {
            string[] magias = { "Amigos", "Animar Objetos", "Arma Espiritual", "Chicote de Espinhos", "Disfarce", "Encontrar Familiar", "Espinhos", "Graxa", "Hex", "Manto do Cruzado", "Metamorfose", "Muralha de Energia", "Nuvem Enevoada", "Palavra de Poder Matar", "Raio Ardente", "Sopro do Dragão" };

            //Console.WriteLine("Digite o nome da magia");
            //string input1 = Console.ReadLine();
            //Console.WriteLine(magias);

            nomes pessoas = nomes.Wellinton;

            Console.WriteLine(pessoas);
            Console.WriteLine((nomes)2);
            Console.WriteLine((int)pessoas);


            /*switch (input1)
            {

                case "Amigos":
                    Console.WriteLine("A magia amigos é top");
                    break;
                case "Arma Espiritual":
                    Console.WriteLine("A magia Arma Esperitual é daorinha");
                    break;


            }
            */
            Console.ReadLine();
        }
    }
}
