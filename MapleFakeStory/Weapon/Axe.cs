using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.Weapon
{
    public class Axe : IWeapon
    {
        public void BasicAttack()
        {
            Console.WriteLine("Axe normal attack!");
        }

        public void SpecialAttack()
        {
            Console.WriteLine("Axe Special attack!");
        }
    }
}
