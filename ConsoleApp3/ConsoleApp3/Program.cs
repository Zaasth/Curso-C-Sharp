using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] magias = new string[5]
            {
                "Amigos", "Animar Objetos", "Arma Espiritual", "Chicote de Espinhos", "Disfarce"
            };

            string[] magias2 =
            {
                "Amigos", "Animar Objetos", "Arma Espiritual", "Chicote de Espinhos", "Disfarce", "Encontrar Familiar", "Espinhos", "Graxa", "Hex", "Manto do Cruzado", "Metamorfose", "Muralha de Energia", "Nuvem Enevoada", "Palavra de Poder Matar", "Raio Ardente", "Sopro do Dragão", "Cuzinho"
            };

            magias[0] = "Amigos gay";
            Console.WriteLine(magias2[16]);

            if (magias[2] == "Animar Objetos")
            {
                Console.WriteLine("Tá certo");
            }
            else
            {
                Console.WriteLine("Tá errado");
            }

            Console.ReadLine();
        }
    }
}
