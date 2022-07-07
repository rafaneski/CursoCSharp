using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    internal class Program
    {
        //Entendendo funções
        //Funções são variáveis que armazenam métodos. ~Eu
        static void Main(string[] args) //1ª func que é chamada ao iniciar é a Main
        {
            //ExibirMsg();

            //quando é passado um parametro em uma func, é obrigado passar um valor para o parametro na chamada
            //Preco(60);
            //Preco(10); //pode chamar a mesma func várias vezes mas com valores diferentes. 

            Console.Write("Qual o nome do produto?: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Quanto é o imposto?: ");
            float imposto = float.Parse(Console.ReadLine());
            Console.Write("Qual o preço do(a) " + nomeProduto + " ? R$: ");
            GerarPreco(float.Parse(Console.ReadLine()), nomeProduto, imposto);


            //usando return
            int result1 = Somar(1, 2, 3);
            int result2 = Somar(10, 20, 30);
            int result3 = Somar(100, 200, 300);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
        // void = a função retorna nada.
        //static void ExibirMsg() //dentro dos parenteses serao passados os parametros da func
        //{
        //    Console.WriteLine("Esse sistema é show de bola!");
        //    Console.WriteLine("Estou usando funções");
        //    Console.WriteLine("Bem vindo!");
        //}

        //static void Preco(int preco)//declarar parametros: func(tipo nome), quantos quiser.
        //{
        //    Console.WriteLine(preco);
        //    //variaveis criadas dentro de funçoes, só podem ser acessadas dentro dessa mesma função
        //}




        //----> Crie uma função que recebe o preço de um produto e mostra o preço desse produto na tela 
        //com o calculo de imposto. leve em conta imposto de 10%
        //parametros sao como variaveis, mas so podem ser usadas dentro de funcs
        static void GerarPreco(float preco, string nomeProduto, float imposto)//declarar parametros: func(tipo nome), quantos quiser.
        {
            float precoAbs = Math.Abs(preco); //abs pega o modulo, tira o - caso o usuario coloque
            float impostoTotal = (imposto/100f) * precoAbs;
            float precoTotal = precoAbs + impostoTotal;
            Console.WriteLine("O preço total do(a)" + nomeProduto + " Banana com imposto é de: R$ " + precoTotal);
            //variaveis criadas dentro de funçoes, só podem ser acessadas dentro dessa mesma função  
        }

        static int Somar(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }
    }
}
