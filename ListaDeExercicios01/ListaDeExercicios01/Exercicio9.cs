using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio9
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 9 - Cadastro de livro");
            Livro livro = new Livro();
            Console.Write("Digite o título do livro: ");
            livro.Titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            livro.Autor = Console.ReadLine();
            Console.Write("Digite o valor do livro: ");
            livro.Valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(livro);
        }
    }

    struct Livro
    {
        public string Titulo;
        public string Autor;
        public double Valor;

        public override string ToString()
        {
            return $"Livro: {Titulo}, Autor: {Autor}, Valor: {Valor}";
        }
    }
}
