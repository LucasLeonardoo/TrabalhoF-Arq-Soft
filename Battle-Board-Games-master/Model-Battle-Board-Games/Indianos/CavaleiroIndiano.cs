using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoardGame.Model
{
    class CavaleiroIndiano : Cavaleiro
    {
        public CavaleiroIndiano() : base("Cavaleiro Indiano")
        {
            this.Imagem = "https://st2.depositphotos.com/1874273/11984/v/950/depositphotos_119843150-stock-illustration-vector-indian-on-horseback-cartoon.jpg";
        }
    }
}
