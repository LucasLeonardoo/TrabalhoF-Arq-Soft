using BattleBoardGame.Model;
using BattleBoardGame.Model.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleBoardGame.Model.Factory
{
    class FactoryExercitoEgito : AbstractFactoryExercito
    {
        public override Arqueiro CriarArqueiro()
        {
            return new ArqueiroIndiano();
        }

        public override Cavaleiro CriarCavalaria()
        {
            return new CavaleiroIndiano();
        }

        public override Guerreiro CriarGuerreiro()
        {
            return new GuerreiroIndiano();
        }
    }
}
