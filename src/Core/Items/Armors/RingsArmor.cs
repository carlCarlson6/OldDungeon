using System;

namespace Core.Items.Armors
{
    public class RingsArmor : Item
    {
        public RingsArmor() : base("Rings armor", ItemType.Armour) { }

        public override uint GetProtection() => 3;

        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint DoDamage() => throw new NotImplementedException();
    }
}