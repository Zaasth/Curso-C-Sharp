using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {

        float contador = 0.1f;
        
        static void Main(string[] args)
        {

            contar();



            Console.ReadLine();
        }

        static void contar()
        {
            for (float i = 0; i < 1000000; i += 1)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("FIM DA LINHA");
        }
    }
}
