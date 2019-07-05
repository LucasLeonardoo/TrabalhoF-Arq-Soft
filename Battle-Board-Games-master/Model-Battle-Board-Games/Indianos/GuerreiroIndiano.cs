using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardGame.Model
{
    class GuerreiroIndiano : Guerreiro
    {
        public GuerreiroIndiano() : base("Guerreiro Indiano")
        {
            this.Imagem = "https://image.freepik.com/vetores-gratis/guerreiro-indiano-pronto-para-a-guerra_84382-86.jpg";
        }
    }
}
