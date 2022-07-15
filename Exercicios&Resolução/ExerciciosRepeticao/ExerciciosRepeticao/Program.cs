using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ex1
            //A diretora de uma escola precisa de um programa C# que exiba uma mensagem de
            //boas vindas para os 10 alunos novos, utilizando a estrutura Foreach exiba a mesma
            //mensagem para todos os alunos novos.

            //string[] alunos = { "Pedro", "Viktor", "Rafael", "Murillo", "Vitória", "Antonio", "Lucas", "Iran", "Well", "Mag" };

            //foreach (string aluno in alunos)
            //{
            //Console.WriteLine("Bem vindo " + aluno + "!");
            //}


            #endregion



            #region Ex2
            //Crie um programa C# usando as estruturas de repetição que contabilize a
            //velocidade de um carro de fórmula 1, sem ultrapassar o limite de 200 Km / h permitido
            //na pista, exiba uma mensagem no final informando que chegou no limite.


            //int limite = 200;

            //for (int i = 1; i <= limite; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == limite)
            //    {
            //        Console.WriteLine("LIMITE DE 200Km/h ATINGIDO!!!");
            //    }
            //}

            #endregion



            #region Ex3
            //Crie um programa C# que exiba para os clientes de um mercado que está aberto
            //sob a condição do seu horário de funcionamento das 7h às 17h após esse horário
            //exibir uma mensagem de que se encontra fechado e indicando o horário de
            //funcionamento deste estabelecimento.

            //int hora = 0;

            //while (hora <= 23)
            //{
            //    if (hora >= 7 && hora <= 17)
            //    {

            //        Console.WriteLine("=> " + hora + "h00 == O mercado está ABERTO!!!");  
            //    }
            //    else
            //    {
            //        Console.WriteLine(hora + "h00 == Estamos fechados...");
            //    }
            //    hora++;
            //}


            #endregion



            #region Ex4
            //Crie um programa C# que exiba um cardápio de uma pizzaria contando 10 sabores
            //de pizza, exiba na tela repetindo a frase: “ Temos o sabor: ” “Aproveite a refeição”
            //nos 10 sabores.


            //string[] sabores = { "Calabresa", "Portuguesa", "Marguerita", "Frango com catupiry", "Muçarela", "Napolitana" };

            //foreach (string sabor in sabores)
            //{
            //    Console.WriteLine("Temos o sabor: " + sabor + ". Aproveite a refeição!!!");
            //}

            #endregion


            #region Ex5
            //Utilizando as estruturas de repetição, crie um programa C# que Realize uma
            //Contagem regressiva de 1000 a 1 para que um foguete seja lançado ao espaço.

            //for (int i = 1000; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //    if (i == 0)
            //    {
            //        Console.WriteLine("O FOGUETE FOI LANÇADO!!!");
            //    }
            //}

            #endregion



            #region Ex6
            //Contagem inteligente
            //Usuario escolhe dois numeros, e é exibido a contagem de um até o outro

            //Console.WriteLine("CONTAGEM INTELIGENTE!!!");
            //Console.Write("Inicio: ");
            //int inicio = int.Parse(Console.ReadLine());
            //Console.Write("Fim: ");
            //int fim = int.Parse(Console.ReadLine());

            //if (inicio > fim)
            //{
            //    while (inicio >= fim)
            //    {
            //        Console.Write(inicio + "... ");
            //        inicio--;
            //    }
            //}
            //else if (inicio < fim) 
            //{
            //    while (inicio <= fim)
            //    {
            //        Console.Write(inicio + "... ");
            //        inicio++;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Os numeros são iguais!");
            //}


            #endregion


            #region Ex7
            //Melhor aluno da turma
            //Usuario insere o nome e a nota dos alunos e o código diz quem foi o melhor da turma

            int index = 0;
            float maiorNota = 0;
            string melhorAluno = "";

            Console.WriteLine("======================");
            Console.WriteLine("Escola Santa Paciência");
            Console.WriteLine("======================");

            Console.Write("Quantos alunos a turma tem?: ");
            int quant = int.Parse(Console.ReadLine());

            while (index < quant)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Aluno {index + 1}");
                Console.Write("Nome do aluno: ");
                string aluno = Console.ReadLine();

                Console.Write($"Nota de {aluno}: ");
                float nota = float.Parse(Console.ReadLine());

                if (nota > maiorNota)
                {
                    maiorNota = nota;
                    melhorAluno = aluno;
                }

                index++;
            }
            Console.WriteLine($"O melhor aluno foi o {melhorAluno}, que tirou {maiorNota}");

            #endregion

            Console.ReadLine();
        }
    }
}
