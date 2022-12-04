namespace DocruTasks
{
    /// <summary>
    /// Класс предоставляет статический метод для нахождения наименьшего количество монет, используемых для создания суммы
    /// </summary>
    public static class Currencies
    {
        /// <summary>
        /// Вычисляет наименьшее количество монет, используемых для создания заданной суммы
        /// </summary>
        /// <param name="cents">Центы</param>
        /// <returns>Наименьшее количество монет</returns>
        public static Dictionary<string, int> ConvertCurrency(decimal cents)
        {
            var result = new Dictionary<string, int>()
            {
                {"Nickels", 0},
                {"Pennies", 0},
                {"Dimes", 0},
                {"Quarters", 0}
            };

            if (cents <= 0)
                return result;

            result["Quarters"] = (int)cents / 25;
            cents = cents % 25;
            
            result["Dimes"] = (int)cents / 10;
            cents = cents % 10;

            result["Nickels"] = (int)cents / 5;
            cents = cents % 5;

            result["Pennies"] = (int)cents;

            return result;
        }
    }
}