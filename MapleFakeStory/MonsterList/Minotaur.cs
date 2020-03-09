using Interface;
using Interface.MonsterDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.MonsterList
{
    public class Minotaur : Monster
    {

        public Minotaur () : base (150, "15", 3)
        {

        }
        public override string AttackObjective(string CharacterName)
        {
            throw new NotImplementedException();
        }

        public override bool Defense()
        {
            throw new NotImplementedException();
        }
    }
}
