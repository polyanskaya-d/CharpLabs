// Специфікація: Game.cs
using System;
using BattleOfMages.Mages;

namespace BattleOfMages
{
    public class Game
    {
        private Mage mage1;
        private Mage mage2;

        public Game(Mage mage1, Mage mage2)
        {
            this.mage1 = mage1;
            this.mage2 = mage2;
        }

        public void StartBattle()
        {
            Console.WriteLine("Битва починається!");

            while (mage1.IsAlive() && mage2.IsAlive())
            {
                mage1.Attack(mage2);
                if (!mage2.IsAlive()) break;

                mage2.Attack(mage1);
                if (!mage1.IsAlive()) break;

                Console.WriteLine("-------------------------");
            }

            if (mage1.IsAlive())
            {
                Console.WriteLine($"{mage1.Name} переміг!");
            }
            else if (mage2.IsAlive())
            {
                Console.WriteLine($"{mage2.Name} переміг!");
            }
            else
            {
                Console.WriteLine("Нічия!");
            }
        }
    }
}
