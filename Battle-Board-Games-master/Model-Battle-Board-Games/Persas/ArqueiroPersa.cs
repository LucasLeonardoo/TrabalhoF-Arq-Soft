using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardGame.Model
{
    class ArqueiroPersa : Arqueiro
    {

        public ArqueiroPersa() : base("Arqueiro Persa")
        {
            this.Imagem = "http://static.xs-software.com/help/khanwars/thumbs/Kamangir.png";
        }
    }
}
