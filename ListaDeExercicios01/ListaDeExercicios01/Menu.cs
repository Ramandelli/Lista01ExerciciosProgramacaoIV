using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Menu
    {
        public void Executar()
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Exercício 1: BRL para USD");
                Console.WriteLine("2 - Exercício 2: USD para BRL");
                Console.WriteLine("3 - Exercício 3: Média de gasto de um automóvel");
                Console.WriteLine("4 - Exercício 4: Calcular idade");
                Console.WriteLine("5 - Exercício 5: Calculadora");
                Console.WriteLine("6 - Exercício 6: Contagem de vogais");
                Console.WriteLine("7 - Exercício 7: Contagem de consoantes");
                Console.WriteLine("8 - Exercício 8: Determinar faixa etária");
                Console.WriteLine("9 - Exercício 9: Cadastro de livro");
                Console.WriteLine("10 - Exercício 10: Cadastro e Avaliação de Alunos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        new Exercicio1().Executar();
                        break;
                    case 2:
                        new Exercicio2().Executar();
                        break;
                    case 3:
                        new Exercicio3().Executar();
                        break;
                    case 4:
                        new Exercicio4().Executar();
                        break;
                    case 5:
                        new Exercicio5().Executar();
                        break;
                    case 6:
                        new Exercicio6().Executar();
                        break;
                    case 7:
                        new Exercicio7().Executar();
                        break;
                    case 8:
                        new Exercicio8().Executar();
                        break;
                    case 9:
                        new Exercicio9().Executar();
                        break;
                    case 10:
                        new Exercicio10().Executar();
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}

