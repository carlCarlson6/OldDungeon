using Core.Items.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Core.Test.Items
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
            
            hero.UseItem(potion);

            Check.That(hero.HealthPoints).IsNotEqualTo(healthBeforePotion);
        }
        
    }
}