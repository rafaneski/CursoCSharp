namespace POO
{
    //NUNCA CRIE MAIS DE 1 CLASSE EM UM ARQUIVO, VOU FAZER ISSO SO PARA FICAR FACIL DE ENTENDER

    //Encapsulamento: Capacidade de esconder detalhes da implementacao do objeto, expondo
    //somente so o que deve ser acessado publicamente.
    //A vantagem eh a seguranca. 
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme();
            filme.AddAtor("Brad Pitt");
            filme.AddAtor(null); //Vai faze a validacao e nao vai add null na lista
            filme.AddAtor("Tom Cruise");
            filme.AddAtor("Gyu");
            filme.ExibirAtores();
        }
    }

    class Filme
    {
        public string nome;
        private List<string> Atores = new List<string>();
        //METODO ENCAPSULADOR: Metodo publico que manipula informacao privada
        public void AddAtor(string nome) //metodo encapsulador
        {
            //voce pode colocar validacoes
            if (nome != null) 
            {
                if (nome.Length > 4)
                {
                    Atores.Add(nome); 
                }
            }
        }

        public void ExibirAtores() //metodo encapsulador
        {
            foreach (string ator in Atores)
            {
                Console.WriteLine(ator);
            }
            Console.ReadKey();
        }
    }
}
