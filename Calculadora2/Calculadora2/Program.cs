// See https://aka.ms/new-console-template for more information

Calculadora();



static void Calculadora()
{

    bool Escolheusair = false;
    while (!Escolheusair) // Pode se ler como "Enquanto não escolher Sair, repita isto
    {
        Console.WriteLine("Seja bem vindo a calculadora, selecione uma das opções:");
        Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raíz Quadrada\n7-Sair");

        Menu OpçãoEscolhida = (Menu)int.Parse(Console.ReadLine());




        switch (OpçãoEscolhida)
        {
            case Menu.Soma:
                Console.Clear();
                Soma();
                break;
            case Menu.Subtração:
                Console.Clear();
                Subtração();
                break;
            case Menu.Divisão:
                Console.Clear();
                Divisão();
                break;
            case Menu.Multiplicação:
                Console.Clear();
                Multiplicação();
                break;
            case Menu.Potência:
                Console.Clear();
                Potencia();
                break;
            case Menu.Raíz:
                Console.Clear();
                Raiz();
                break;
            case Menu.Sair:
                Escolheusair = true;
                break;
            default:
                Console.Clear();
                break;
        }
        Console.Clear();
    }

}



static void Soma()
{
    Console.WriteLine("Soma de dois números:");
    Console.WriteLine("Digite o primeiro número");
    float index1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número:");
    float index2= float.Parse(Console.ReadLine());
    float res = index1 + index2;
    Console.WriteLine("=============");
    Console.WriteLine($"O resultado final é: {res}");
    Console.WriteLine("=============");
    Console.WriteLine("Pressione enter para voltar ao menu.");
    Console.ReadLine();
}

static void Subtração()
{
    Console.WriteLine("Subtração de dois números:");
    Console.WriteLine("Digite o primeiro número");
    float index1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número:");
    float index2 = float.Parse(Console.ReadLine());
    float res = index1 - index2;
    Console.WriteLine("=============");
    Console.WriteLine($"O resultado final é: {res}");
    Console.WriteLine("=============");
    Console.WriteLine("Pressione enter para voltar ao menu.");
    Console.ReadLine();
}

static void Divisão()
{
    Console.WriteLine("Divisão de dois números:");
    Console.WriteLine("Digite o primeiro número");
    float index1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número:");
    float index2 = float.Parse(Console.ReadLine());
    float res = index1 / index2;
    Console.WriteLine("=============");
    Console.WriteLine($"O resultado final é: {res}");
    Console.WriteLine("=============");
    Console.WriteLine("Pressione enter para voltar ao menu.");
    Console.ReadLine();
}

static void Multiplicação()
{
    Console.WriteLine("Multiplicação de dois números:");
    Console.WriteLine("Digite o primeiro número");
    float index1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número:");
    float index2 = float.Parse(Console.ReadLine());
    float res = index1 * index2;
    Console.WriteLine("=============");
    Console.WriteLine($"O resultado final é: {res}");
    Console.WriteLine("=============");
    Console.WriteLine("Pressione enter para voltar ao menu.");
    Console.ReadLine();
}

static void Potencia()
{
    Console.WriteLine("Potência de um número:");
    Console.WriteLine("Digite a base:");
    float index1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o expoente:");
    float index2 = float.Parse(Console.ReadLine());
    double res = Math.Pow(index1, index2);
    Console.WriteLine("=============");
    Console.WriteLine($"O resultado final de {index1} elevado a {index2} é: {res}");
    Console.WriteLine("=============");
    Console.WriteLine("Pressione enter para voltar ao menu.");
    Console.ReadLine();
}

static void Raiz()
{
        Console.WriteLine("Raíz quadrada de um número:");
        Console.WriteLine("Digite o número:");
        float index1 = float.Parse(Console.ReadLine());
        double res = Math.Sqrt(index1);
        Console.WriteLine("=============");
        Console.WriteLine($"A raíz quadrada de {index1} é: {res}");
        Console.WriteLine("=============");
        Console.WriteLine("Pressione enter para voltar ao menu.");
        Console.ReadLine();
}



enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potência, Raíz, Sair }

