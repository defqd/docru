namespace DocruTasks
{
    /// <summary>
    /// Класс предоставляет статический метод для нахождения суммы цифр числа
    /// </summary>
    public static class SumOfDigits
    {
        /// <summary>
        /// Возвращает сумму цифр числа
        /// </summary>
        /// <param name="number">Натуральное положительное число</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int DigitsSum(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException("Число не может быть отрицательным или равным 0");

            int result = 0;
            int digits = 0;

            while (number > 0)
            {
                result += number % 10;
                number /= 10;
                digits++;
            }

            if (digits > 1)
            {
                number = result;
                return DigitsSum(number);
            }
            return result;

        }
    }
}