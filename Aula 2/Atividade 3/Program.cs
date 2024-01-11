using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Codigo para alterar o pi que e um numero decimal (declarado como double)
            // Em um numero inteiro ( decclarado como int)
            double pi = 3.14;
            int piQuebrado = (int)pi;
            Console.WriteLine("piQuebrado = " + piQuebrado);
            Console.ReadLine();
            // O valor de piQuebrado nesse caso é 3, pois estamos "forçando" a conversão do double para um inteiro.
        }
    }
}
