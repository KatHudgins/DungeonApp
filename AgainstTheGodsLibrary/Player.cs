using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public sealed class Player : Character
    {
        //This class(player) is now a child(derived) class of Character(parent/base class)
        //SEALED : the sealed keyword indicates that this class (player) cannot be used as a base class for other classes. No more inheritance can occur.
        //fields
        //props- using auto props/no biz logic
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        //Ctors
        public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon)
        {
            //maxLife is required to be known before Life can be set, so we assign the MaxLife prop first. Any Time Biz logic is needed for a prop we set the necessary prop first
            MaxLife = maxLife;
            Name = name;
            Block = block;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            HitChance = hitChance;
        }
        //Methods : ToString(), CalcDamage(), CalcHitChance()
        public override string ToString()
        {
            return string.Format("*^*^ {0} ^*^*\n" +
                "Life: {1} of {2}\n" +
                "Weapon: {4}\n" +
                "Hit Chance: {3}\n" +
                "Block: {5}\n" +
                "Description: {6}\n",
                Name, Life, MaxLife, CalcHitChange(), EquippedWeapon, Block, CharacterRace);
        }
        public override int CalcDamage()
        {
            //return base.CalcDamage(); //returns 0, we don't want that
            Random rand = new Random();
            //Determine damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }
        public override int CalcHitChange()
        {
            return base.CalcHitChange() + EquippedWeapon.BonusHitChance;
        }


    }
}
