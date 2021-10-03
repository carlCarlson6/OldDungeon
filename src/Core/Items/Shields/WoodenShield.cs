using System;

namespace Core.Items.Shields
{
    public class WoodenShield : Item
    {
        public WoodenShield() : base("Wooden shield", ItemType.Shield) { }
        
        public override uint GetProtection() => 3;

        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint DoDamage() => throw new NotImplementedException();
        
    }
}