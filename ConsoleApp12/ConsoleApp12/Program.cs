using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Viado";

            List<string> coisas = new List<string>();
            coisas.Add("Alguma coisa1");
            coisas.Add("Alguma coisa2");
            coisas.Add("Alguma coisa3");
            coisas.Add("Alguma coisa4");
            coisas.Add("Alguma coisa5");
            coisas.Add("Alguma coisa6");
            coisas.Add("Alguma coisa7");
            coisas.Add("Alguma coisa");
            coisas.Add("Alguma coisa");
            coisas.Add("Alguma coisa");
            coisas.Add("Alguma coisa");
            coisas.Add("Alguma coisa");


            Console.WriteLine("Digite a string que deseja transformar em binario:");
            string index1 = Console.ReadLine();

            FileStream lista = new FileStream("Listas.algumacoisa", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter encoder2 = new BinaryFormatter();

            encoder2.Serialize(lista, coisas);

            lista.Close();


            FileStream Binario = new FileStream("Rogerio.Qualquercoisa", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();


            encoder.Serialize(Binario, true);
            encoder.Serialize(Binario, 123.4f);
            encoder.Serialize(Binario, 76);
            encoder.Serialize(Binario, "Pedrinho");
            encoder.Serialize(Binario, index1);

            Binario.Close();










            /*StreamReader Leitor = new StreamReader("Cleiton.txt");
            //string conteudo = Leitor.ReadToEnd();
            //Console.WriteLine(conteudo);

            //string conteudo = Leitor.ReadLine();
            //Console.WriteLine(conteudo);

            string texto = "";

            while (texto != null)
            {

                texto = Leitor.ReadLine();
                if (texto != null)
                {
                    Console.WriteLine($"Esse foi o texto copiado: {texto}");
                }
                

                switch (texto)
                {
                    case "Só tem viado aqui":
                        StreamWriter adicioanr = File.AppendText("Teste.txt");
                        adicioanr.WriteLine("Tu que é gay");

                        adicioanr.Close();
                        break;

                    default:
                        break;
                }

                
            }
            */

            Console.ReadLine();


        }
    }
}
