using BattleBoardGame.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleBoardGame.Model
{
    class ArqueiroBrasileiro : Arqueiro
    {
        public ArqueiroBrasileiro() : base("Arqueiro Brasileiro")
        {
            this.Imagem = "https://i.ytimg.com/vi/BCWPJFlBD5c/hqdefault.jpg";
        }
    }
}
