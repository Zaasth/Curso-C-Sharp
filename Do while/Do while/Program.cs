using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] magias = { "Amigos", "Animar Objetos", "Arma Espiritual", "Chicote de Espinhos", "Disfarce", "Encontrar Familiar", "Espinhos", "Graxa", "Hex", "Manto do Cruzado", "Metamorfose", "Muralha de Energia", "Nuvem Enevoada", "Palavra de Poder Matar", "Raio Ardente", "Sopro do Dragão"};

            Console.WriteLine("Olá mestre, digite o nome da magia a ser combada");
            string input1 = Console.ReadLine();


            if (input1 == "/lista" || input1 == "/Lista")
            {
                foreach (string mag in magias)
                {
                    Console.WriteLine(mag);
                    /*switch (input1)
                    {

                        case "Amigos":
                            Console.WriteLine("Amigos é gay");
                            break;
                        default:
                            Console.WriteLine(mag);
                            break;
                    }
                    */
                }
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Agora digite a magia");
            string input2 = Console.ReadLine();
            if (input2 == "Amigos")
            {
                while (input2 == "Amigos")
                {
                    Console.WriteLine("Continua infinito");
                }
            }

            Console.ReadLine();
        }
    }
}
