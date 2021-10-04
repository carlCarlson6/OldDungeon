using System;
using System.Collections.Generic;
using Core.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Core.Test.Extensions
{
    [TestClass]
    public class EnumerableExtensionsTest
    {
        [TestMethod]
        public void GivenAnEnumerable_WithTwoElements_When_Second_ShouldReturnSecondElement()
        {
            var enumerable = new List<string> { "hello", "world" };
            var secondElement = enumerable.Second();
            
            Check.That(secondElement).IsNotNull();
            Check.That(secondElement).IsEqualTo("world");
        }
        
        [TestMethod]
        public void GivenAnEnumerable_WithNoSecondElement_When_Second_ShouldReturnSecondElement()
        {
            var enumerable = new List<string> { "hello" };
            Check.ThatCode(() => enumerable.Second()).Throws<ArgumentOutOfRangeException>();
        }
        
        [TestMethod]
        public void GivenAnEnumerable_WithTwoElements_When_SecondSecondOrDefault_ShouldReturnSecondElement()
        {
            var enumerable = new List<string> { "hello", "world" };
            var secondElement = enumerable.Second();
            
            Check.That(secondElement).IsNotNull();
            Check.That(secondElement).IsEqualTo("world");
        }
        
        [TestMethod]
        public void GivenAnEnumerable_WithNoSecondElement_When_SecondOrDefault_ShouldReturnNull()
        {
            var enumerable = new List<string> { "hello world" };
            var secondElement = enumerable.SecondOrDefault();
            Check.That(secondElement).IsNull();
        }
    }
}