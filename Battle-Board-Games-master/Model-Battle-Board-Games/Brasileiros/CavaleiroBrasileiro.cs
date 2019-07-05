using BattleBoardGame.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleBoardGame.Model
{
    class CavaleiroBrasileiro : Cavaleiro
    {
        public CavaleiroBrasileiro() : base("Cavaleiro Brasileiro")
        {
            this.Imagem = "https://i.pinimg.com/736x/bc/c3/0c/bcc30c7dc08ffa82a17e7fa6aaa6ebb7.jpg";
        }
    }
}
