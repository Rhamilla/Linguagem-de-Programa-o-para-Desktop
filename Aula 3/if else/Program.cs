using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            //mostar a amensagem 
            Console.WriteLine("Coloque sua idade para acessar: ");
            // recebe a idade 
            idade = Convert.ToInt32(Console.ReadLine());

            // rece e para ser demostrado em tela as mensagens
            if (idade >= 18) { Console.WriteLine("Acesso Permitido!"); 
            }
            else { Console.WriteLine("ACESSO NEGADO! Por ser menor de idade."); 
            };
            Console.ReadLine();

        }
    }
}