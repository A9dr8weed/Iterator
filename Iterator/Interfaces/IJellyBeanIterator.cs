namespace Iterator
{
    /// <summary>
    /// The 'Iterator' interface.
    /// The iterator describes an interface for accessing and bypassing collection items.
    /// </summary>
    public interface IJellyBeenIterator
    {
        /// <summary>
        /// Rewinds the Iterator to the first element.
        /// </summary>
        /// <returns> First element. </returns>
        JellyBean First();

        /// <summary>
        /// Move forward to next element.
        /// </summary>
        /// <returns> Next element. </returns>
        JellyBean Next();

        /// <summary>
        /// Check if the bypass is complete.
        /// </summary>
        bool IsDone { get; }

        /// <summary>
        /// Returns the current element.
        /// </summary>
        JellyBean CurrentBean { get; }
    }
}