namespace DocruTasks
{
    /// <summary>
    /// Класс предоставляет статический метод возвращающий число 5
    /// </summary>
    public static class ReturnFive
    {
        /// <summary>
        /// Всегда возвращает число 5
        /// </summary>
        /// <returns>Число 5</returns>
        public static int AlwaysReturnsFive()
        {
            var hexA = "A";
            var hexF = "F";

            int firstValue = int.Parse(hexA, System.Globalization.NumberStyles.HexNumber);
            int secondValue = int.Parse(hexF, System.Globalization.NumberStyles.HexNumber);

            return firstValue ^ secondValue;
        }
    }
}