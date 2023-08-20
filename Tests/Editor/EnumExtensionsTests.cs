using NUnit.Framework;
using System;
using System.Linq;

namespace Packages.com.tymurkoshel.Tests.Editor
{
    [TestFixture]
    public class EnumExtensionsTests
    {
        public enum SampleEnum
        {
            Value1,
            Value2,
            Value3
        }

        [Test]
        public void GetAllItems_ReturnsAllEnumValues()
        {
            var expectedValues = Enum.GetValues(typeof(SampleEnum)).Cast<SampleEnum>();
            var result = EnumExtensions.GetAllItems<SampleEnum>();

            CollectionAssert.AreEquivalent(expectedValues, result);
        }
    }
}