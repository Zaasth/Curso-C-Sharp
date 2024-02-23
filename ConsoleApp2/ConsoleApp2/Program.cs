using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite o nome do produto");
            string n1 = Console.ReadLine();
            Console.WriteLine("Digite um valor");
            GerarPreço(float.Parse(Console.ReadLine()), n1);
            */

            /*float s1 = Somas(10, 20, 30);
            float s2 = Somas(15, 50, 30);
            float s3 = Somas(10, 650, 30);
            float s4 = Somas(320, 20, 30);
            float s5 = Somas(0, 0, 20);

            Console.WriteLine("O resultado é: " + s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            */

            bool t1 = false; bool t2 = false; bool t3 = true;

            bool l1 = Verificar(true, false);
            bool l2 = Verificar(true, true);
            bool l3 = Verificar(false, false);

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);

            Console.ReadLine();

        }

        static void GerarPreço(float preço, string nome)
        {
            float valorFinal = preço + (2 * preço);
            Console.WriteLine("O nome do produto é " + nome);
            Console.WriteLine("E o preço final é " + valorFinal);
        }

        static string Input1(string a, string b, string c)
        {
            //if (a == "Wellinton" || b == "Wellinton" || c == "Wellinton")
            {
                return a + " Você é um gostoso";
            }

        }
        static float Somas(float a, float b, float c)
        {
            float resultado = a * b + c / 2;
            return resultado;

        }

        static bool Verificar(bool a, bool b )
        {

            if ( a == true || b == true )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
