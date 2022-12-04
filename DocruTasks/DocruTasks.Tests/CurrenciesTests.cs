using DocruTasks.Tests.TestsSources;

namespace DocruTasks.Tests
{
    [TestFixture]
    public class CurrenciesTests
    {
        [TestCaseSource(typeof(CurrenciesTestSource)), Description("Тест нахождения наименьшего количество монет")]
        public void ConvertCurrencyTest(decimal cents, Dictionary<string, int> expected)
        {
            var result = Currencies.ConvertCurrency(cents);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0), Description("Тест на сумму меньше или равную 0")]
        [TestCase(-435)]
        public void NegativeOrZeroNumberTest(decimal cents)
        {
            var result = Currencies.ConvertCurrency(cents);

            var expected = new Dictionary<string, int>()
            {
                {"Nickels", 0},
                {"Pennies", 0},
                {"Dimes", 0},
                {"Quarters", 0}
            };

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}