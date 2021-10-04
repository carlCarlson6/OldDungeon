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

            const int healthPointsToReduce = 5;
            hero.SufferDamage(healthPointsToReduce);

            Check.That(healthBefore).IsNotEqualTo(hero.HealthPoints);
            Check.That(healthBefore).IsEqualTo(hero.HealthPoints + healthPointsToReduce);
        }
    }
}