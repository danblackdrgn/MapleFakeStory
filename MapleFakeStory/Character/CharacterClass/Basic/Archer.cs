using Interface;
using Interface.MonsterDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.Character.CharacterClass.Basic
{
    public class Archer : ICharacter
    {
        // Character methods

        public string Attack(Monster Enemy)
        {
            return "Archer ATTACK!";
        }

        public void Move()
        {
            Console.WriteLine("Move Archer!");
        }

        public int Sleep()
        {
            Console.WriteLine("sleeping zzzzz");
            return 1;
        }
        public ICharacter UpgradeClass(ICharacter Character)
        {
            // validation logic
            return Character;
        }

        // Archer Methods


    }
}
