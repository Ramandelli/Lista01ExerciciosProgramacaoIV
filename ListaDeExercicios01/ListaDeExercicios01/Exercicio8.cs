using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio8
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 8 - Determinar faixa etária");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            int idade = CalcularIdade(dataNascimento);
            string faixaEtaria = DefinirFaixaEtaria(idade);
            Console.WriteLine($"Olá, {nome}! Você é {faixaEtaria}");
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

        private string DefinirFaixaEtaria(int idade)
        {
            string faixaEtaria = idade switch
            {
                int n when (n <= 19) => "Jovem",
                int n when (n >= 20 && n <= 59) => "Adulto",
                _ => "Idoso"
            };
            return faixaEtaria;
        }
    }
}
