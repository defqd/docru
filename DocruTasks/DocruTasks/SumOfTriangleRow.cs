namespace DocruTasks
{
    /// <summary>
    /// Класс предоставляет статический метод для нахождения суммы строки числового треугольника
    /// </summary>
    public static class SumOfTriangleRow
    {
        /// <summary>
        /// Вычисляет сумму строки числового треугольника
        /// </summary>
        /// <param name="rowNumber">Номер строки</param>
        /// <returns>Сумма строки</returns>
        public static int RowSum(int rowNumber)
        {
            if (rowNumber <= 0)
                throw new ArgumentOutOfRangeException("Число не может быть отрицательным или равным 0");

            return rowNumber * rowNumber * rowNumber;
        }
    }
}