using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Produto
    {
        //ATRIBUTOS
        public string tamanho;
        public string marca;
        public int camera;
        public string resolução;
        public string nome;
        public int estoque;


        //METODOS

        public void Ligar()
        {
            Console.WriteLine($"{nome} Ligando.");
        }

        public void Deligar()
        {
            Console.WriteLine($"{nome} Desligando.");
        }

        public void Reiniciar()
        {
            Console.WriteLine($"{nome} Reiniciando.");

        }

        public void Som()
        {
            Console.WriteLine($"{nome} Reproduzindo som.");
        }

        public void Chamada()
        {
            Console.WriteLine($"{nome} Recebendo chamada.");
        }

    }
}
