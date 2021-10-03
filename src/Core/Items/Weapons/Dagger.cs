using System;

namespace Core.Items.Weapons
{
    public class Dagger : Item
    {
        public Dagger() : base("My own fists", ItemType.Weapon) { }

        public override uint DoDamage() => Dice.Throw(1, 4);
        
        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint GetProtection()  => throw new NotImplementedException();
    }
}