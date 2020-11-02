using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class E_Mut : Gods
    {
        //field
        //prop
        public bool IsWrathful { get; set; }

        // ctor
        public E_Mut(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWrathful) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWrathful = isWrathful;
        }
        public E_Mut()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "The Mother Goddess: Mut";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "A primal deity who wears two crowns on her head, each representing Upper and Lower Egypt.";
            IsWrathful= false;
        }
        //method
        public override string ToString()
        {
            return base.ToString() + (IsWrathful ? "Wrath of any goddess is no small encounter, Take Caution." : "Bask in the presence of the Goddess before you");
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
