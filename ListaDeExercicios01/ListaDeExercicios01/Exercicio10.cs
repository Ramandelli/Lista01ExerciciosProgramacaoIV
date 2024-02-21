using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio10
    {
        public void Executar() 
        {
            Console.WriteLine("\nExercício 10 - Cadastro e Avaliação de Alunos");

            List<Aluno> alunos = new List<Aluno>();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nMenu de Alunos:");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Cadastrar Notas");
                Console.WriteLine("3 - Cadastrar Total de Faltas");
                Console.WriteLine("4 - Verificar Situação dos Alunos");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nCadastrar Aluno:");
                        Aluno aluno = new Aluno();
                        Console.Write("Digite o nome do aluno: ");
                        aluno.Nome = Console.ReadLine();
                        Console.Write("Digite o RA do aluno: ");
                        aluno.RA = Console.ReadLine();
                        alunos.Add(aluno);
                        break;
                    case 2:
                        Console.WriteLine("\nCadastrar Notas:");
                        Console.Write("Digite o RA do aluno: ");
                        string raNota = Console.ReadLine();
                        Aluno alunoNota = alunos.Find(a => a.RA == raNota);
                        if (alunoNota != null)
                        {
                            Console.Write("Digite a nota da prova (máximo 10): ");
                            double notaProva = Math.Min(Convert.ToDouble(Console.ReadLine()), 10);
                            Console.Write("Digite a nota do trabalho (máximo 10): ");
                            double notaTrabalho = Math.Min(Convert.ToDouble(Console.ReadLine()), 10);
                            alunoNota.AdicionarNotas(notaProva, notaTrabalho);
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nCadastrar Total de Faltas:");
                        Console.Write("Digite o RA do aluno: ");
                        string raFalta = Console.ReadLine();
                        Aluno alunoFalta = alunos.Find(a => a.RA == raFalta);
                        if (alunoFalta != null)
                        {
                            Console.Write("Digite o total de faltas do aluno: ");
                            int totalFaltas = Convert.ToInt32(Console.ReadLine());
                            alunoFalta.TotalFaltas = totalFaltas;
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nSituação dos Alunos:");
                        foreach (Aluno a in alunos)
                        {
                            Console.WriteLine($"Aluno: {a.Nome}, RA: {a.RA}");
                            Console.WriteLine($"Nota da prova: {a.NotaProva}, Nota do trabalho: {a.NotaTrabalho}");
                            Console.WriteLine($"Média: {a.CalcularMedia():F2}");
                            Console.WriteLine($"Total de faltas: {a.TotalFaltas}");
                            Console.WriteLine($"Frequência: {a.CalcularFrequencia():P}");
                            Console.WriteLine($"Situação: {a.VerificarSituacao()}");
                            Console.WriteLine();
                        }
                        break;
                    case 0:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        class Aluno
        {
            public string Nome { get; set; }
            public string RA { get; set; }
            public double NotaProva { get; private set; }
            public double NotaTrabalho { get; private set; }
            public int TotalFaltas { get; set; }

            public void AdicionarNotas(double notaProva, double notaTrabalho)
            {
                NotaProva = notaProva;
                NotaTrabalho = notaTrabalho;
            }

            public double CalcularMedia()
            {
                return (NotaProva * 7 + NotaTrabalho * 3) / 10;
            }

            public double CalcularFrequencia()
            {
                int totalAulas = 25;
                double frequencia = (totalAulas - TotalFaltas) / (double)totalAulas;
                return frequencia;
            }

            public string VerificarSituacao()
            {
                double media = CalcularMedia();
                double frequencia = CalcularFrequencia();

                if (media >= 7 && frequencia >= 0.75)
                {
                    return "APROVADO";
                }
                else
                {
                    return "REPROVADO";
                }
            }
        }

    }
    
}
