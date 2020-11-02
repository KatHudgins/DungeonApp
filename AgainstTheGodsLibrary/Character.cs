using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    //Abstract modifier can be seen in some class signatures - This details that the class or object is not complete without futher implementation. This modifier can also be used with () or props.
    //Use the abstract modifier in a class delcaration to indicate that the class is only intended to be a base (parent) class of other classes.
    public abstract class Character
    {
        //This class will serve as a base class that Monster and Player (derived classes) will inherit from in the overall program. Inheritance allows for maximum reuse of functionality in our code.
        //In this class, we name all of the shared fields/props between player and monster.
        //Fields
        private int _life;
        //Props
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public int Life
        {
            get
            {
                return _life;
            }
            set
            {
                //check that life is less than or equal to MaxLife
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }
        //Ctors
        //Since we don't inherit Ctors and we will never be allowed to creat a type Character, we will define any ctors in the Player and Monster classes. We will still get the default Ctor since we have not defined it. However, we will not be able to use this because of the abstract keyword used above
        //Methods
        //Below are methods we want to be inherited by Player and Monster. So, we are creating default versions of each method here.
        public virtual int CalcBlock()
        {
            //Virtual : To be able to override this in a child class, make it virtual
            //This basic version just returns block, but this will give us the option to do something different in child classes.
            return Block;
        }
        //Calculate the hitChance
        public virtual int CalcHitChange()
        {
            return HitChance;
        }
        //Make calcDamage() and return 0
        public virtual int CalcDamage()
        {
            return 0; // we will override this in monster and player
        }

    }
}
