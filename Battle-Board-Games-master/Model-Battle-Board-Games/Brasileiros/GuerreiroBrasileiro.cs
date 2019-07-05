using BattleBoardGame.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleBoardGame.Model
{
    class GuerreiroBrasileiro : Guerreiro
    {
        public GuerreiroBrasileiro() : base("Guerreiro Brasileiro")
        {
            this.Imagem = "https://www.mitografias.com.br/wp-content/uploads/2018/04/Aviso-introducao_folclore.jpg";
        }
    }
}
