using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Filme
    {
        public string nome;
        public string genero;
        public string ano;
        public string sinopse;
        public string diretor;
        public string duração;
        public List<string> atores = new List<string>
        {


        };

        public string Magia = "Escudo arcano";

        public void Reproduzir()
        {
            Console.WriteLine($"Reproduzindo o filme: {nome} ");
        }

        public void Pausar()
        {
            Console.WriteLine("| |");
        }

        public void Avançar()
        {
            Console.WriteLine($"Avançando 10 segundos do filme: {nome}");
        }

        public void Fechar()
        {
            Console.WriteLine("Sair.");
        }

    }
}
