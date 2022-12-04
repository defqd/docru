using System.Collections;

namespace DocruTasks.Tests.TestsSources
{
    public class CurrenciesTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 56m, new Dictionary<string, int>() { { "Nickels", 1 }, { "Pennies", 1 }, { "Dimes", 0 }, { "Quarters", 2 } }};
            yield return new object[] { 4.935m, new Dictionary<string, int>() { { "Nickels", 0 }, { "Pennies", 4 }, { "Dimes", 0 }, { "Quarters", 0 } }};
        }
    }
}