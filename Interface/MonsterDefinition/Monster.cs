using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.MonsterDefinition
{
    public abstract class Monster
    {
        public int Health;
        public string Attack;
        private int MoveSteps;

        public Monster(int _health, string _attack, int _moveSteps) 
        {
            this.Health = _health;
            this.Attack = _attack;
            this.MoveSteps = _moveSteps;
        }

        public abstract bool Defense();
        public abstract string AttackObjective(String CharacterName);

        public string Move()
        {
            return this.MoveSteps + " steps moved forward";
        }
    }

}