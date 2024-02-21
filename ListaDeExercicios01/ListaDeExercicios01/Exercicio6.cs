using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio6
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 6 - Contagem de vogais");
            Console.Write("Digite uma palavra ou frase: ");
            string texto = Console.ReadLine().ToLower();
            int contadorVogais = ContarVogais(texto);
            Console.WriteLine($"Quantidade de vogais: {contadorVogais}");
        }

        private int ContarVogais(string texto)
        {
            int contadorVogais = 0;
            foreach (char c in texto)
            {
                if ("aeiou".Contains(c))
                    contadorVogais++;
            }
            return contadorVogais;
        }
    }
}
