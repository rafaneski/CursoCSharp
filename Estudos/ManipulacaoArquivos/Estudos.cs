using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Estudando
{
    internal class Program
    {
        [System.Serializable] //precisamos disso para salvar nossos tipos customizados em arquivos binários
        struct Produto
        {
            public string nome;
            public float preco;
        }

        //Se for copiar e colar o código para estudar, comente as regions que não estiver estudando para não dar erros. Sempre compile 3 regions e estude uma.

        static void Main(string[] args)
        {
            #region Escrita de arquivos de texto
            //Criar o fluxo de informações:

            StreamWriter escritor = new StreamWriter("teste.txt");

            //Mandar informações para esse arquivo:

            escritor.WriteLine("Teste");

            //Fechar o fluxo de informações: 

            escritor.Close();
            //Você PRECISA fechar o fluxo de informações.

            //Adicionar novas informações sem perder as anteriores:
            StreamWriter escritor = File.AppendText("text.txt");

            //Sempre quando é criado um new StreamWriter, o c# apaga tudo o que tinha naquele arquivo.
            //Para ele não apagar e você conseguir adicionar novas informações, você pode usar o Append.
            #endregion




            #region Leitura de arquivos de texto
            //Para ler arquivos de texto voce deve trabalhar com o StreamReader:
            StreamReader leitor = new StreamReader("teste.txt");

            //Opções de leitura:
            string conteudo = leitor.ReadToEnd(); //vai ler o arquivo até o final e salvar todo o conteudo em uma string.
            Console.WriteLine(conteudo);
            //ATENCAO: Todo o conteudo do arquivo se torna UMA UNICA STRING!!! 
            //Em muitos casos o ReadToEnd é ruim. 

            //Para ler linha por linha, nós vamos utilizar estruturas de repetição.

            string linha = "";

            while (linha != null) //vai rodar todo o programa, até o final quando der == null.
            {
                linha = leitor.ReadLine();
                if (linha != null)
                {
                    Console.WriteLine(linha); //só vai printar a linha que tiver conteudo
                }
            }


            //Utilidade: Salvar cada linha do seu programa dentro de uma lista: 
            List<string> linhas = new List<string>();

            string linha = "";

            while (linha != null) 
            {
                linha = leitor.ReadLine();
                if (linha != null)
                {
                    linhas.Add(linha); //esta guardando cada linha dentro da lista linhas
                }
            }

            Console.WriteLine(linhas[2]); //podemos agora acessar a linha que quisermos 


            foreach (string nome in linhas) //com o foreach podemos ver que a lista foi criada com sucesso
            {
                Console.WriteLine(nome); //exibindo cada linha dentro da lista linhas 
            }

            //LEMBRE-SE!!!!: ASSIM COMO NO StreamReader, no leitor você deve fecha-lo!!!!!:::
            leitor.Close();

            #endregion





            #region Escrita de arquivos binários
            //Diferença na pratica: 
            //Nos arquivos de texto você pega qualquer tipo de dado, converte para string e coloca no arquivo
            //Nos arquivos binários você mantém o tipo de dado. 

            //Os arquivos binários são uteis para quando você quer salvar literalmente uma variavel crua dentro deles.

            //escrever em arquivos binários:
            FileStream stream = new FileStream("texte.rafa", FileMode.OpenOrCreate);

            ////Para trabalhar com arquivos binários, primeiro temos que converter nossos dados em bytes. 
            ////os formatadores vão fazer essa conversão
            ////para usar o formatadores precisamos importar: using System.Runtime.Serialization.Formatters.Binary;
            ////Agora podemos passar valores diretamente:

            BinaryFormatter encoder = new BinaryFormatter();
            encoder.Serialize(stream, 120);
            encoder.Serialize(stream, "Rafael");
            encoder.Serialize(stream, true);

            //também podemos passar valores por variaveis
            int a = 120;
            string b = "Rafael";
            bool c = true;

            encoder.Serialize(stream, a);
            encoder.Serialize(stream, b);
            encoder.Serialize(stream, c);

            ////Com os arquivos binários nós temos a possibilidade de salvar listas inteiras de dados.
            List<string> langs = new List<string>();
            langs.Add("C#");
            langs.Add("Javascript");
            langs.Add("PHP");

            encoder.Serialize(stream, langs);

            //Também podemos salvar nossos tipos customizados
            Produto banana = new Produto();
            banana.nome = "Banana";
            banana.preco = 1f;

            encoder.Serialize(stream, banana);

            stream.Close();

            #endregion





            #region Leitura de arquivos binários
            //Diferentemente da leitura de arquivos de texto, não precisamos mudar nada, mantenha: 
            FileStream stream = new FileStream("texte.rafa", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            List<string> langs = new List<string>();
            langs.Add("C#");
            langs.Add("Javascript");
            langs.Add("PHP");

            Produto banana = new Produto();
            banana.nome = "Banana";
            banana.preco = 1f;

            //comente isso depois de escrever o arquivo e antes de fazer a leitura
            encoder.Serialize(stream, langs);
            encoder.Serialize(stream, banana);

            //problema: Para ler um arquivo binário você deve saber exatamente o que tem. 
            //além disso deve saber linha a linha o que tem.

            //ex: o arquivo começa com uma lista:
            List<string> listaDoArquivo = (List<string>)encoder.Deserialize(stream);

            //e depois um produto: 
            Produto prod = (Produto)encoder.Deserialize(stream);

            Console.WriteLine(listaDoArquivo[0]);
            Console.WriteLine(prod.nome);

            Console.WriteLine("Arquivo gerado!");
            
            stream.Close();

            Console.ReadLine();
            #endregion
        }
    }
}
