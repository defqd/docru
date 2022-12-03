namespace DocruTasks.Tests
{
    [TestFixture]
    public class SumOfTriangleRowTests
    {
        [TestCase(2, 8), Description("Тест суммы строки числового треугольника")]
        [TestCase(1,1)]
        [TestCase(3,27)]
        [TestCase(4,64)]
        [TestCase(5,125)]
        public void SumRowTest(int rowNumber, int expected)
        {
            var result = SumOfTriangleRow.RowSum(rowNumber);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0), Description("Тест на несуществующую строку")]
        [TestCase(-1)]
        public void NegativeOrZeroRowTest(int rowNumber)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SumOfTriangleRow.RowSum(rowNumber));
        }
    }
}