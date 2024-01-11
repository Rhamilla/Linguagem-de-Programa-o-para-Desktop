using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loop externo para as tabuadas do 1 ao 10.
            for (int e = 1; e <= 10; e++)
            {
                // Loop interno para multiplicar cada número de 1 a 10 pelo número atual (e) do loop externo.
                for (int d = 1; d <= 10; d++)
                {
                    // Imprime a tabuada atual.
                    Console.WriteLine(e + "x" + d + "=" + e * d);
                }
            }

            // Mantém o console aberto até que uma tecla seja pressionada.
            Console.Read();
        }
    }
}
