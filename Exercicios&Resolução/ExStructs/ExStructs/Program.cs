using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStructs
{
    internal class Program
    {
        //CRIAR UM COMPARADOR DE PRODUTOS. 
        //O CÓDIGO VAI RECEBER OS PRODUTOS E DIZER QUAL O MAIS CARO!
        public struct Produto
        {
            public string nome;
            public float preço;

            public Produto(string nome, float preço)
            {
                this.nome = nome;
                this.preço = preço;
            }

            public void Gestor()
            {
                Console.Write("Nome: ");
                this.nome = Console.ReadLine();

                Console.Write("Preço: ");
                this.preço = float.Parse(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            int index = 0;
            float maiorPreço = 0;
            string nomeMaior = "";

            Console.Write("Quantos produtos você quer comparar?: ");
            int maximo = int.Parse(Console.ReadLine());

            while (index < maximo)
            {
                Console.WriteLine("---------------------");

                Produto produto = new Produto();
                Console.WriteLine($"Produto {index + 1} ");
                Console.Write("Nome: ");
                produto.nome = Console.ReadLine();

                Console.Write($"Preço de {produto.nome} R$ ");
                produto.preço = float.Parse(Console.ReadLine());

                index++;

                if (produto.preço > maiorPreço)
                {
                    maiorPreço = produto.preço;
                    nomeMaior = produto.nome;
                }
            }
            Console.WriteLine($"\nO produto mais caro é o {nomeMaior} custando R$ {maiorPreço}");

            Console.ReadLine();
        }
    }
}
