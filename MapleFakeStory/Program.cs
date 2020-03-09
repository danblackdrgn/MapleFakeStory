
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapleFakeStory.Character;
using MapleFakeStory.Character.CharacterClass.Basic;
using MapleFakeStory.MonsterList;
using MapleFakeStory.Weapon;

namespace MapleFakeStory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyCharacter character= new MyCharacter(new Warrior(), "Pedrito", "120", Faction.Demacia, "Shemale");
            character.weaponSelectedObject = new Axe();
            Dragon dragon = new Dragon();
            Console.WriteLine(dragon.Move());
            Console.WriteLine(character.Attack(dragon));
            Console.WriteLine(dragon.AttackObjective(character.name));
            Console.ReadLine();
        }
    }
}
