using System;

namespace Core.Items.Weapons
{
    public class Sword : Item
    {
        public Sword() : base(nameof(Sword), ItemType.Weapon) { }

        public override uint DoDamage() => Dice.Throw(1, 8);
        
        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint GetProtection()  => throw new NotImplementedException();
    }
}