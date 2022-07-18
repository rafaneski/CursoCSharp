using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme thor = new Filme();
            thor.nome = "Thor Love and Thunder";
            thor.estudio = "Marvel";
            thor.Play();

            Console.ReadLine();
        }
    }
}
