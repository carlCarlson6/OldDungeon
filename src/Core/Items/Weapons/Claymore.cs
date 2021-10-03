using System;

namespace Core.Items.Weapons
{
    public class Claymore : Item
    {
        public Claymore() : base(nameof(Claymore), ItemType.Weapon) { }

        public override uint DoDamage() => Dice.Throw(1, 10);
        
        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint GetProtection()  => throw new NotImplementedException();
    }
}