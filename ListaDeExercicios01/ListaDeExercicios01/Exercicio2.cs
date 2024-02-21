using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio2
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 2 - USD para BRL");
            Console.Write("Digite o valor em USD: ");
            double valorUSD = Convert.ToDouble(Console.ReadLine());
            double valorBRL = valorUSD * 5.22;
            Console.WriteLine($"O valor em BRL é: {valorBRL}");
        }
    }
}
