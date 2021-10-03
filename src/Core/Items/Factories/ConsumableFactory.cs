using System;

namespace Core.Items.Factories
{
    public static class ConsumableFactory
    {
        private static Result GenerateCureResult(uint pointsToCure) => 
            new ($" The hero has cured ${pointsToCure} health points", new { CuredPoints = pointsToCure });

        public static Consumable CreateSmallHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>(hero =>
            {
                var pointsToCure = Dice.Roll(6);
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
        
        public static Consumable CreateHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>(hero =>
            {
                var pointsToCure = Dice.Roll(4);
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
        
        public static Consumable CreateLargeHealthPotion()
        {
            var consumableApplier = new Func<Hero, Result>(hero =>
            {
                var pointsToCure = Dice.Roll(2,4,2);
                hero.Cure(pointsToCure);
                return GenerateCureResult(pointsToCure);
            });
            return new Consumable("Health potion", consumableApplier);
        }
    }
}