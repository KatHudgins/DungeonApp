using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class E_Thoth : Gods
    {
        //field
        //prop
        public bool IsWrathful { get; set; }

        // ctor
        public E_Thoth(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWrathful) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWrathful = isWrathful;
        }
        public E_Thoth()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "The God of Knowledge and Wisdom: Thoth";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "An arbitrator who settled the dispiutes between good and evil, Thoth is considered a self-created God. Master of both physical and divine laws, along with his counterpart 'Ma'at', He maintained the universe by his mastery of calculations. The ancient Egyptians acknowledged him as an author of Science, Philosophy, and Magic. Thoth was also regarded as the Moon God for keeping count of time even when the sun was not there, and is recognized as the one who created the 365-day calendar.";
            IsWrathful = false;
        }
        //method
        public override string ToString()
        {
            return base.ToString() + (IsWrathful ? "The wrath of any God is no small encounter, Take Caution." : "Bask in the presence of 'The Hidden One' which stands before you");
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
