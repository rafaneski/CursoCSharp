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
            // 1 - Usando os conhecimentos e conceitos passados nas aulas anteriores sobre abstracao,
            //abstraia e crie classes C# para cada um dos contextos abaixo:
            //a) Produto para e-commerce de celulares
            //b) Jogo para loja virtual de games
            //c) Pedido para sistema de restaurante
            //d) Personagem para jogo RPG
            //e) imovel para sistema de aluguel

            //Resolucao:

            #region Celular
            Celular celular = new Celular();
            celular.nome = "Samsung Galaxy A30s ";
            celular.marca = "Samsung";
            celular.ano = 2019;
            celular.quantCameras = 3;
            #endregion


            #region Jogo
            Jogo starcraft2 = new Jogo();
            starcraft2.nome = "StarCraft 2";
            starcraft2.estudio = "Blizzard";
            starcraft2.genero = "RTS";
            starcraft2.ano = 2010;

            Jogo lol = new Jogo();
            lol.nome = "League of Legends";
            lol.estudio = "Riot Games";
            lol.genero = "Moba";
            lol.ano = 2009;
            #endregion


            #region Pedido
            Pedido pedido = new Pedido();
            pedido.nomePrato = "Sushi";
            pedido.bebida = "Coca";
            pedido.sobremesa = "Pudim";
            pedido.quantPessoas = 4;
            #endregion


            #region Personagem
            Personagem orc = new Personagem();
            orc.nome = "Maghar";
            orc.raca = "Orc";
            orc.genero = "Masculino";
            orc.idade = 23;
            orc.montaria = "Javali";
            orc.acessorio = "Chapeu";
            #endregion


            #region Imovel
            Imovel casa = new Imovel();
            casa.garagens = 1;
            casa.quartos = 2;
            casa.andares = 1;
            casa.banheiros = 2;
            casa.cidade = "Mogi das Cruzes";
            casa.tipoChuveiro = "À GÁS";
            #endregion

        }
    }
}
