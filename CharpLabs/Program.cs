// Специфікація: Program.cs
using System;
using BattleOfMages.Mages;

namespace BattleOfMages
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mage1 = new FireMage("Гендальф", 10);
            Mage mage2 = new WaterMage("Саруман", 12);

            Game game = new Game(mage1, mage2);
            game.StartBattle();

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
