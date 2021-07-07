using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;

namespace Apostila
{
    class Program
    {
        public const double pi = 3.14159;
        public const string senhaC = "2022";
        //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
        static void soma()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Soma = {a + b}");
            Console.Read();
        }
        //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
        //casas decimais conforme exemplos.
        //Fórmula da área: area = π.raio2
        //Considere o valor de π = 3.14159
        static void areacirculo()
        {
            Console.WriteLine("Digite raio");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"A = {r* r*pi}");
            Console.Read();

        }
        /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
        de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)*/
        static void subtracaoProduto()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"DIFERENÇA = {(a *b)-(c*d)}");
            Console.Read();
        }
        /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
        hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
        decimais*/
        static void salario()
        {
            int N = int.Parse(Console.ReadLine());
            float numHoras = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float perHour = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NUMBER = {N}");
            Console.WriteLine($"SALARY US$ = {(numHoras*perHour).ToString("0.00")}");
            Console.Read();
        }
        /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/
        static void loja()
        {
            string s = Console.ReadLine();
            string[] vet1 = s.Split(' ');
            //string code1 = vet1[0];
            int num1 = int.Parse(vet1[1]);
            float val1 = float.Parse(vet1[2], CultureInfo.InvariantCulture);
            //2
            string s2 = Console.ReadLine();
            string[] vet2 = s2.Split(' ');
            //string code2 = vet2[0];
            int num2 = int.Parse(vet2[1]);
            float val2 = float.Parse(vet2[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a Pagar = {num1*val1+num2*val2}");
            Console.Read();
        }
        /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
        mostre:
        a) a área do triângulo retângulo que tem A por base e C por altura.
        b) a área do círculo de raio C. (pi = 3.14159)
        c) a área do trapézio que tem A e B por bases e C por altura.
        d) a área do quadrado que tem lado B.
        e) a área do retângulo que tem lados A e B.*/
        static void area()
        {
            string s = Console.ReadLine();
            string[] vet1 = s.Split(' ');
            double a = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            Console.WriteLine($"TRIANGULOr = {a*c/2}");
            Console.WriteLine($"CIRCULO = {pi*c*c}");
            Console.WriteLine($"TRAPÉZIO = {(a+b)*c / 2}");
            Console.WriteLine($"QUADRADO = {b*b}");
            Console.WriteLine($"RETÂNGULO = {a * b}");
            Console.Read();
        }
        //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

        static void inteiroOuN()
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 0) Console.WriteLine("POSITIVO");
            else Console.WriteLine("NEGATIVO");
            Console.ReadLine();
        }
        //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
        static void parImpar()
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 ==0) Console.WriteLine("par");
            else Console.WriteLine("impar");
            Console.ReadLine();
        }
        /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        ordem crescente ou decrescente.*/
        static void multiplos()
        {
            string s = Console.ReadLine();
            string[] vet1 = s.Split(' ');
            int a = int.Parse(vet1[0]);
            int b = int.Parse(vet1[1]);
            if (a > b)
            {
                if(a%b==0) Console.WriteLine("São Múltiplos");
                else Console.WriteLine("Não são Múltiplos");
            }
            else
            {
                if (b % a == 0) Console.WriteLine("São Múltiplos");
                else Console.WriteLine("Não são Múltiplos");
            }
            Console.ReadLine();
        }
        /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
        começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/
        static void jogo()
        {
            string s = Console.ReadLine();
            string[] vet1 = s.Split(' ');
            int a = int.Parse(vet1[0]);
            int b = int.Parse(vet1[1]);

            if (a > b) Console.WriteLine($"O JOGO DUROU {(24 - a) + b} HORA(S)");
            else if(a==0 && b==0) Console.WriteLine($"O JOGO DUROU {24} HORA(S)");
            else
            {
                Console.WriteLine($"O JOGO DUROU {b-a} HORA(S)");
            }
            Console.ReadLine();
        }
        /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
        seguir, calcule e mostre o valor da conta a pagar.*/
        static void hotdog()
        {
            double[] c = { 4, 4.5, 5, 2, 1.5 };

            string s = Console.ReadLine();
            string[] vet1 = s.Split(' ');
            int a = int.Parse(vet1[0]);
            int b = int.Parse(vet1[1]);
            Console.WriteLine($" Total R$: {c[a - 1] *b}");
            Console.ReadLine();
        }
        /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
        seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
        nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/
        static void intervalo()
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (a > 0 && a <= 25) Console.WriteLine("Intervalo: [0,25]");
            else if (a > 25 && a <= 50) Console.WriteLine("Intervalo: [25,50]");
            else if (a > 50 && a <= 75) Console.WriteLine("Intervalo: [50,75]");
            else if (a > 75 && a <= 100) Console.WriteLine("Intervalo: [75,100]");
            else Console.WriteLine("Fora dos Intervalos");
            Console.ReadLine();
        }
        /*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
        de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
        ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
        Se o ponto estiver na origem, escreva a mensagem “Origem”.
        Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
        situação*/
        static void grafico()
        {
            string s = Console.ReadLine();
            string[] vet1 = s.Split(' ');
            double a = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            if (a==00 && b==00) Console.WriteLine("Origem");
            else if (a==0) Console.WriteLine("Eixo y");
            else if (b == 0) Console.WriteLine("Eixo x");
            else if (a < 0 && b< 0) Console.WriteLine("Q3");
            else if (a > 0 && b < 0) Console.WriteLine("Q4");
            else if (a < 0 && b > 0) Console.WriteLine("Q2");
            else if (a > 0 && b > 0) Console.WriteLine("Q1");
            Console.ReadLine();
        }
        /*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
        que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
        qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
        Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
        mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
        Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
        salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
        de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
        duas casas decimais*/
        static void impost()
        {
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (sal < 2000) Console.WriteLine("Isento");
            else if (sal > 2000 && sal < 3000) Console.WriteLine($"R$ {((sal - 2000) * 0.8).ToString("0.00")}");
            else if (sal > 3000 && sal < 4500) Console.WriteLine($"R$ {((1000 * 0.08)+((sal-3000)*0.18)).ToString("0.00")}");
            else if (sal > 4500) Console.WriteLine($"R$ {((1000 * 0.08) + (1500*0.18) + ((sal - 4500) * 0.28)).ToString("0.00")}");
            Console.ReadLine();
        }
        //PDF 3
        /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
        incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
        impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/
        static void senha()
        {
            do
            {
                string senha = (Console.ReadLine());
                if (senha == senhaC) break;
                Console.WriteLine("Senha Inválida");
            } while (true);
            Console.WriteLine("Acesso Permitido");
            Console.ReadLine();
        }
        /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidadeindeterminada de pontos no sistema cartesiano.
         * Para cada ponto escrever o quadrante a que ele pertence.
         * O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/
        static void quadrante()
        {
            do
            {
                string s = Console.ReadLine();
                string[] vet1 = s.Split(' ');
                double a = double.Parse(vet1[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet1[1], CultureInfo.InvariantCulture);

                if (a < 0 && b < 0) Console.WriteLine("Terceiro");
                else if (a > 0 && b < 0) Console.WriteLine("Quarto");
                else if (a < 0 && b > 0) Console.WriteLine("Segundo");
                else if (a > 0 && b > 0) Console.WriteLine("Primeiro");
                else break;
            } while (true);

            Console.ReadLine();
        }
        /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
         * Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).
         * Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido).
         * O programa será encerrado quando o código informado for o número 4.
         * Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.*/
        static void posto()
        {
            string s;
            int gasolina, alcool, Diesel;
            gasolina = alcool = Diesel = 0;
            do
            {
                s = Console.ReadLine();
                if (s == "1") alcool++;
                if (s == "2") gasolina++;
                if (s == "3") Diesel++;
            } while (s != "4");
            Console.WriteLine($"MUITO OBRIGADO \n Alcool: {alcool} \n Gasolina: {gasolina} \n Diesel: {Diesel}");
            Console.ReadLine();
        }

        //pdf 4
        /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
        X, se for o caso.*/
        static void listaImpar()
        {
            int x = int.Parse(Console.ReadLine());
            for(int i=1; i<=x; i=i+2)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }
        /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
        Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
        essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)*/

        static void ex2()
        {
            int x = int.Parse(Console.ReadLine());
            int Nin, Nout;
            Nin = Nout = 0;
            for(int i=0; i<x; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a >= 10 && a <= 20) Nin++;
                else Nout++;
            }
            Console.WriteLine($"in: {Nin} \nout: {Nout}");
            Console.ReadLine();
        }
        /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
        de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
        conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
        peso 5.*/
        static void media()
        {
            int N = int.Parse(Console.ReadLine());
            var medias= new List<double>();
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                string[] vet1 = s.Split(' ');
                double a = double.Parse(vet1[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet1[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet1[2], CultureInfo.InvariantCulture);
                medias.Add((a * 2 + b * 3 + c * 5)/10);
            }
            foreach (var media in medias)
            {
                Console.WriteLine(media);
            }
            Console.ReadLine();
        }

        /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
        segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"*/
        static void divisions()
        {
            int N = int.Parse(Console.ReadLine());
            var resultados = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                string[] vet1 = s.Split(' ');
                double a = double.Parse(vet1[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet1[1], CultureInfo.InvariantCulture);
                if(b==0)resultados.Add("Divisão Impossível");
                else resultados.Add((a / b).ToString("0.00")); ;
            }
            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
            Console.ReadLine();
        }

        static int fatorial(int N)
        {
            if (N == 0) return 1;
            else return N*fatorial(N - 1);
        }
        static void fatorialTeste()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine((fatorial(N)).ToString());
            Console.ReadLine();
        }
        //Ler um número inteiro N e calcular todos os seus divisores.
        static void listadivisores()
        {
            int N = int.Parse(Console.ReadLine());
            for(int i=1; i<=N; i++)
            {
                if (N % i == 0) Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
        começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
        exemplo.*/
        static void potencia()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)}  {Math.Pow(i, 3)}");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            potencia();
        }
    }
}
