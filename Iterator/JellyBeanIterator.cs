namespace Iterator
{
    /// <summary>
    /// A concrete iterator implements an algorithm to bypass a specific collection.
    /// </summary>
    public class JellyBeanIterator : IJellyBeenIterator
    {
        /// <summary>
        /// A reference to a collection that the iterator bypasses.
        /// </summary>
        private readonly JellyBeanCollection _jellyBeenCollection;

        /// <summary>
        /// Current position.
        /// </summary>
        private int _current;

        /// <summary>
        /// Step for iteration.
        /// </summary>
        private readonly int _step = 1;

        public JellyBeanIterator(JellyBeanCollection jellyBeenCollection)
        {
            _jellyBeenCollection = jellyBeenCollection;
        }

        /// <summary>
        /// Gets whether iteration is complete.
        /// </summary>
        public bool IsDone => _current >= _jellyBeenCollection.Count;

        /// <summary>
        /// Gets current iterator candy.
        /// </summary>
        public JellyBean CurrentBean => _jellyBeenCollection[_current] as JellyBean;

        /// <summary>
        /// Gets first jelly bean.
        /// </summary>
        /// <returns> First element or null. </returns>
        public JellyBean First()
        {
            return _current == 0 ? _jellyBeenCollection[_current] as JellyBean : null;
        }

        /// <summary>
        /// Gets next jelly bean.
        /// </summary>
        /// <returns> If not the end of the collection return the next element, if not - null. </returns>
        public JellyBean Next()
        {
            _current += _step;

            return !IsDone ? _jellyBeenCollection[_current] as JellyBean : null;
        }
    }
}