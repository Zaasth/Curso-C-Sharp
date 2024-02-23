using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> Nomes = new List<string>();
            {
                Nomes.Add("Rogerio");
                Nomes.Add("Cleiton");
                Nomes.Add("Matheus");
                Nomes.Add("Wellinton");
                Nomes.Add("Ednaldo Pereira");
            }
            Nomes.RemoveAt(0); // Remove um elemento pelo indice
            Nomes.RemoveAll(NomeDeletado => NomeDeletado == "Wellinton"); //Vai remover da listas todos os elementos que correspondem a um predicado.
           
            
            string busca = Nomes.Find(achar => achar.Length > 9); //Buscar dentro da lista Nomes um nome que tenha mais de 9 letras e armazena esse dado na variavel
            List<string> Filtrada = Nomes.FindAll(achar => achar.Length < 9); //Retorna multiplos resultados e te retorna uma nova lista filtrada com os elementos encontrados

            Console.WriteLine(busca);
            foreach (var filtros in Filtrada)
            {
                Console.WriteLine(filtros);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep();
            //Console.WriteLine("Digite um numero");
            //int index = int.Parse(Console.ReadLine());

            //Nomes[0] = "Bolsonaro";
            //Console.WriteLine(Nomes[index]);


            foreach (var nome in Nomes) //PRA CADA NOME DENTRO DA LISTA DE NOMES FAÇA ESSA LINHA DE CÓDIGO
            {
                Console.WriteLine(nome);
            }


            Console.ReadLine();
        }
    }
}
