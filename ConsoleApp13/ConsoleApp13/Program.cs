using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            Filme Vingadores = new Filme();
            Vingadores.nome = "Vingadores A Era De Ultron";
            Vingadores.genero = "Super herói, aventura, ação";
            Vingadores.atores = new List<string>()
            {
                "Tony Stark", "Hulk", "Thor"
            };

            Console.WriteLine($"Nome do filme: {Vingadores.nome}");
            Console.WriteLine($"Atores do filme: {Vingadores.atores[0]}");
            Vingadores.Avançar();
            Vingadores.Pausar();

            foreach (var atr in Vingadores.atores)
            {
                Console.WriteLine(atr);
            }

            Console.WriteLine("Qual informação de filme você deseja acessar?");
            Filme Vingadores2 = new Filme();
            Vingadores2.Magia = "Espirro ácido";
            Console.WriteLine(Vingadores2.Magia);
            Console.WriteLine("===============");

            Produto celular1 = new Produto();
            celular1.nome = "Iphone 12";
            celular1.camera = 4;
            celular1.marca = "Apple";

            celular1.Ligar();



            Console.ReadLine();

            
        }

    }
}

class Jogo
{
    //ATRIBUTOS

    public string nome;
    public string genero;
    public string produtora;
    public string preço;

    //METODOS

    public void Abrir()
    {
        Console.WriteLine("Abrir.");
    }

    public void Carregar()
    {
        Console.WriteLine("Carregando...");
    }

    public void Fechar()
    {
        Console.WriteLine("Fechar.");
    }
   
    

}