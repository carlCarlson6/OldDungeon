using System;

namespace Core.Items.Potions
{
    public class HealthPotion : Item
    {
        public HealthPotion() : base("Health Potion", ItemType.Consumable) { }

        public override void Apply(Hero hero)
        {
            var pointsToCure = Dice.WithFaces(4).Throw(2);
            hero.Cure(pointsToCure);
        }

        // TODO - throw corresponding exception
        public override uint DoDamage() => throw new NotSupportedException();
    }
}