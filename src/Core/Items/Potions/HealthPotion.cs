using System;

namespace Core.Items.Potions
{
    public class HealthPotion : Item
    {
        public HealthPotion() : base("Health Potion", ItemType.Consumable) { }
        
        public override Result Apply(Hero hero)
        {
            var pointsToCure = Dice.WithFaces(4).Throw(2);
            hero.Cure(pointsToCure);

            //return new ActionResult();
            throw new NotImplementedException();
        }

        // TODO - throw corresponding exception
        public override uint DoDamage() => throw new NotSupportedException();
        public override uint GetProtection() => throw new NotSupportedException();
    }
}