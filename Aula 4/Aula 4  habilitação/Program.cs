using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_habilitação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração da variável idade
            short idade;

            // Solicitando a idade ao usuário
            Console.WriteLine("Informe sua idade: ");

            // Lendo a entrada do usuário e convertendo para short
            if (short.TryParse(Console.ReadLine(), out idade))
            {
                // Verificando se a idade é maior ou igual a 18
                if (idade >= 18)
                {
                    // Exibindo na tela
                    Console.WriteLine("Possui habilitação.");
                }
                else
                {
                    Console.WriteLine("Não possui habilitação.");
                }
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }

            // Esperando o usuário pressionar uma tecla para encerrar
            Console.WriteLine("Pressione uma tecla para encerrar");
            Console.ReadKey();
        }
    }
    
}
