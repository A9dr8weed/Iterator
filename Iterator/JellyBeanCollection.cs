using System.Collections;

namespace Iterator
{
    /// <summary>
    /// The ConcreteAggregate implements the Iterator creation interface and returns a ConcreteIterator for that ConcreteAggregate.
    /// </summary>
    public class JellyBeanCollection : ICandyCollection
    {
        /// <summary>
        /// Collection to iterate.
        /// </summary>
        private readonly ArrayList _items = new ArrayList();

        /// <summary>
        /// Gets jelly bean count.
        /// </summary>
        public int Count => _items.Count;

        /// <summary>
        /// Indexer.
        /// </summary>
        /// <param name="index"> Collection position. </param>
        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }

        /// <summary>
        /// Note that the method signature returns the iterator interface.
        /// This allows the client not to depend on specific classes of iterators.
        /// </summary>
        /// <returns> Returns a new instance of a specific iterator by associating it with the current collection object. </returns>
        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }
    }
}