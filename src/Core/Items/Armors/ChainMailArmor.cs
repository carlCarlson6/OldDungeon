using System;

namespace Core.Items.Armors
{
    public class ChainMailArmor : Item
    {
        public ChainMailArmor() : base("Chain mail armor", ItemType.Armour) { }
        
        public override uint GetProtection() => 4;

        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint DoDamage() => throw new NotImplementedException();
    }
}