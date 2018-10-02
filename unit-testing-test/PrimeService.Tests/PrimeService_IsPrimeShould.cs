// https://github.com/nunit/docs/wiki/CollectionOrderedConstraint
// $ dotnet test -- -v

using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services {
    [TestFixture]
    public class PrimeService_IsPrimeShould {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould () {
            _primeService = new PrimeService ();
        }

        [TestCase (-1)]
        [TestCase (0)]
        [TestCase (1)]
        public void ReturnFalseGivenValuesLessThan2 (int value) {
            var result = _primeService.IsPrime (value);

            Assert.IsFalse (result, $"{value} should not be prime");
        }

        [Test]
        public void ReturnTrueGivenValueIsOdd () {
            var result = _primeService.IsOdd (3);

            Assert.IsFalse (result, "should be odd");
        }

        [Test]
        public void ReturnOrderIntegers () {
            var result = _primeService.IsListOfIntegers ();

            Assert.That (result, Is.Ordered.Ascending);
        }
    }
}
