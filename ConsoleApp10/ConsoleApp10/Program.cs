internal class Program
{
    private static void Main(string[] args)
    {
        Random res = new Random();




        // String do alfabeto
        string str = "abcdefghijklmnopqrstuvwxyz";
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
        int size = 2;

        texto();

        // Initializing the empty string 
        string ran = "";
        string ran2 = "";

        for (int i = 0; i < size; i++)
        {

            // Selecting a index randomly 
            int x = res.Next(26);
            int y = res.Next(9);
            // Appending the character at the  
            // index to the random string. 
            Random numerorandom = new Random();
            numerorandom.Next(0, 10);
            ran = ran + str[x];
            ran2 = ran2 + numeros[y];
            
            //ran2 = ran2 + numerorandom.ToString;
            //var int2 = int.Parse(numerorandom);
            //ran2 = ran2 + numeros[];

        }

        Console.WriteLine($"Senha aleatória: {ran}{ran2}");
        Console.WriteLine(ran2);

        Console.ReadLine();
        void texto()
        {

            Console.WriteLine("Bem vindo ao gerador de senhas. Digite quantos digítos você quer que sua senha tenha: ");
            size = int.Parse(Console.ReadLine());
        }
    }
}