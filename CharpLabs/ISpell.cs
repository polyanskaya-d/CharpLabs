// Специфікація: Spells/ISpell.cs
namespace BattleOfMages.Spells
{
    public interface ISpell
    {
        string Name { get; }
        int Damage { get; }
        void Cast(Mages.Mage caster, Mages.Mage target);
    }
}
