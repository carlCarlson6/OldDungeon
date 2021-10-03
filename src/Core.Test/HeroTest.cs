using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Core.Test
{
    [TestClass]
    public class HeroTest
    {
        [TestMethod]
        public void WhenHero_SufferDamage_HisHealthIsReduced()
        {
            var hero = new Hero("test_hero");
            
            var healthBefore = hero.HealthPoints;

            hero.SufferDamage(5);

            Check.That(healthBefore).IsNotEqualTo(hero.HealthPoints);
            Check.That(healthBefore).IsEqualTo(hero.HealthPoints + 4);
        }
    }
}