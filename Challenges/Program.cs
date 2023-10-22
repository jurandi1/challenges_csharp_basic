using System;
using System.Globalization;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------
            // DESAFIOS DE LÓGICA COM O C#
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Desafio 1 - Conversão implícita e casting");
            string Produto1 = "Computador";
            string Produto2 = "Mesa de Escritório";

            byte idade = 22;
            int codigo = 5290;
            char genero = '\u004D';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{Produto1}, cujo o preço é $ {preco1:F2}");
            Console.WriteLine($"{Produto2}, cujo o preço é $ {preco2:F2}");

            Console.WriteLine($"Registro:{idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com 8 casas decimais: {medida}");
            Console.WriteLine($"Arredondado: {medida:F3}");
            Console.WriteLine("Separador deciamal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}