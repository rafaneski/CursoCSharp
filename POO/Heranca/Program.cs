using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            //Agora como a class Aluno é filha da class Usuario, podemos acessar pela Aluno os campos declarados no Usuario
            aluno.nome = "Rafael";
            aluno.email = "rafa@udemy.com";
            aluno.senha = "123";

            //alem disso podemos acessar os campos exclusivos da class Aluno
            aluno.turno = "Norturno";

            //tambem podemos acessar o metodo da class Usuario pela class filha Aluno:
            aluno.Exibir();

            //O Filho herda do Pai, mas o Pai nao herda do Filho.

            //Podemos ter outras class e fazer elas herdarem de um Pai
            Zelador zelador = new Zelador();
            zelador.nome = "José";
            zelador.email = "jose@udemy.com";
            zelador.senha = "senha";

            zelador.Exibir();

            //heranca evita principalmente repeticao de codigo. 

            Usuario u = new Aluno(); //polimorfismo de herança
            Console.WriteLine(((Aluno)u).turno); //cast 

            Console.ReadKey();
        }
    }
}
