using System;

namespace Core.Items.Armors
{
    public class PlateArmor : Item
    {
        public PlateArmor() : base("Plate armor", ItemType.Armour) { }
        
        public override uint GetProtection() => 6;

        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint DoDamage() => throw new NotImplementedException();
    }
}