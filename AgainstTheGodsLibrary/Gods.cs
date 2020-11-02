using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class Gods : Character
    {
        //fields - since we will have a biz rule on minDamage, we must create a full field and prop for that value.
        private int _minDamage;
        //props - auto props first (no biz rules first)
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get
            {
                return _minDamage;
            }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = 1;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        //ctor
        public Gods() { }
        public Gods(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            MaxLife = maxLife;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            Description = description;
        }
        //Methods
        public override string ToString()
        {
            return string.Format("\n^*^* Monster *^*^\n" +
                "{0}\n" +
                "Life: {1} of {2}\n" +
                "Damage: {3} to {4}\n" +
                "Block: {5}\n" +
                "Description: \n" +
                "{6}",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }
        //We are overriding the CalcDamage to use minDamage and maxDamage props
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
            //we add 1 to Max Damage to include the top possibility of Damage
        }
    }
}
