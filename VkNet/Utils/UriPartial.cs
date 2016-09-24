namespace VkNet.Utils
{
    /// <summary>
    /// Определяет части URI для метода Uri.GetLeftPart.
    /// </summary>
    public enum UriPartial
    {
        /// <summary>
        /// Сегменты схемы и полномочий URI.
        /// </summary>
        Authority = 0,
        /// <summary>
        /// Сегменты схемы, полномочий и пути URI.
        /// </summary>
        Path,
        /// <summary>
        /// Сегменты схемы, полномочий, пути и запроса URI.
        /// </summary>
        Query,
        /// <summary>
        /// Сегмент схемы URI.
        /// </summary>
        Scheme
    }
}