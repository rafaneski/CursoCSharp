using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoStructs
{
    internal class Program
    {
        //Structs: Uma forma de criar novos tipos no C#. Um novo tipo customizado. 
        //Structs são uteis para colocar varias variaveis dentro de uma. 

        //Criar Structs: 
        //Em qualquer lugar do código, fora de qualquer função: 
        struct Produto
        {
            public string nome;  //Criei um tipo chamado Produto e ele tem um campo chamado nome. 
            public float peso;
            public float preço;
            public string marca;
            //o tipo produto armazena 4 informações.

            //construtor: 
            public Produto(string nome, float peso, float preço, string marca)
            {
                //nome = nome; da pra fazer 
                this.nome = nome; //var do atributo recebe var do parametro
                //REGRA: Obrigatóriamente você deve definir os valores de todos os campos do construtor.
                this.peso = peso;
                this.preço = preço;
                this.marca = marca;
                //está criado o construct

                Exemplo(); //-> REGRA: No construct uma função deve ser chamada abaixo das definições do construct
            }

            //funções em structs
            public void ExibirInfos()
            {
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"Peso: {this.peso} Kg");
                Console.WriteLine($"Preço: R$ {this.preço}");
                Console.WriteLine($"Marca: {this.marca}");
            }

            //função com parâmetro
            //public void AdicionarCupom(float porc)
            //{
            //    float desconto = this.preço * porc / 100f;
            //    Console.WriteLine(this.preço - desconto);
            //}

            //função com parâmetro e return
            public float AdicionarCupom(float porc)
            {
                float desconto = this.preço * porc / 100f;
                return this.preço - desconto;
            }

            //voce pode criar uma funcao no struct e chama-la em qualquer lugar da struct
            public void Exemplo()
            {
                Console.WriteLine("TESTE");
            }
        }


        static void Main(string[] args)
        {
            //Criar variavel com o tipo criado:
            //Produto bola = new Produto(); //a sintaxe new produto() faz o c# criar um objeto do tipo produto e salva dentro da variavel bola.

            //Usar a variavel criada:
            //O public é um modificador de acesso que permite qualquer parte do código acessar os atributos.
            //bola.nome = "Bola do Ronaldinho";
            //bola.peso = 1f;
            //bola.preço = 14f;
            //bola.marca = "Nike";

            //Agora podemos trabalhar com esses campos como se fosse qualquer outra variavel
            //Console.WriteLine(bola.nome);
            //Console.ReadLine();

            //E podemos criar outros Produtos para nosso Struct Produto: 
            //Produto balde = new Produto();
            //balde.nome = "Baldinho";
            //balde.peso = 10f;
            //balde.preço = 5f;
            //balde.marca = "????";

            //Declarar cada campo do nosso struct manualmente é chato e cansativo, para isso existem os construtores.

            //O construtor é basicamente uma função que é executada no momento da criação da sua estrutura
            //Vamos passar as informações como se fossem parâmetros.

            //com o construct feito lá no nosso struct nós podemos simplesmente:
            Produto bola = new Produto("Bola do ronaldinho", 1f, 12f, "Nike");
            Produto balde = new Produto("Balde legal", 2f, 6f, "????");
            Produto mouse = new Produto("Mouse", 1f, 22f, "Bright");

            //Console.WriteLine(bola.nome);
            //Console.WriteLine(balde.preço);
            //Console.WriteLine(mouse.marca);

            bola.ExibirInfos(); //pegue os campos da var bola e exiba no console
            Console.WriteLine("=======================");
            balde.ExibirInfos();
            Console.WriteLine("=======================");
            mouse.ExibirInfos();

            float valorFinal = bola.AdicionarCupom(30f);
            balde.AdicionarCupom(30f);
            mouse.AdicionarCupom(30f);

            Console.WriteLine(valorFinal);


            Console.ReadLine();
        }
    }
}
