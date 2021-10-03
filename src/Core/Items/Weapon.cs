using System;

namespace Core.Items
{
    public class Weapon : Item
    {
        private readonly Func<uint> _damageGenerator;
        
        public Weapon(string name, Func<uint> damageGenerator) : base(name, ItemType.Weapon)
        {
            _damageGenerator = damageGenerator;
        }
        
        public override uint DoDamage() => _damageGenerator();
        
        public override Result Apply(Hero hero) => throw new NotImplementedException();
        public override uint GetProtection() => throw new NotImplementedException();
    }
}