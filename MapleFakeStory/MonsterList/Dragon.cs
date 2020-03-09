using Interface;
using Interface.MonsterDefinition;
using MapleFakeStory.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.MonsterList
{
    public class Dragon : Monster
    {
        public Dragon () : base (1500, "100", 10) 
        { 

        }
        public override string AttackObjective(String CharacterName)
        {
            return "Dragon Attacking... " + CharacterName;
        }

        public override bool Defense()
        {
            return false;
        }
    }
}
