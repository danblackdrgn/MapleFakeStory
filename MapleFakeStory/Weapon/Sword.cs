using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.Weapon
{
    public class Sword : IWeapon
    {
        public void BasicAttack()
        {
            Console.WriteLine("Sword Basic attack!");
        }

        public void SpecialAttack()
        {
            Console.WriteLine("Sword Special attack!");
        }
    }
}
