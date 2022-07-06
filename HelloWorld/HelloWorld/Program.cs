using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld // POO
{
    internal class Program // POO
    {
        static void Main(string[] args) //func. principal
        {
            /*
            Console.WriteLine("Olá, Mundo!"); //escreve e quebra linha
            Console.Write("Oi"); //Só escreve
            //Console.ReadLine(); //nao deixa o console fechar imediatamente
            // o readline espera o usuario digitar algo


            //----> Variaveis
            // int = -156, 32344
            // float = -15.6, 232.132
            // Bool = True, False
            // String = "kdasoosdaokdsa"
            // char = 'a'

            //regras de nomenclatura de variais
            // letras de A-Z
            // numeros de 0-9 (contanto que nao seja o primeiro char do nome da var)
            // Não pode ter: @ $ .
            // pode ter _
            // nome nao pode ser igual a alguma palavra reservada

            int segundaGuerraMundial = 1942;

            // colocar f no final para entender que é um float
            float velocidade = 5.5f;

            string cor_favorita = "vermelho";

            bool masculino = true;

            char letra = 'a';

            // Alterar valor de uma variavel sem alterar declaração:
            int idade = 19; //declara valor
            Console.WriteLine(idade);
            idade = 20; //modifica valor
            Console.WriteLine(idade);
            // IMPOSSIVEL ALTERAR O TIPO DE UMA VARIAVEL.
            */

            //----> Formas de declarar variavel
            //1ª - tipo nome_var = valor;
            //2ª - var nome_var = valor; //forma preguiçosa omitindo tipo da variavel
            //3ª - dynamic nome_var = valor; //TIPAGEM DINAMICA

            //a 3ª lhe permite alterar o TIPO de uma variavel.
            //dynamic cor_favorita = "azul";
            //Console.WriteLine(cor_favorita);
            //cor_favorita = 123;
            //Console.WriteLine(cor_favorita);
            //Console.ReadLine();

            //----> não é recomendado usar o dynamic. Pois:
            //Ele quebra o padrão da linguagem, o padrão Tipado. Tudo no c# é fortemente baseado em tipos.

            //dynamic é menos performatica que os outros tipos de variaveis, o c# tem que ficar toda hora
            //checando se o tipo de variavel mudou, isso atrapalha o desempenho. 

            //PARECE PRATICO MAS NÃO É

            //dynamic só é usado em coisas especificas

            //criando uma variavel local para armazenar o valor digitado pelo usuario:
            //Console.Write("Qual seu nome?: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Olá " + nome);
            //Console.ReadLine();

            //----> CONSTANTES (irmãs gêmeas das variaveis(muito parecidos mas diferentes))
            //Quando cria uma constante, você só pode definir o valor pra ela UMA VEZ, e NUNCA MAIS pode mudar
            //Utilidade: SEGURANÇA, nao correr o risco de alterar o valor de uma variavel que pode quebrar o programa inteiro
            //EX: 
            // const float PI = 3,1415f;
            // O PI tem um valor fixo, nunca deve ser mudado, se for mudado acidentalmente, quebrará todo o programa.

            Console.ReadLine();
        }
    }
}
