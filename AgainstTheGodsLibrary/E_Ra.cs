using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class E_Ra : Gods
    {
        //field
        //prop
        public bool IsWrathful { get; set; }

        // ctor
        public E_Ra(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWrathful) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWrathful = isWrathful;
        }
        public E_Ra()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "God of the Sun and Radiance : Ra";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Ra has a sun disk around his head and is believed to have created this world. Every sunrise and sunset were seen as a process of renewal. Portrayed as a falcon-headed god, he and Horus shared an association which led him to be known as the 'Horus of the Horizon'. Many ancient Egyptian gods were merged with Ra and many were created by him such as rival gods like Ptah, Isis and Apep.";
            IsWrathful = false;
        }
        //method
        public override string ToString()
        {
            return base.ToString() + (IsWrathful ? "The wrath of any God is no small encounter, Take Caution." : "Bask in the presence of 'The God of the Sun' which stands before you");
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
