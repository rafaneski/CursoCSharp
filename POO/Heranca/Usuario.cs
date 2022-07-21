using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //NUNCA CRIE MAIS DE 1 CLASSE EM UM ARQUIVO, VOU FAZER ISSO SO PARA FICAR FACIL DE ENTENDER
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        protected string teste; //protected funciona como o private, so que as classes filhos e pais podem acessa-lo
        //no caso do private, uma classe filho nao pode acessar, mesmo herdando do pai. 

        public void Logar()
        {
            Console.WriteLine("Logando...");
            Console.ReadKey();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Senha: {senha}");
            Console.WriteLine("===============");
        }        
    }

    class Aluno : Usuario //estou dizendo que a classs Aluno vai herdar a classe pai Usuario
    {
        //No C# soh pode ter 1 pai

        public List<string> turmas = new List<string>();
        public string turno = "Matutino";
        
        public void TestantoMod()
        {
            Console.WriteLine(teste); //acessei a var protected apartir de outra class.
        }
    }

    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();
    }
}
