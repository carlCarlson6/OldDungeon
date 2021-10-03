using System;

namespace Core.Items.Weapons
{
    public class BattleAxe : Item
    {
        public BattleAxe() : base("My own fists", ItemType.Weapon) { }

        public override uint DoDamage() => Dice.Throw(1, 8);
        
        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint GetProtection()  => throw new NotImplementedException();
    }
}