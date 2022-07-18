using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstração
{
    internal class Celular
    {
        public string nome;
        public string marca;
        public int ano;
        public string modelo;
        public int quantCameras;
        public string cor;
        public string tipoEntrada;
        public string processador;
        List<string> acessorios = new List<string>();
    }
}
