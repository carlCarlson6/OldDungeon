using System;

namespace Core.Items.Weapons
{
    public class HeavyMaze : Item
    {
        public HeavyMaze() : base("Heavy maze", ItemType.Weapon) { }

        public override uint DoDamage() => Dice.Throw(1, 6);
        
        public override ActionResult Apply(Hero hero) => throw new NotImplementedException();
        public override uint GetProtection()  => throw new NotImplementedException();
    }
}