namespace DocruTasks.Tests
{
    [TestFixture]
    public class ReturnFiveTests
    {
        [TestCase(5), Description("Тест метода всегда возвращающий 5")]
        public void AlwaysReturnsFiveTest(int expected)
        {
            Assert.That(ReturnFive.AlwaysReturnsFive(), Is.EqualTo(5));
        }
    }
}