using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardGame.Model
{
    class CavaleiroPersa : Cavaleiro
    {
        public CavaleiroPersa() : base("Cavaleiro Persa")
        {
            this.Imagem = "https://tormentopabulum.files.wordpress.com/2016/04/ff37d-se.jpg?w=362&h=444";
        }
    }
}
