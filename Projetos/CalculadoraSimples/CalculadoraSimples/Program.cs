using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("CALCULADORA\n\nSelecione uma das opções abaixo:");
                Console.WriteLine("[1] - Soma\n[2] - Subtração\n[3] - Divisão\n[4] - Multiplicação\n[5] - Potencia\n[6] - Raiz\n[7] - Sair");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Somar();
                        break;

                    case Menu.Subtração:
                        Subtrair();
                        break;

                    case Menu.Divisão:
                        Dividir();
                        break;

                    case Menu.Multiplicação:
                        Multiplicar();
                        break;

                    case Menu.Potencia:
                        Potenciar();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }
        }

        static void Somar()
        {
            Console.WriteLine("Soma de dois numeros ");
            Console.Write("Escolha o 1º numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Escolha o 2º numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"O resultado é: {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Subtrair()
        {
            Console.WriteLine("Subtração de dois numeros ");
            Console.Write("Escolha o 1º numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Escolha o 2º numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;
            Console.WriteLine($"O resultado é: {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Dividir()
        {
            Console.WriteLine("Divisão de dois numeros ");
            Console.Write("Escolha o 1º numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Escolha o 2º numero: ");
            int num2 = int.Parse(Console.ReadLine());

            //divisao de dois numeros inteiros = resultado sempre inteiro
            //como divisao resulta em numero float, precisamos converter em float.
            float result = (float)num1 / (float)num2; //faça operação de cast (conversão de tipo)
            //a operação de cast é sempre feito primeira que a operação matematica.
            //cast nao funciona para tipos complexos.

            Console.WriteLine($"O resultado é: {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Multiplicar()
        {
            Console.WriteLine("Multiplicação de dois numeros ");
            Console.Write("Escolha o 1º numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Escolha o 2º numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 * num2;
            Console.WriteLine($"O resultado é: {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Potenciar()
        {
            Console.WriteLine("Potencia de um numero ");
            Console.Write("Escolha a base: ");
            int basePot = int.Parse(Console.ReadLine());

            Console.Write("Escolha o expoente: ");
            int expoent = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(basePot, expoent); 
            //math.pow retorna um valor do tipo double
            //entao podemos simplesmente fazer um cast pra int. 

            Console.WriteLine($"O resultado é: {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero ");
            Console.Write("Escolha o numero: ");
            int num = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(num); 
            //retorna double, como muitas raizes retornam valores quebrados
            //vamos mudar o tipo da variavel result para double

            Console.WriteLine($"A raiz quadrada de {num} é: {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
