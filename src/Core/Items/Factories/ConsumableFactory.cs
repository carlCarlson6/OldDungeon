using System;

namespace Core.Items.Factories
{
    public static class ConsumableFactory
    {
        private static Result GenerateCureResult(uint pointsToCure) => 
            new Result($" The hero has cured ${pointsToCure} health points");

        public static Consumable CreateSmallHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>(hero =>
            {
                var pointsToCure = Dice.Throw(1,6);
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
        
        public static Consumable CreateHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>(hero =>
            {
                var pointsToCure = Dice.Throw(2,4);
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
        
        public static Consumable CreateLargeHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>(hero =>
            {
                var pointsToCure = Dice.Throw(2,4,2);
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
    }
}