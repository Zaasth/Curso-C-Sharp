using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero = "124";
            string numero2 = "20";
            int b = int.Parse(numero);
            int c = int.Parse(numero2 + 2);
            int res = b + c;
            Random aleatorio = new Random();
            int valor = aleatorio.Next(1, 10);
            string nome;

            int d20 = aleatorio.Next(1, 20);
            int bonus = 0;
            int resd20 = d20 + bonus;
            //string magias = "Hex", d = "Banimento", a = "amigos";
            Console.WriteLine(valor);
            Console.WriteLine("Hello World!");
            Console.WriteLine(res);
            Console.WriteLine("Meu nome é Wellinton");
            Console.WriteLine("------------");
            Console.WriteLine("O número rolado no 1d20 é: " + resd20);
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            //Console.WriteLine("Então " + nome + " é o seu nome, que nome lindo :D");
            if (nome == "wellinton" || nome == "Wellinton")
            {
                Console.WriteLine("Que nome bonito :D");
            }
            else
            {
                Console.WriteLine("Que nome feio >:(");
            }



            Console.ReadLine();
          
        }
    }
}
