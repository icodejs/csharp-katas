// https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit

// https://github.com/nunit/docs/wiki/CollectionOrderedConstraint
using Kata.YourOrderPlease;
using NUnit.Framework;

namespace Kata.YourOrderPlease.UnitTests {
    [TestFixture]
    public class YourOrderPlease_Tests {
        private readonly YourOrderPlease _yourOrderPlease;

        public YourOrderPlease_Tests () {
            _yourOrderPlease = new YourOrderPlease ();
        }

        [Test]
        public void ReturnOrderedWords () {
            var result = _yourOrderPlease.Order ("is2 Thi1s T4est 3a");

            Assert.That (result, Is.EqualTo ("Thi1s is2 3a T4est"));
        }
    }
}
