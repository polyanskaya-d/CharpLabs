// Специфікація: Mages/WaterMage.cs
using BattleOfMages.Spells;

namespace BattleOfMages.Mages
{
    public class WaterMage : Mage
    {
        public WaterMage(string name, int magicLevel) : base(name, magicLevel)
        {
            LearnSpell(new WaterSpell());
        }
    }
}
