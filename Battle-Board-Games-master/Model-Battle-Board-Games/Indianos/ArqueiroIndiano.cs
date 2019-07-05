using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardGame.Model
{
    class ArqueiroIndiano : Arqueiro
    {
        public ArqueiroIndiano() : base("Arqueiro Indiano")
        {
            this.Imagem = "https://i.pinimg.com/originals/94/3c/73/943c736ec0ed4f1f07e31a09061cec31.jpg";
        }
    }
}
