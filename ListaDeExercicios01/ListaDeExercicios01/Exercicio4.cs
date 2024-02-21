using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio4
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 4 - Calcular idade");
            Console.Write("Digite a data de nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            int idade = CalcularIdade(dataNascimento);
            Console.WriteLine($"Sua idade é: {idade} anos");
        }

        private int CalcularIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day))
            {
                idade--;
            }
            return idade;
        }
    }
}
