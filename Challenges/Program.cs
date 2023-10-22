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
            Console.WriteLine("Desafio 3 - Estrutura Sequencial");
            Console.WriteLine("");
            Console.WriteLine("P1 - Desafio: Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma \r\nmensagem explicativa. Confira:");
            int soma1, soma2, resultadoSoma;

            soma1 = int.Parse(Console.ReadLine());
            soma2 = int.Parse(Console.ReadLine());

            resultadoSoma = soma1 + soma2;

            Console.WriteLine("SOMA = " + resultadoSoma);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("P2 - Desafio: Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro \r\ncasas decimais conforme exemplos.\r\nFórmula da área: area = π . raio2\r\nConsidere o valor de π = 3.14159. Confira:");

            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("P3 - Desafio: Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto \r\nde A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). Confira:");
            int A2, B2, C2, D2, dif;

            A2 = int.Parse(Console.ReadLine());
            B2 = int.Parse(Console.ReadLine());
            C2 = int.Parse(Console.ReadLine());
            D2 = int.Parse(Console.ReadLine());

            dif = A2 * B2 - C2 * D2;

            Console.WriteLine("DIFERENCA = " + dif);

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("P4 - Desafio: Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por \r\nhora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas \r\ndecimais. Confira:");
            int numero, horas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("P5 - Desafio: Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o \r\ncódigo de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. Confira:");
            int cod1, cod2, qte1, qte2;
            double preco3, preco4, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco4 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco3 * qte1 + preco4 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("P6 - Desafio: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e \r\nmostre: \r\na) a área do triângulo retângulo que tem A por base e C por altura. \r\nb) a área do círculo de raio C. (pi = 3.14159) \r\nc) a área do trapézio que tem A e B por bases e C por altura. \r\nd) a área do quadrado que tem lado B. \r\ne) a área do retângulo que tem lados A e B. Confira:");

            double A3, B3, C3, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores3 = Console.ReadLine().Split(' ');
            A3 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B3 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A3 * C3 / 2.0;
            circulo = 3.14159 * C3 * C3;
            trapezio = (A3 + B3) / 2.0 * C3;
            quadrado = B3 * B3;
            retangulo = A3 * B3;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));




            //----------------------------------------------------------------------
            // DESAFIOS DE LÓGICA COM O C#
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Desafio 2 - Entrada de dados");

            Console.WriteLine("Entre com o seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha): ");
            string[] vet2 = Console.ReadLine().Split(' ');
            string nome2 = vet2[0];
            int idade2 = int.Parse(vet2[1]);
            double altura2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Informações recebidas:");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome2);
            Console.WriteLine(idade2);
            Console.WriteLine(altura2.ToString("F2", CultureInfo.InvariantCulture));



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