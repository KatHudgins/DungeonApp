using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class E_Horus : Gods
    {
        //field
        //prop
        public bool IsWrathful { get; set; }

        // ctor
        public E_Horus(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWrathful) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWrathful = isWrathful;
        }
        public E_Horus()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "The God of Vengeance: Horus";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Horus held a special position in ancient Egypt. As the child of 'Osiris' and 'Isis', He avenged his father's death and ruled Egypt. According to myth, he was also considered the child of 'Zeb' and 'Nut' and this falcon-headed god with a crown of red and white was worshiped as the God of Sky, War, Protection and Light. ";
            IsWrathful = false;
        }
        //method
        public override string ToString()
        {
            return base.ToString() + (IsWrathful ? "The wrath of any God is no small encounter, Take Caution." : "You are in the presence of 'The God of Vengeance', Horus stands before you");
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
