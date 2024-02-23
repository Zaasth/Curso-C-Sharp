using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Jogo
    {
        //ATRIBUTOS
        public string nome;
        List<string> generos = new List<string>()
        {

        };
        public float preço;
        public int faixaEtaria;
        public int estoque;

        //METODOS

        public void inicia()
        {
            Console.WriteLine($"{nome} iniciando");
        }

        public void fechar()
        {
            Console.WriteLine($"{nome} fechando.");
        }

        public void gameplay()
        {
            Console.WriteLine($"{nome} rodando");
        }

        public void excluir()
        {
            Console.WriteLine($"{nome} Exluido");
        }

    }
}
