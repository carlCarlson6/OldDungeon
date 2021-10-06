using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Core.Test
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void When_ValidateRollIndicationFormat_Of_InvalidFormat_ShouldReturnFalse()
        {
            Check.That(Dice.ValidateRollIndicationFormat("321")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("asd")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("ASD")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("1D4")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("32D")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("1d6+")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("1d6-")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("+1d6")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("-1d6")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("1d+6")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("1d-6")).IsFalse();
            Check.That(Dice.ValidateRollIndicationFormat("1    d    5+4")).IsFalse();
        }
        
        [TestMethod]
        public void When_ValidateRollIndicationFormat_Of_ValidFormat_ShouldReturnTrue()
        {
            Check.That(Dice.ValidateRollIndicationFormat("1d8")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("21d12")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("1d20+1")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("1d20-5")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("3d6+11")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("0d0")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("0d0")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("8d0")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("0d5")).IsTrue();
            Check.That(Dice.ValidateRollIndicationFormat("1d1+0")).IsTrue();
        }

        [TestMethod]
        public void When_ExtractRollValues_1d8_ShouldReturn_1Dices_8Faces_0Bonus()
        {
            var (dices, faces, bonus) = Dice.ExtractRollValues("1d8");
            Check.That(dices).IsEqualTo(1);
            Check.That(faces).IsEqualTo(8);
            Check.That(bonus).IsEqualTo(0);
        }
        
        [TestMethod]
        public void When_ExtractRollValues_1d20_ShouldReturn_1Dices_20Faces_0Bonus()
        {
            var (dices, faces, bonus) = Dice.ExtractRollValues("1d20");
            Check.That(dices).IsEqualTo(1);
            Check.That(faces).IsEqualTo(20);
            Check.That(bonus).IsEqualTo(0);
        }
        
        [TestMethod]
        public void When_ExtractRollValues_12d8_ShouldReturn_12Dices_8Faces_0Bonus()
        {
            var (dices, faces, bonus) = Dice.ExtractRollValues("12d8");
            Check.That(dices).IsEqualTo(12);
            Check.That(faces).IsEqualTo(8);
            Check.That(bonus).IsEqualTo(0);
        }
        
        [TestMethod]
        public void When_ExtractRollValues_1d8plus10_ShouldReturn_1Dices_8Faces_10Bonus()
        {
            var (dices, faces, bonus) = Dice.ExtractRollValues("1d8+10");
            Check.That(dices).IsEqualTo(1);
            Check.That(faces).IsEqualTo(8);
            Check.That(bonus).IsEqualTo(10);
        }
        
        [TestMethod]
        public void When_ExtractRollValues_1d8minus5_ShouldReturn_1Dices_8Faces_minus5Bonus()
        {
            var (dices, faces, bonus) = Dice.ExtractRollValues("1d8-5");
            Check.That(dices).IsEqualTo(1);
            Check.That(faces).IsEqualTo(8);
            Check.That(bonus).IsEqualTo(-5);
        }

        [TestMethod]
        public void When_Roll3d6_ShouldReturnNumber_Between3And18()
        {
            var result = Dice.Roll("3d6");
            Check.That(result)
                .IsStrictlyGreaterThan(2)
                .And
                .IsStrictlyLessThan(19);
        }
        
    }
}