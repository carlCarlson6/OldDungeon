using Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Core.Test
{
    [TestClass]
    public class ConsumableTest
    {
        [TestMethod]
        public void WhenHero_UsesAPotion_HisHealthIncreases()
        {
            var hero = new Hero("test_hero");
            hero.SufferDamage(5);

            var potion = ConsumableFactory.CreateHealthPotion();
            hero.Inventory.AddItem(potion);

            var healthBeforePotion = hero.HealthPoints;

            var result = hero.UseItem(potion);
            var curedPoints = result.Parameters; // TODO recover cure points

            Check.That(hero.HealthPoints).IsNotEqualTo(healthBeforePotion);
        }
        
    }
}