using Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Core.Test
{
    [TestClass]
    public class ConsumableTest
    {
        [TestMethod]
        public void WhenHero_SuffersDamage_HisHealthIncreases()
        {
            var hero = new Hero("test_hero");
            hero.SufferDamage(3);
            Check.That(hero.HealthPoints).IsEqualTo(hero.MaxHealPoints - 3);
        }
        
        [TestMethod]
        public void WhenHero_UsesHealthPotionPotion_HisHealthIncreases()
        {
            var hero = new Hero("test_hero");
            hero.SufferDamage(3);

            var potion = ConsumableFactory.CreateHealthPotion();
            hero.Inventory.AddItem(potion);

            var healthBeforePotion = hero.HealthPoints;

            var result = (ConsumableResult)hero.UseItem(potion);
            var curedPoints = result.CuredPoints;
            
            Check.That(hero.HealthPoints).IsNotEqualTo(healthBeforePotion);
            Check.That(curedPoints).Equals(healthBeforePotion - hero.HealthPoints);
        }
    }
}