using System;

namespace Core.Items.Armors
{
    public class LeatherArmor : Item
    {
        public LeatherArmor() : base("Leather armor", ItemType.Armour) { }

        public override uint GetProtection() => 2;

        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint DoDamage() => throw new NotImplementedException();
    }
}