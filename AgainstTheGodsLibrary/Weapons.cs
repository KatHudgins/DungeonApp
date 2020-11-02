using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class Weapon
    {
        //durability
        //attack speed
        //range of attack - reach mechanism
        //isEnchanted


        //fields
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        //properties- list properties with any biz rules last in our listing of props
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //cannot be more than maxDamage and cannot be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    //This is the case where they tried to set the value outside our range.
                    _minDamage = 1;
                }
            }
        }
        //constructors
        //FQCTOR
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            //If you have ANY properties that have buisness rules based off other properties, set the other properties first.
            MaxDamage = maxDamage;
            //Since minDamage is based off of maxDamage we will set maxDamage first
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }
        public Weapon() { }

        //methods()
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit Chance: {3}%\t{4}\n",
                Name, MinDamage, MaxDamage, BonusHitChance,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }//end ToString()
    }//End class
}//End Namespace
