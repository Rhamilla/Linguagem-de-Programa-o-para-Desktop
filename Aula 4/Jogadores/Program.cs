using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a idade ao usuário
            Console.WriteLine("Informe sua idade: ");

            // Lê a entrada do usuário e converte para int
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                // Verifica a categoria baseada na idade fornecida
                if (idade <= 18)
                {
                    Console.WriteLine("Você jogará na categoria Juvenil.");
                }
                else if (idade >= 23)
                {
                    //Console.WriteLine("Você não jogará na categoria Juvenil.");
                    Console.WriteLine("Você pode jogar na categoria Profissional.");
                }
                else
                {
                    Console.WriteLine("Você não está na categoria Juvenil, mas também não está na Profissional.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira uma idade válida.");
            }

            // Mantém o console aberto até que uma tecla seja pressionada
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
        }
    }
    
}
