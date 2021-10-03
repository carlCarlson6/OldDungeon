using System;

namespace Core.Items.Factories
{
    public static class ConsumableFactory
    {
        public static Consumable CreateHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>((Hero hero) =>
            {
                var pointsToCure = Dice.WithFaces(4).Throw(2);
                hero.Cure(pointsToCure);

                //return new ActionResult();
                throw new NotImplementedException();
            });
            return new Consumable("Health potion", consumableApplier);
        }
    }
}