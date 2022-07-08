using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class Program
    {
        enum Cor { Azul, Verde = 22, Vermelho }; //quando cria enum, só pode trabalhar com esses valores 
        //enum tem esse numero de enumerador por que no fundo, todos esses valores colocados nele tem um valor numerico
        // voce pode escolher o valor numerico (como fiz com o verde), mas na maioria das situações nao será necessário

        enum Opcao { Criar = 1, Deletar, Editar};
        //se o criar for 1, os proximos vao mudar seus valores para continuar em ordem

        static void Main(string[] args)
        {
            //listas
            #region
            //string[] produtos = new string[3]
            //{
            //    "FIFA",
            //    "Enter the gungeon",
            //    "Vampirers survival"
            //};
            //int[] valores = { 40, 34, 12, 1 };
            #endregion

            //switch
            #region
            //string cor;

            //Console.WriteLine("Qual a sua favorita?: ");
            //cor = Console.ReadLine().ToLower();

            //switch (cor)
            //{
            //    case "vermelho":
            //        Console.WriteLine("A MINHA TAMBEM *0*");
            //        break;

            //    case "azul":
            //        Console.WriteLine("Sabia que a maioria das pessoas tem essa cor como fav?");
            //        break;

            //    case "verde":
            //        Console.WriteLine("Essa é pra poucos :o");
            //        break;

            //    default:
            //        Console.WriteLine("Que legal! Sua cor favorita é o " + cor + " !");
            //        break;
            //}
            #endregion

            //enum
            #region
            //O enum é uma forma de criar um tipo para conjuntos limitados de dados. 
            //existem várias formas de criar um tipo ex: classes, strugs, mas o enum é mto simples

            //enum significa enumeração. Quando é construido um enum, é construido um novo tipo de dado que
            //tem um conjunto limitado de valores. 

            //enum é mto utilizado principalmente com switchs para criar menus. 

            //Cor corFavorita = Cor.Vermelho;
            //Cor corFavoritaDoJao = Cor.Azul;
            //Console.WriteLine(corFavorita);
            //Console.WriteLine(corFavoritaDoJao);

            //cast = converter um tipo para outro
            // Converter valor enum para um numero:
            //Cor cor = Cor.Verde;
            //Console.WriteLine((int)cor);

            //Converter numero para um valor enum
            //Console.WriteLine((Cor)0);
            #endregion

            //enum & switch
            #region

            //Console.WriteLine("Selecione uma das opções abaixo: ");
            //Console.WriteLine("1-Criar\n2-Deletar\n3-Editar");
            //int index = int.Parse(Console.ReadLine());
            //Opcao opcaoSelecionada = (Opcao)index;

            //switch (opcaoSelecionada)
            //{
            //    case Opcao.Criar:
            //        Console.WriteLine("Você quer criar");
            //        break;

            //    case Opcao.Deletar:
            //        Console.WriteLine("Você quer deletar");
            //        break;

            //    case Opcao.Editar:
            //        Console.WriteLine("Você quer editar");
            //        break;

            //    default:
            //        break;
            //}


            #endregion




            //ESTRUTURAS DE REPETIÇÃO: 

            //while
            #region
            //while é como o if, mas enquanto for verdadeira ele continua repetindo, ate a condicao for falsa
            //while = enquanto for verdade, faça

            //int contador = 0;

            //while (contador < 10)
            //{
            //    contador++;
            //    Console.WriteLine(contador);
            //}


            #endregion

            //Do while
            #region
            //é igual o while mas com um adicional: mesmo se for mentira, uma vez ela irá executar.

            //isso ocorre pois primeiro roda o bloco de códigos dentro do while, e depois ela confere se a
            //condicao e verdadeira, se for verdadeira roda novamente, se for mentira para. Mas já tera rodado 
            //pelo menos uma vez.

            //do
            //{
            //    Console.WriteLine("Fez o while!");
            //} while (100000 < 10);

            //int contador2 = 0;
            //do
            //{
            //    Console.WriteLine("do while! " + contador2);
            //    contador2++;
            //} while (contador2 < 10);

            #endregion

            //foreach
            #region
            // foreach é a maneira mais facil de percorrer um array

            //string[] palavras = { "Carro", "Programar", "Dor", "Peixe" };

            //foreach(string palavra in palavras) //Para cada palavra no array palavras, faça
            //{
            //    //var palavra vai  receber cada elemento dentro do array palavras e printar
            //    Console.WriteLine(palavra);
            //}

            //utilidade: processar cada item dentro do array separadamente


            #endregion

            //for
            #region

            //for é dividido em 3 partes: for(index, condicao, incremento)
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Rodando! " + i);
            //}


            //for é interessante tambem para arrays (por mais que o foreach seja melhor):

            //string[] jogos = { "Dota", "CS", "Enter the gungeon", "Moonlight", "BeatCop", "Darkest Dungeon" };

            //for (int i = 0; i < jogos.Length; i++)
            //{
            //    Console.WriteLine(jogos[i]);
            //}

            //pegar a lista de tras para frente
            //for (int i = jogos.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(jogos[i]);
            //}

            #endregion

            //escopo = local onde uma determinada variavel vai funcionar. variaveis locais e globais
            //variaveis declaradas dentro de funções se tornam variaveis locais e só podem ser utilizadas dentro da mesma função

            //variaveis declaradas fora das funções, mais preicsamente nas classes, sao variaveis globais e podem ser utilizadas em qualquer função


            Console.ReadLine();
        }
    }
}
