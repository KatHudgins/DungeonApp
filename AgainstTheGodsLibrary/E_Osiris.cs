using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class E_Osiris : Gods
    {
        //field
        //prop
        public bool IsWrathful { get; set; }

        // ctor
        public E_Osiris(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWrathful) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWrathful = isWrathful;
        }
        public E_Osiris()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "The King of the Living : Osiris";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Considered the oldest child of the Earth God : Zeb, and the Sky Goddess : Nut. Osiris was worshiped as the God of the AfterLife. He was the God of Vegetation which indicated renewal and growth and was thought to be responsible for the fertile flooding and vegetation around the banks of the Nile. Osiris married his sister Isis and was murdered by his brother Seth. However, Osiris was brought back to life by the magic of Isis to conceive a child, Horus. Horus avenged his father's death and arose as a new pharoah of Egypt while Osiris became the god of the Underworld and assisted in the AfterLife of the Pharaohs and the People...";
            IsWrathful = false;
        }
        //method
        public override string ToString()
        {
            return base.ToString() + (IsWrathful ? "The wrath of any God is no small encounter, Take Caution." : "Bask in the presence of 'The King of the Living' which stands before you");
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
