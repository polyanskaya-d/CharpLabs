// Специфікація: Mages/FireMage.cs
using BattleOfMages.Spells;
using CharpLabs;

namespace BattleOfMages.Mages
{
    public class FireMage : Mage
    {
        public FireMage(string name, int magicLevel) : base(name, magicLevel)
        {
            LearnSpell(new FireSpell());
        }
    }
}
