using System;

namespace Core.Services
{
    public static class ConsumableFactory
    {
        private static ConsumableResult GenerateCureResult(int pointsToCure) => 
            new ($" The hero has cured ${pointsToCure} health points", pointsToCure );

        public static Consumable CreateSmallHealthPotion()
        {
            var consumableApplier = new Func<Hero, ConsumableResult>(hero =>
            {
                var pointsToCure = Dice.Roll("1d6");
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
        
        public static Consumable CreateHealthPotion()
        {
            var consumableApplier = new Func<Hero, ConsumableResult>(hero =>
            {
                var pointsToCure = Dice.Roll("2d4");
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
        
        public static Consumable CreateLargeHealthPotion()
        {
            var consumableApplier = new Func<Hero, ConsumableResult>(hero =>
            {
                var pointsToCure = Dice.Roll("2d4+2");
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
    }
}