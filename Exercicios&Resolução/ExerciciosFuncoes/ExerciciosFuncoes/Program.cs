using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFuncoes
{
    internal class Program
    {
        //---> 1 - Crie um programa em C# que utilize uma Função chamada “ PrecoFinal ” que
        //ajuste em 25% a mais do valor inicial dos produtos:
        //● Chocolate: 30
        //● Refrigerante: 50
        //● Bolo: 45
        //● Sorvete: 60
        //● Pão: 15
        // exiba o resultado na tela

        static void Main(string[] args)
        {
            PrecoFinal(30, "Chocolate");
            PrecoFinal(50, "Refrigerante");
            PrecoFinal(45, "Bolo");
            PrecoFinal(60, "Sorvete");
            PrecoFinal(15, "Pão");

            Console.ReadLine();
        }

        static void PrecoFinal(float preco, string nome)
        {
            float precoAjuste = (25f / 100f) * preco;
            float precoTotal = precoAjuste + preco;

            Console.WriteLine("O preço final do " + nome + " com ajuste de 25% é: R$ " + precoTotal);
        }





        //---> 2- Paulo é um pizzaiolo que precisa descobrir a área de uma circunferência para
        //conseguir fazer a pizza perfeita e ganhar o concurso nacional, Crie um programa C#
        //fazendo o uso das funções, que calcule a área de um círculo, recebendo o raio valor
        //30 desejado por Paulo.
        // formula: A = pi . r^2 

        //fiz e agora melhorei, ao inves de sempre receber 30, o usuario escolhe o raio

        //static void Main(string[] args)
        //{
        //    //Area(30);
        //    Console.Write("Escolha o raio: ");
        //    Area(float.Parse(Console.ReadLine()));
        //    Console.ReadLine();
        //}

        //static void Area(float raio)
        //{
        //    const float valorPI = 3.14f;
        //    float valorArea = valorPI * (raio * raio);
        //    Console.WriteLine("O valor da área é: " + valorArea + "cm^2.");
        //}





        //---> 3- Alguns engenheiros precisam construir uma praça em um terreno que tem
        //formato Triangular, porém precisam saber qual a área exata desse terreno, Crie um
        //programa em C# com uma função que calcule a área de um triângulo, recebendo
        //uma base de 250 e uma altura de 350 como parâmetros.

        //formula: a = b x h / 2
        //static void Main(string[] args)
        //{
        //    AreaTri(250, 350);

        //    Console.ReadLine();
        //}
        //static void AreaTri(float baseTri, float alturaTri)
        //{
        //    float area = (baseTri * alturaTri) / 2;
        //    Console.WriteLine("A área desse triângulo é: " + area + "cm^2");
        //}
    }
}
