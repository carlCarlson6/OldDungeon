using System;

namespace Core.Items
{
    public class Consumable : Item
    {
        private readonly Func<Hero, Result> _consumableApplier;
        
        public Consumable(string name, Func<Hero, Result> consumableApplier) : base(name, ItemType.Consumable)
        {
            _consumableApplier = consumableApplier;
        }

        public override Result Apply(Hero hero) => _consumableApplier(hero);

        public override uint DoDamage() => throw new NotImplementedException();
        public override uint GetProtection() => throw new NotImplementedException();
    }
}