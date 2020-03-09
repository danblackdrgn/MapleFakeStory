using Interface.MonsterDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICharacter
    {
        string Attack(Monster Monster);
        void Move();
        int Sleep();
        ICharacter UpgradeClass(ICharacter Character);
    }
}
