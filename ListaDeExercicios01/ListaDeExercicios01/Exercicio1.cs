using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio1
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 1 - BRL para USD");
            Console.Write("Digite o valor em BRL: ");
            double valorBRL = Convert.ToDouble(Console.ReadLine());
            double valorUSD = valorBRL * 0.193259;
            Console.WriteLine($"O valor em USD é: {valorUSD}");
        }
    }
}
