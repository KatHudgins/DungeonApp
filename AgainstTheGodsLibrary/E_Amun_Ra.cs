using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class E_Amun_Ra : Gods
    {
        //field
        //prop
        public bool IsWrathful { get; set; }

        // ctor
        public E_Amun_Ra(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWrathful) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWrathful = isWrathful;
        }
        public E_Amun_Ra()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "The Hidden One: Amun-Ra";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Considered the King of the Gods and Goddesses. He became Amun-Ra after being amalgamated with the Sun God Ra. His female counterpart is Amunet. Amun, Mut and their son Khonsu(the Moon God) Formed the Theban Triad and were worshiped throughout Ancient Egypt";
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
