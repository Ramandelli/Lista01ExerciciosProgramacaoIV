using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio7
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 7 - Contagem de consoantes");
            Console.Write("Digite uma palavra ou frase: ");
            string texto = Console.ReadLine().ToLower();
            int contadorConsoantes = ContarConsoantes(texto);
            Console.WriteLine($"Quantidade de consoantes: {contadorConsoantes}");
        }

        private int ContarConsoantes(string texto)
        {
            int contadorConsoantes = 0;
            foreach (char c in texto)
            {
                if ("bcdfghjklmnpqrstvwxyz".Contains(c))
                    contadorConsoantes++;
            }
            return contadorConsoantes;
        }
    }
}
