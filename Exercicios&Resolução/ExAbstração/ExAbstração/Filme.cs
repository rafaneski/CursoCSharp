using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstração
{
    internal class Filme
    {
        public string nome;
        public string sinopse;
        public int ano;
        public string estudio;
        public List<string> elenco = new List<string>();

        public void Play()
        {
            Console.WriteLine("Rodando filme: " + nome);
        }

        public void Pausar()
        {
            Console.WriteLine("Filme pausado");
        }
    }
}
