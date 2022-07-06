using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //< > != == <= >= 
            //if (args.Length == 0)
            //RESOLUÇÃO EXERCICIOS CONDICIONAIS

            //---> ex1: Crie um Programa em C# que receba três números do usuário, informe na tela qual
            //é o MENOR deles ou exiba se eles são iguais.
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Escolha um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha outro numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha mais um numero: ");
            num3 = int.Parse(Console.ReadLine());


            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("O menor numero é primeiro inserido: " + num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("O menor numero é o segundo inserido: " + num2);
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine("O menor numero é o terceiro inserido: " + num3);
            }
            else
            {
                Console.WriteLine("Os numeros são iguais!");
            }
            Console.ReadLine();

            //---> ex2: Crie um Programa em C# que, receba três números do usuário, informe na tela qual
            //é o MAIOR deles ou exiba se eles são iguais
            // É SÓ INVERTER OS SINAIS DO EX1 PORRA

            //---> ex3: Guilherme é chefe do setor de T.I de sua empresa e precisa que você ajude-o a
            //criar um programa usando a linguagem C# que receba os chamados dos usuários
            //classificando e exibindo na tela o seu nível de urgência, sendo de 0 - 3 "BAIXO", maior
            //que 3 até 6 "MÉDIO", maior que 6 até 9 "ALTO", para os demais casos é considerado
            //"GRAVE".
            //Console.WriteLine("Qual o nível de urgência do seu chamado?");
            //int urgencia = int.Parse(Console.ReadLine());

            //if (urgencia > 9)
            //{
            //    Console.WriteLine("Seu chamado é GRAVE");
            //}
            //else if (urgencia > 6 && urgencia <= 9)
            //{
            //    Console.WriteLine("Seu chamado é ALTO");
            //}
            //else if (urgencia >= 3 && urgencia <= 6)
            //{
            //    Console.WriteLine("Seu chamado é MÉDIO");
            //}  
            //else
            //{
            //    Console.WriteLine("Seu chamado é BAIXO");
            //}
            //Console.ReadLine();


            // Exercicios que nao estao na lista de exercicios mas que fiz. 
            //---> ex4: O usuario é criança, adolescente, adulto ou idoso?

            //int idade;

            //Console.Write("Digite a sua idade: ");
            //idade = int.Parse(Console.ReadLine());

            //if (idade < 12)
            //{
            //    Console.WriteLine("Você é uma criança!");
            //}
            //else if (idade >= 12 && idade < 18)
            //{
            //    Console.WriteLine("Você é um adolescente!");
            //}
            //else if (idade >= 18 && idade < 60)
            //{
            //    Console.WriteLine("Você é um adulto!");
            //}
            //else
            //{
            //    Console.WriteLine("Você é um idoso!");
            //}
            //Console.ReadLine();



            //---> ex5: que idealizei e fiz sozinho:
            //Tem se alistar no exercito? 
            //tem muito ifs, mesmo sabendo que poderia usar operadores de repeticao, decidi me limitar
            //e seguir o curso na ordem, fazendo oq ele ensina. (estudei visualg "portugol" antes :D)
            //(e um pouco de python)

            //Console.WriteLine("===========");
            //Console.WriteLine("ALISTAMENTO");
            //Console.WriteLine("===========");

            //string saida = "Pressione qualquer tecla para sair...";

            //Console.Write("Qual a sua idade?: ");
            //int idade = Convert.ToInt32(Console.ReadLine());
            ////Console.Clear(); ficou ruim limpar tela

            //if (idade == 18)
            //{
            //    Console.WriteLine("Você DEVE se alistar!");

            //}
            //else if (idade < 18)
            //{
            //    Console.WriteLine("Você AINDA não pode se alistar!");

            //}
            //else
            //{
            //    Console.WriteLine("Você DEVE regularizar a sua situação!");
            //    Console.WriteLine("Sabe como resolver esse problema? [S]/[N] ");
            //    string resp = Console.ReadLine().ToUpper();

            //    if (resp == "N")
            //    {
            //        Console.WriteLine("Compareça a uma Junta militar que eles vão ti guiar.");
            //        Console.WriteLine("Entendeu? [S]/[N]");
            //        string resp2 = Console.ReadLine().ToUpper();

            //        if (resp2 == "S")
            //        {
            //            Console.WriteLine("Beleza boa sorte :D");

            //        }
            //        else if (resp2 == "N")
            //        {
            //            Console.WriteLine("Compareça a uma Junta militar BURRO");

            //        }
            //        else
            //        {
            //            Console.WriteLine("ERA PRA RESPONDER 'S' OU 'N' BURRO");

            //        }
            //    }
            //    else if (resp == "S")
            //    {
            //        Console.WriteLine("Beleza boa sorte :D");

            //    }
            //    else
            //    {
            //        Console.WriteLine("ERA PRA RESPONDER 'S' OU 'N' BURRO");

            //    }
            //}
            //Console.WriteLine(saida);
            //Console.ReadLine();
        }
    }
}
