using System;

namespace Core
{
    public class Consumable : Item
    {
        private readonly Func<Hero, Result> _consumableApplier;
        
        public Consumable(string name, Func<Hero, Result> consumableApplier) : base(name, ItemType.Consumable)
        {
            _consumableApplier = consumableApplier;
        }

        public override Result Apply(Hero hero) => _consumableApplier(hero);

        public override int DoDamage() => throw new NotImplementedException();
        public override int GetProtection() => throw new NotImplementedException();
    }
}