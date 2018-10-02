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
        public void RetrunSomeValue () {
            var result = _yourOrderPlease.IsPrime (1);
            Assert.IsFalse (result, "1 should not be prime");
        }
    }
}
