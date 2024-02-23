using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_De_Clientes2
{
    internal class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string cpf;
            public string email;

        }

        static List<Cliente> clientes = new List<Cliente>();

        enum Menu
        {
            Listagem =1, Adicionar, Remover, Sair
        }

        static void Main(string[] args)
        {
            carregar();
            Inicio();

        }


        static void Inicio()
        {

            Console.WriteLine("Sistema de clientes - Bem vindo!");
            Console.WriteLine("1- Listagem\n2- Adicionar\n3- Remover\n4- Sair");
            int index = int.Parse(Console.ReadLine());
            Menu opçãoEscolhida = (Menu)index;



            switch (opçãoEscolhida)
            {
                case Menu.Listagem:
                    Listagem();
                    break;
                case Menu.Adicionar:
                    Console.Clear();
                    adicionar();
                    break;
                case Menu.Remover:
                    break;
                case Menu.Sair:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            

        }

        static void adicionar()
        {

            Cliente cliente1 = new Cliente();
            Console.WriteLine($"Cadastro do cliente: ");
            Console.WriteLine("Nome do cliente");
            cliente1.nome  = Console.ReadLine();
            Console.WriteLine("Email do cliente: ");
            cliente1.email = Console.ReadLine();
            Console.WriteLine("Cpf do cliente: ");
            cliente1.cpf = Console.ReadLine();

            clientes.Add(cliente1);
            salvar();

            Console.WriteLine("Cadastro concluído, aperte enter para sair.");
            Console.ReadLine() ;
          

        }

        static void Listagem()
        {

            if (clientes.Count > 0)
            {


                Console.WriteLine("Lista de clientes: ");

                int i = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome do cliente: {cliente.nome}");
                    Console.WriteLine($"Cpf do cliente: {cliente.cpf}");
                    Console.WriteLine($"Email co cliente: {cliente.email}");
                    Console.WriteLine("==========================");
                    Console.ReadLine();
                    i++;
                }
                Console.WriteLine("Aperte enter para sair: ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                Console.ReadLine();
            }
        }

        static void salvar()
        {

            FileStream salvar = new FileStream("clients.dat",FileMode.OpenOrCreate);
            BinaryFormatter enconder = new BinaryFormatter();   

            enconder.Serialize(salvar, clientes);
            salvar.Close();

        }

        static void carregar()
        {

            FileStream salvar = new FileStream("clients.dat", FileMode.OpenOrCreate);
            try
            {

                
                BinaryFormatter enconder = new BinaryFormatter();

                clientes = (List<Cliente>)enconder.Deserialize(salvar);
                

                if (clientes == null)
                {
                    clientes = new List<Cliente>();
                }


            }
            catch (Exception)
            {
                clientes = new List<Cliente>();
               
            }

            salvar.Close();


        }

    }
}
