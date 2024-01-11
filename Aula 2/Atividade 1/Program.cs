using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Program
    
    { // Ativadide pra o uso de variaveis, cauculo de media de idade
        static void Main(string[] args)
        {
        int idadeJ = 10;
        int idadeM = 25;
        int idadeC = 30;

        // Calcule a média das idades.
        double mediaIdade = (idadeJ + idadeM + idadeC) / 3.0;

        // Exiba o resultado em um MessageBox.
        Console.WriteLine("A média das idades é: " + mediaIdade);
        Console.ReadLine();
    }
    }
}
