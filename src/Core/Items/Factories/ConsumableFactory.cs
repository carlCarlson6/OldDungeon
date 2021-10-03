using System;

namespace Core.Items.Factories
{
    public static class ConsumableFactory
    {
        public static Consumable CreateSmallHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>((Hero hero) =>
            {
                var pointsToCure = Dice.Throw(1,6);
                hero.Cure(pointsToCure);

                // TODO - set correct info
                return new Result();
            });
            return new Consumable("Health potion", consumableApplier);
        }
        
        public static Consumable CreateHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>((Hero hero) =>
            {
                var pointsToCure = Dice.Throw(2,4);
                hero.Cure(pointsToCure);

                // TODO - set correct info
                return new Result();
            });
            return new Consumable("Health potion", consumableApplier);
        }
        
        public static Consumable CreateLargeHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>((Hero hero) =>
            {
                var pointsToCure = Dice.Throw(2,4,2);
                hero.Cure(pointsToCure);

                // TODO - set correct info
                return new Result();
            });
            return new Consumable("Health potion", consumableApplier);
        }
    }
}