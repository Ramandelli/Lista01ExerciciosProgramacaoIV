using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio5
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 5 - Calculadora");
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Soma: {num1 + num2}");
            Console.WriteLine($"Subtração: {num1 - num2}");
            Console.WriteLine($"Multiplicação: {num1 * num2}");
            Console.WriteLine($"Divisão: {num1 / num2}");
            Console.WriteLine($"Resto da divisão: {num1 % num2}");
        }
    }
}
