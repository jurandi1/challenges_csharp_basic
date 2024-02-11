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
            Console.WriteLine("Desafio 6 -  Estrutura Repetitiva FOR ");
            Console.WriteLine("");
            Console.WriteLine("E1 -   Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso. ");

            int x3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x3; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E2 -  Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. \r\nMostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando \r\nessas informações conforme exemplo (use a palavra \"in\" para dentro do intervalo, e \"out\" para fora do intervalo).  ");

            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++)
            {
                int x4 = int.Parse(Console.ReadLine());
                if (x4 >= 10 && x4 <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E3 - Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste \r\nde 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes \r\nconjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem \r\npeso 5. ");

            int n3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n3; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E4 - Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo \r\nsegundo. Se o denominador for igual a zero, mostrar a mensagem \"divisao impossivel\".  ");

            int n5 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n5; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int x4 = int.Parse(line[0]);
                int y4 = int.Parse(line[1]);

                if (y4 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x4 / y4;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E5 -  Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. \r\nLembrando que, por definição, fatorial de 0 é 1. ");

            int n6 = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i2 = 1; i2 <= n6; i2++)
            {
                fat = fat * i2;
            }

            Console.WriteLine(fat);

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E6 -  Ler um número inteiro N e calcular todos os seus divisores. ");

            int n7 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n7; i++)
            {
                if (n7 % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E7 -  Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, \r\ncomeçando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme \r\nexemplo.  ");

            int n8 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n8; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }

            //----------------------------------------------------------------------
            // DESAFIOS DE LÓGICA COM O C#
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Desafio 5 -  Estrutura Repetitiva WHILE ");
            Console.WriteLine("");
            Console.WriteLine("E1 -  Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha \r\nincorreta informada, escrever a mensagem \"Senha Invalida\". Quando a senha for informada corretamente deve ser \r\nimpressa a mensagem \"Acesso Permitido\" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. ");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E2 -  Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema \r\ncartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo \r\nmenos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). ");

            string[] valores2 = Console.ReadLine().Split(' ');
            int x2 = int.Parse(valores2[0]);
            int y2 = int.Parse(valores2[1]);

            while (x2 != 0 && y2 != 0)
            {
                if (x2 > 0 && y2 > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x2 < 0 && y2 > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x2 < 0 && y2 < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores2 = Console.ReadLine().Split(' ');
                x2 = int.Parse(valores2[0]);
                y2 = int.Parse(valores2[1]);
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E3 -  Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva \r\num algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel \r\n4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até \r\nque seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a \r\nmensagem: \"MUITO OBRIGADO\" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme \r\nexemplo. ");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

            //----------------------------------------------------------------------
            // DESAFIOS DE LÓGICA COM O C#
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Desafio 4 - Estrutura Condicional (if-else) ");
            Console.WriteLine("");
            Console.WriteLine("E1 - Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. ");
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E2 - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. ");
            
            int N2 = int.Parse(Console.ReadLine());

            if (N2 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E3 - Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem \"Sao Multiplos\" ou \"Nao sao \r\nMultiplos\", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente. ");

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E4 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. ");
            string[] valores5 = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores5[0]);
            int horaFinal = int.Parse(valores5[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E5 - Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar. ");
            string[] valores6 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(valores6[0]);
            int quantidade = int.Parse(valores6[1]);

            double total1;
            if (codigo1 == 1)
            {
                total1 = quantidade * 4.0;
            }
            else if (codigo1 == 2)
            {
                total1 = quantidade * 4.5;
            }
            else if (codigo1 == 3)
            {
                total1 = quantidade * 5.0;
            }
            else if (codigo1 == 4)
            {
                total1 = quantidade * 2.0;
            }
            else
            {
                total1 = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total1.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E6 - Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. ");

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E7 -  Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0). Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.");

            string[] valores7 = Console.ReadLine().Split(' ');
            double x = double.Parse(valores7[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores7[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("E8 - Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem \r\nque nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem \r\nqualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. \r\n \r\nLeia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e \r\nmostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo. \r\n \r\n \r\n \r\nLembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de \r\nsalário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é \r\nde 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com \r\nduas casas decimais. ");

            double salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario1 <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario1 <= 3000.0)
            {
                imposto = (salario1 - 2000.0) * 0.08;
            }
            else if (salario1 <= 4500.0)
            {
                imposto = (salario1 - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario1 - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

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

            double R, A1, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A1 = pi * R * R;

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
            int numero1, horas;
            double valorHora, salario;

            numero1 = int.Parse(Console.ReadLine());
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

            string[] valores4 = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores4[0]);
            qte1 = int.Parse(valores4[1]);
            preco3 = double.Parse(valores4[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores4[0]);
            qte2 = int.Parse(valores4[1]);
            preco4 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco3 * qte1 + preco4 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("P6 - Desafio: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e \r\nmostre: \r\na) a área do triângulo retângulo que tem A por base e C por altura. \r\nb) a área do círculo de raio C. (pi = 3.14159) \r\nc) a área do trapézio que tem A e B por bases e C por altura. \r\nd) a área do quadrado que tem lado B. \r\ne) a área do retângulo que tem lados A e B. Confira:");

            double A3, B3, C3, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores3 = Console.ReadLine().Split(' ');
            A3 = double.Parse(valores4[0], CultureInfo.InvariantCulture);
            B3 = double.Parse(valores4[1], CultureInfo.InvariantCulture);
            C3 = double.Parse(valores4[2], CultureInfo.InvariantCulture);

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