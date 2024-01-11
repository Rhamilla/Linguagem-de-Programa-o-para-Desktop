using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Atividade_de_Conversao_numerica

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro entre 0 e 99:");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int num) && num >= 0 && num <= 99)
        {
            string number1 = ConvertNumberToWords(num);
            Console.WriteLine($"O número {num} por extenso é: {number1}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro entre 0 e 99.");
        }
        Console.ReadKey();
    }

    static string ConvertNumberToWords(int bu)
    {
        string[] units = { "Zero", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };
        string[] teens = { "Onze", "Doze", "Treze", "Catorze", "Quinze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove" };
        string[] tens = { "", "Dez", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };

        if (bu >= 0 && bu <= 9)
        {
            return units[bu];
        }
        else if (bu >= 11 && bu <= 19)
        {
            return teens[bu - 11];
        }
        else if (bu >= 21 && bu <= 99)
        {
            int unitDigit = bu % 10;
            int tenDigit = bu / 10;

            if (unitDigit == 0)
            {
                return tens[tenDigit];
            }
            else
            {
                return $"{tens[tenDigit]} e {units[unitDigit]}";
            }
        }
        else
        {
            return "Número fora do intervalo suportado.";
        }
    }

}

