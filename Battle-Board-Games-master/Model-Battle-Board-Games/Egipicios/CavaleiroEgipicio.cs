using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardGame.Model
{
    class CavaleiroEgipicio : Cavaleiro
    {
        public CavaleiroEgipicio() : base("Cavaleiro Egípcio")
        {
            this.Imagem = "https://tormentopabulum.files.wordpress.com/2015/03/mamluk2.png?w=326&h=395";
        }
    }
}
