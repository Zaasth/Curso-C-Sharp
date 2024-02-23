// See https://aka.ms/new-console-template for more information

var checar = false;
var test1 = true;
while (!checar)
{
    Console.WriteLine("teste");

	switch (test1)
	{
		case true:
			Console.WriteLine("Fim da linha");
			checar = true;
			break;
		default:
			break;
	}
}
enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potência, Raíz, Sair } 