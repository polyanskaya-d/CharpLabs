// Специфікація: Mages/Mage.cs
using System;
using System.Collections.Generic;
using BattleOfMages.Spells;

namespace BattleOfMages.Mages
{
    public abstract class Mage
    {
        public string Name { get; private set; }
        public int Health { get; protected set; }
        public int MagicLevel { get; private set; }
        protected List<ISpell> Spells;

        public Mage(string name, int magicLevel)
        {
            Name = name;
            MagicLevel = magicLevel;
            Health = 100; // Початкове здоров'я
            Spells = new List<ISpell>();
        }

        public void Attack(Mage target)
        {
            if (Spells.Count > 0)
            {
                Random rand = new Random();
                ISpell spell = Spells[rand.Next(Spells.Count)];
                Console.WriteLine($"{Name} атакує {target.Name} з допомогою {spell.Name}");
                spell.Cast(this, target);
            }
            else
            {
                Console.WriteLine($"{Name} не має заклять для атаки.");
            }
        }

        public void Defend(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} отримує {damage} ушкоджень. Здоров'я: {Health}");
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public void LearnSpell(ISpell spell)
        {
            Spells.Add(spell);
        }
    }
}
