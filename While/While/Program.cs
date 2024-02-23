using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int contador = 0;
            int x = 12;
            int y = 13;

            Console.WriteLine(Math.Max(x, y));

            while (contador < 10)
            {
                Console.WriteLine(contador++);
                
                Console.WriteLine("FIM DA LINHA");
            }
    
            Console.ReadLine();

        }
    }
}
