using System;
using System.Windows.

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Console.WriteLine("Escreva qualquer coisa, será copiada para a área de transferência");

            var something = Console.ReadLine();

            Clipboard.SetText(something);

            Console.Read();
        }
    }
}