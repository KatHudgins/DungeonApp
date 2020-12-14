using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class E_Hathor : Gods
    {
        //field
        //prop
        public bool IsWrathful { get; set; }

        // ctor
        public E_Hathor(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWrathful) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWrathful = isWrathful;
        }
        public E_Hathor()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "The Goddess of Motherhood: Hathor";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Sometimes called the Mistress of the West, Hathor welcomed the dead";
            IsWrathful = false;
        }
        //method
        public override string ToString()
        {
            return base.ToString() + (IsWrathful ? "The wrath of any God is no small encounter, Take Caution." : "Before you is 'The Divine Embalmer'. Are you at ease?");
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsWrathful)
            {
                calculatedBlock += calculatedBlock / 4;
            }

            return calculatedBlock;
        }
    }
}
