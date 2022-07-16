using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Listas = arrays com super poderes

            //Criação de listas:
            List<string> clientes = new List<string>();

            //Adicionar elementos:
            clientes.Add("Pedro");
            clientes.Add("lima");

            //Acessar elementos:
            Console.WriteLine(clientes[0]);

            //Editar elementos:
            clientes[2] = "Ednaldo Pereira!";

            //Saber quantos elementos tem na lista:
            clientes.Count();

            //Remoção de elementos: 
            //Forma 1 simples:
            clientes.RemoveAt(1);

            //Forma 2 com predicado:
            //para cada elemento na lista, o c# vai pegar o predicado e testar. Se o predicado for true o elemento será removido
            int quant = clientes.RemoveAll(cliente => cliente == "José"); //retorna quantidade de itens removidos
            //A FORMA 2 É BEM MAIS PESADA QUE A FORMA 1
            //Em listas gigantes o removeall tem que percorrer varios itens e comparar. 



            //Filtragem e busca:
            //pegar elemento expecifico: 
            clientes.Find(cliente => cliente == "José");
            //mudando o predicado para fazer outras comparações:
            clientes.Find(cliente => cliente.Length > 4); //toda string tem um Length

            //Se o find não encontrar, ele retornará null

            //ATENÇÃO: O find funciona apenas com um elemento, o primeiro elemento que essa busca achar, ela já vai retornar.
            //se você quiser pesquisar tudo, vamos ter que usar o FindAll
            //ATENÇÃO: O FindAll retorna outra lista. 

            List<string> filtrada = clientes.FindAll(cliente => cliente.Length < 5);

            //o basico eh isso =)
        }
    }
}
