﻿using Interface;
using Interface.MonsterDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.Character.CharacterClass.Basic
{
    public class Mage : ICharacter
    {

        // Character Methods

        public string Attack(Monster Enemy)
        {
            return "Mage ATTACK!";
        }

        public void Move()
        {
            Console.WriteLine("Move Mage!");
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

    }
}
