using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheGodsLibrary
{
    public class Combat
    {
        //This class will not have fields, props, or any custom constructors. as it is just a warehouse for different methods
        public static void DoAttack(Character attacker, Character defender)
        {
            // get a random # from 1-100 as our dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(100);
            if (diceRoll <= (attacker.CalcHitChange() - defender.CalcBlock()))
            {
                //if the attacker hit, calc damage
                int damageDealt = attacker.CalcDamage();
                //assign the damage
                defender.Life -= damageDealt;
                //Write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!\n", attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }
            else
            {
                //the attacker missed
                Console.WriteLine("{0} missed!\n", attacker.Name);
            }
        }

        public static void DoBattle(Player player, Gods Gods)
        {
            //player Attack first
            DoAttack(player, Gods);
            //if monster is still alive it attacks back!
            if (Gods.Life > 0)
            {
                DoAttack(Gods, player);
            }
        }//end DoBattle()


    }
}
