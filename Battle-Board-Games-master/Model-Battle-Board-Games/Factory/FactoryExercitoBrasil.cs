using System;
using System.Collections.Generic;
using System.Text;

namespace BattleBoardGame.Model.Factory
{
    class FactoryExercitoBrasil : AbstractFactoryExercito
    {
        public override Arqueiro CriarArqueiro()
        {
            return new ArqueiroBrasileiro();
        }

        public override Cavaleiro CriarCavalaria()
        {
            return new CavaleiroBrasileiro();
        }

        public override Guerreiro CriarGuerreiro()
        {
            return new GuerreiroBrasileiro();
        }
    }
}
