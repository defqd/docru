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
        public static int RowSum(int rowNumber) => rowNumber * rowNumber * rowNumber;
    }
}