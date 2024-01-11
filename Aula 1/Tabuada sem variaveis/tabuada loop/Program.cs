using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_loop
{
    
        class Program
        {
            static void Main(string[] args)
            {
                // Declaração de variáveis
                double num1, num2;

                // Solicitar ao usuário os valores para as variáveis
                Console.WriteLine("Digite o primeiro número:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                num2 = Convert.ToDouble(Console.ReadLine());

                // Realizar as operações aritméticas e exibir os resultados
                Console.WriteLine("\nOperações Aritméticas:");
                Console.WriteLine($"Soma: {num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"Subtração: {num1} - {num2} = {num1 - num2}");
                Console.WriteLine($"Multiplicação: {num1} * {num2} = {num1 * num2}");

                // Verificar se o segundo número é diferente de zero antes de fazer a divisão
                if (num2 != 0)
                {
                    Console.WriteLine($"Divisão: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                }

                // Manter a janela do console aberta
                Console.ReadLine();
            }
        }
    }


 

