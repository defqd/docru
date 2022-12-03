namespace DocruTasks.Tests
{
    [TestFixture]
    public class SortOfNumbersTests
    {
        [TestCase(42145, 54421), Description ("Тест сортировки цифр числа по убыванию")]
        [TestCase(123456789, 987654321)]
        [TestCase(0, 0)]
        public void SortNumber(int number, int expected)
        {
            var result = SortOfNumbers.SortNumber(number);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-1), Description("Тест на отрицательное число")]
        public void NegativeNumberTest(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SortOfNumbers.SortNumber(number));
        }
    }
}