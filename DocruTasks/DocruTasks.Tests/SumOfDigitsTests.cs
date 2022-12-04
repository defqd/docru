namespace DocruTasks.Tests
{
    [TestFixture]
    public class SumOfDigitsTests
    {
        [TestCase(16, 7), Description("Тестируем нахождение суммы цифр числа")]
        [TestCase(942, 6)]
        [TestCase(1234, 1)]
        [TestCase(1,1)]
        public void DigitsSumTest(int number, int expected)
        {
            var result = SumOfDigits.DigitsSum(number);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0), Description("Тестируем ненатуральные числа")]
        [TestCase(-1)]
        public void NegativeOrZeroNumberTest(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SumOfDigits.DigitsSum(number));
        }
    }
}