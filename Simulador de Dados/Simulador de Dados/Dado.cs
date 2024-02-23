using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simulador_de_Dados
{
    internal class Dado
    {

        public int res;
        public int quantidade;
        public int lados = 1;




        public void rolar()
        {
            Console.Beep();

            Random random = new Random();
            int quant = 1;
            for (int i = 0; i < quantidade; i++)
            {
               

                res = random.Next(1, lados+1);
                    
                    if (lados == res && lados == 1)
                    {
                        res = res + modificador;
                        Console.WriteLine($"A rolagem do {quant}º dado {lados} deu um resultado de: {res}");
                        Thread.Sleep( 400 );
                    }
                    else if (lados == res)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        res = res + modificador;
                        Console.WriteLine($"A rolagem do {quant}º dado {lados} deu um resultado de: {res} -- SUCESSO CRÍTICO!!");
                        Thread.Sleep(400);
                        Console.ForegroundColor= ConsoleColor.Yellow;
                    }
                    else if (res == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        res = res + modificador;
                        Console.WriteLine($"A rolagem do {quant}º dado {lados} deu um resultado de: {res} -- FALHA CRÍTICA!!");
                        Thread.Sleep(400);
                        Console.ForegroundColor= ConsoleColor.Yellow;
                    }
                    else
                    {
                        
                        res = res + modificador;
                        Console.WriteLine($"A rolagem do {quant}º dado {lados}+{modificador} deu um resultado de: {res}");
                        Thread.Sleep( 400 );
                    }
                        quant++;
            }       
        }

    }
}
