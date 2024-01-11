using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_salaria
{
    internal class Program
    {
        static void Main(string[] args)
        {// Solicitar o salário base ao usuário
            Console.WriteLine("Informe o salário base do funcionário:");

            // Ler a entrada do usuário e converter para double
            if (double.TryParse(Console.ReadLine(), out double salarioBase))
            {
                // Aplicar bônus de 10% (0.1) ao salário
                double salarioComBonus10 = AplicarBonus(salarioBase, 0.1);
                Console.WriteLine($"Salário com bônus de 10%: R${salarioComBonus10}");

                // Aplicar bônus de 7% (0.07) ao salário
                double salarioComBonus7 = AplicarBonus(salarioBase, 0.07);
                Console.WriteLine($"Salário com bônus de 7%: R${salarioComBonus7}");

                // Adicionar bônus fixo de 100
                double salarioComBonusFixo = salarioBase + 100;
                Console.WriteLine($"Salário com bônus fixo de R$100: R${salarioComBonusFixo}");
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor de salário válido.");
            }

            // Manter o console aberto até que uma tecla seja pressionada
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
        }

        // Função para aplicar bônus ao salário base
        static double AplicarBonus(double salario, double percentual)
        {
            return salario * (1 + percentual);
        }
    }
    
}
