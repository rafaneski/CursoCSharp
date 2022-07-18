//Exemplo de classe, atributos e métodos:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//As classes, alem de servirem para separar o programa em blocos logicos, elas tambem servem para definir novos tipos
class Jogo //Classe
{
  public string titulo;  //Atributo
  public string genero; //Atributo
  public string produtora;  //Atributo
  public float preco; //Atributo
  
  public void Abrir() //Metodo
  {
    Console.WriteLine("Abrindo...");
  }
  
  public void Carregar()  //Metodo
  {
    Console.WriteLine("Carregando...");
  }
  
  public void Fechar()  //Metodo
  {
    Console.WriteLine("Aperte ESC para Sair!");
  }
}

//Funcoes dentro de classes sao chamadas de metodos.
