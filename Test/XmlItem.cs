namespace Test
{
    /// <summary>
    /// Элемент из разметки xml
    /// </summary>
    public class XmlItem
    {
        /// <summary>
        /// Название тега
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string Value { get; set; }


        /// <summary>
        /// Глубина иерархии
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Номер последовательности
        /// </summary>
        public int Y { get; set; }
    }
}