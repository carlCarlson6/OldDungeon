using System;

namespace Core.Items
{
    public class Weapon : Item
    {
        private readonly Func<int> _damageGenerator;
        
        public Weapon(string name, Func<int> damageGenerator) : base(name, ItemType.Weapon)
        {
            _damageGenerator = damageGenerator;
        }
        
        public override int DoDamage() => _damageGenerator();
        
        public override Result Apply(Hero hero) => throw new NotImplementedException();
        public override int GetProtection() => throw new NotImplementedException();
    }
}