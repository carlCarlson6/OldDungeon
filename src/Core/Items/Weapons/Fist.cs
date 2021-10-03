using System;

namespace Core.Items.Weapons
{
    public class Fist : Item
    {
        public Fist() : base("My own fists", ItemType.Weapon) { }

        public override uint DoDamage() => Dice.Throw(1, 4, 1);
        
        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        
        public override uint GetProtection()  => throw new NotImplementedException();
    }
}