namespace DocruTasks
{
    /// <summary>
    /// Класс предоставляет статический метод для сортировки цифр числа по убыванию
    /// </summary>
    public static class SortOfNumbers
    {
        /// <summary>
        /// Сортирует цифры числа по убыванию
        /// </summary>
        /// <param name="number">Неотрицательное целое число</param>
        /// <returns>Число отсортированное по убыванию</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int SortNumber(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException("Число не может быть отрицательным");

            return int.Parse(string.Concat(number.ToString().OrderByDescending(x => x)));
        }
    }
}