// Специфікація: Spells/FireSpell.cs
using System;
using BattleOfMages.Mages;
using CharpLabs;

namespace BattleOfMages.Spells
{
    public class FireSpell : ISpell
    {
        public string Name => "Вогняне Закляття";
        public int Damage => 30;

        public void Cast(Mage caster, Mage target)
        {
            Console.WriteLine($"{caster.Name} використовує {Name}!");
            target.Defend(Damage);
        }
    }
}
