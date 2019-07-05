using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardGame.Model
{
    class GuerreiroEgipicio : Guerreiro
    {

        public GuerreiroEgipicio() : base("Guerreiro Egípcio")
        {
            this.Imagem = "http://www.templodeapolo.net/imagens/figuras/templodeapolo.net_egyptian_warrior.jpg";
        }
    }
}
