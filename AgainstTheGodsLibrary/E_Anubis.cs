using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class E_Anubis : Gods
    {
        //field
        //prop
        public bool IsWrathful { get; set; }

        // ctor
        public E_Anubis(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWrathful) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWrathful = isWrathful;
        }
        public E_Anubis()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "The Divine Embalmer: Anubis";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Anubis patrolled the Underworld before Osiris took over. He was a 'psychopomp' or deity who assists in the afterlife, and was the offspring of Ra and Nephthys. He was know for mummifying the dead and guiding their souls towards the afterlife. With the head of a jackal and the body of a man, Anubis also stood for renaissance and the staining of dead bodies after the embalming process.";
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
