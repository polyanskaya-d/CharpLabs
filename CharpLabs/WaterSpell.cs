// Специфікація: Spells/WaterSpell.cs
using System;
using BattleOfMages.Mages;
using CharpLabs;

namespace BattleOfMages.Spells
{
    public class WaterSpell : ISpell
    {
        public string Name => "Водяне Закляття";
        public int Damage => 25;

        public void Cast(Mage caster, Mage target)
        {
            Console.WriteLine($"{caster.Name} використовує {Name}!");
            target.Defend(Damage);
        }
    }
}
