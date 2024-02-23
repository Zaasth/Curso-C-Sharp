using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp9
{
    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preço;
            public float peso;
            public string marca;

            public Produto(string nome, float preço, float peso, string marca)
            {
                this.nome = nome; //VARIAVEL DO ATRIBUTO =(RECEBE) VARIAVEL DO PARAMETRO
                this.preço = preço;
                this.peso = peso;
                this.marca = marca;
            }

            public void info()
            {
                Console.WriteLine($"Nome do protudo: {this.nome}");
                Console.WriteLine($"Preço do protudo: R${this.preço}");
                Console.WriteLine($"Peso do protudo: {this.peso}KG");
                Console.WriteLine($"Marca do protudo: {this.marca}");
            }

            public void desconto(float cup)
            {
                float res = this.preço * cup / 100.00f;
                Console.WriteLine(this.preço - res);
            }

        }
        struct Magias
        {
            public string nomedamagia;
            public string lvdamagia;
            public string escola;
            public string classes;
            public string conjuração;
            public string alcance;
            public string componentes;
            public string duração;
            public string efeito;

            public Magias(string nomedamagia, string lvdamagia, string escola, string classes, string conjuração, string alcance, string componentes, string duração, string efeito)
            {

                this.nomedamagia = nomedamagia;
                this.lvdamagia = lvdamagia;
                this.escola = escola;
                this.classes = classes;
                this.conjuração = conjuração;
                this.alcance = alcance;
                this.componentes = componentes;
                this.duração = duração;
                this.efeito = efeito;

            }


            public void Infos()
            {

                Console.WriteLine($"Nome da magia: {this.nomedamagia}");
                Console.WriteLine($"Lv da magia: {this.lvdamagia}");
                Console.WriteLine($"Escola da magia: {this.escola}");
                Console.WriteLine($"Classes: {this.classes}");
                Console.WriteLine($"Tempo de conjuração: {this.conjuração}");
                Console.WriteLine($"Alcance da magia: {this.alcance}");
                Console.WriteLine($"Componentes da magia: {this.componentes}");
                Console.WriteLine($"Duração da magia: {this.duração}");
                Console.WriteLine($"Efeito da magia: {this.efeito}");

            }

            public void Textos()
            {
                Console.Beep();

            }

        }
            static void Main(string[] args)
            {
                //Console.BackgroundColor = ConsoleColor.Gray;
                Console.Beep();
            var titulo = "Estudo Structs";
            Console.Title = titulo;
            Console.ForegroundColor = ConsoleColor.Yellow;
            var altura = 0;
            var largura = 0;
            //Console.SetWindowSize(altura, largura);


                //SEM USAR O CONSTRUTOR
                Produto bola = new Produto();
                bola.nome = "Bola de basquete";
                bola.preço = 10f;
                bola.peso = 1f;
                bola.marca = "Adidas";

                Console.WriteLine(bola.nome);

                //USANDO O CONSTRUTOR
                Produto Camisa = new Produto("Camisa de anime", 20f, 1f, "Nike");
                Console.WriteLine(Camisa.nome);

                bola.info();
                Console.WriteLine("=============");
                Camisa.info();
                Console.WriteLine("=============");
            Console.WriteLine("Digite um cupom válido");
            string index1 = Console.ReadLine();

            switch (index1)
            {
                case "NATAL50":
                    Console.WriteLine($"O seu cupom foi ativado, a {bola.nome} vai te custar apenas: ");
                    Console.Write("R$ "); bola.desconto(50.00f);
                    Camisa.desconto(50f);
                        break;
                    case "NATAL20":
                    bola.desconto(20f);
                    Camisa.desconto(20f);
                    break;
                default:
                    Console.WriteLine("Cumpom invalido");
                    bola.desconto(0f);
                    break;
            }


            Console.ReadLine();

            

                //ATAQUE CERTEIRO
                Magias AtaqueCerteiro = new Magias();
                AtaqueCerteiro.nomedamagia = "Ataque Certeiro";
                AtaqueCerteiro.escola = "Adivinhação";
                AtaqueCerteiro.lvdamagia = "Truque";
                AtaqueCerteiro.classes = "bardo, bruxo, feiticeiro, mago";
                AtaqueCerteiro.conjuração = "1 ação";
                AtaqueCerteiro.alcance = "9 metros";
                AtaqueCerteiro.componentes = "S";
                AtaqueCerteiro.duração = "concentração, até 1 rodadas";
                AtaqueCerteiro.efeito = "Efeito da magia:\n Você estende sua mão e aponta o dedo para um alvo no alcance. Sua magia garante a você uma breve\n intuição sobre as defesas do alvo. No seu próximo turno, você terá vantagem na primeira jogada de ataque contra o alvo, considerando que essa magia não tenha acabado.";

                //ESCUDO ARCANO
                Magias EscudoArcano = new Magias("Escudo Arcano", "Abjuração", "1°", "Feiticeiro, Mago", "1 reação", "Pessoal", "V S", "1 Rodada", "Uma barreira de energia invisível aparece e protege você. Até o início do seu próximo turno,\nvocê recebe +5 de bônus na CA, incluindo contra o ataque que desencadeou a magia, e você não sofre dano de mísseis mágicos.");

                //EscudoArcano.Infos();
                Console.WriteLine("================");
            //AtaqueCerteiro.Infos();




            //Console.WriteLine("Fala seu desejo mestre");
            //string index1 = Console.ReadLine();

            string index2;
            void texto()
            {
                Console.WriteLine("Digita o nome da magia pra obter mais informações");
                index2 = Console.ReadLine();

            }

            texto();

            /*
            var ativar = true;
            while (ativar)
            {

                switch (index2)
                {

                    case "Ataque certeiro":
                        Console.Clear();
                        Console.WriteLine(AtaqueCerteiro.nomedamagia);
                        Console.WriteLine(AtaqueCerteiro.lvdamagia);
                        Console.WriteLine(AtaqueCerteiro.classes);
                        Console.WriteLine(AtaqueCerteiro.conjuração);
                        Console.WriteLine(AtaqueCerteiro.alcance);
                        Console.WriteLine(AtaqueCerteiro.componentes);
                        Console.WriteLine(AtaqueCerteiro.duração);
                        Console.WriteLine(AtaqueCerteiro.efeito);
                        break;
                    case "Escudo arcano":
                        Console.Clear();
                        Console.WriteLine(EscudoArcano.nomedamagia);
                        Console.WriteLine(EscudoArcano.lvdamagia);
                        Console.WriteLine(EscudoArcano.classes);
                        Console.WriteLine(EscudoArcano.conjuração);
                        Console.WriteLine(EscudoArcano.alcance);
                        Console.WriteLine(EscudoArcano.componentes);
                        Console.WriteLine(EscudoArcano.duração);
                        Console.WriteLine(EscudoArcano.efeito);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("1- Sair\n2- Digitar outra magia");
                var escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        ativar = false;
                        break;
                        case "2":
                        Console.Clear();
                        texto();
                        break;
                    default:
                        break;
                }

            }
            */

            /*var EscudoArcano1 = $"Nome da magia: {EscudoArcano.nomedamagia}\nLv da magia:{EscudoArcano.lvdamagia}\nClasses conjuradoras: {EscudoArcano.classes}\nTempo de conjuração: {EscudoArcano.conjuração}\n";

            Console.WriteLine("Defina o nome para o seu arquivo:");
            var index3 = Console.ReadLine();

            Console.WriteLine("Defina o tipo do seu arquivo:");
            var index4 = Console.ReadLine();

            Console.WriteLine("Oq você quer escrever nesse arquivo?");
            var index5 = Console.ReadLine();

            StreamWriter Listademagias = File.AppendText($"{index3}.{index4}");
            Listademagias.WriteLine(index5);
            Listademagias.Close();
            Console.WriteLine("Arquivo gerado");
            Console.ReadLine() ;
            */

            StreamReader Leitor = new StreamReader("magias.txt");
            Leitor.ReadToEnd();


            Leitor.Close();


            Console.ReadLine();
            /*switch (checar)
                {
                    case true:
                        Console.Clear();
                        Console.WriteLine(AtaqueCerteiro.nomedamagia);
                        Console.WriteLine(AtaqueCerteiro.lvdamagia);
                        Console.WriteLine(AtaqueCerteiro.classes);
                        Console.WriteLine(AtaqueCerteiro.conjuração);
                        Console.WriteLine(AtaqueCerteiro.alcance);
                        Console.WriteLine(AtaqueCerteiro.componentes);
                        Console.WriteLine(AtaqueCerteiro.duração);
                        Console.WriteLine(AtaqueCerteiro.efeito);
                        break;
                }
            */

                
            }
        }
    }

