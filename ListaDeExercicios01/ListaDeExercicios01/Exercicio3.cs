using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios01
{
    internal class Exercicio3
    {
        public void Executar()
        {
            Console.WriteLine("\nExercício 3 - Média de gasto de um automóvel");
            Console.Write("Digite a distância total em KM percorrida: ");
            double distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o gasto de combustível em litros: ");
            double combustivel = Convert.ToDouble(Console.ReadLine());
            double media = distancia / combustivel;
            Console.WriteLine($"A média de consumo do automóvel é: {media} KM/L");
        }
    }
}
