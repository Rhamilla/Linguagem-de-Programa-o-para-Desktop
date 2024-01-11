using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // codigo pra ser feito o codigo de baskara
            // variaveis declaradas
            int a = 1;
            int b = -3;
            int c = -4;

            // cauculo foi dismenbrado pra ser realizado
            double bask = b * b - 4 * a * c;
            double bask1 = (-b + (bask)) / (2 * a);
            double bask2 = (-b - (bask)) / (2 * a);
            double result = bask/bask1;

            // cauculo demostrado em tela
            Console.WriteLine("result = " + bask1 + "\nbask2 = " + bask2);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
