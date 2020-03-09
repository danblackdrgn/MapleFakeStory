using Interface.MonsterDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IArcher
    {
        string TrackEnemy(Monster KindEnemy);
        void FirstAid(ICharacter Ally);
    }
}
