namespace Iterator
{
    /// <summary>
    /// The Aggregate defines an interface for creating an Iterator object.
    /// </summary>
    public interface ICandyCollection
    {
        /// <summary>
        /// The collection itself can create iterators because it knows exactly which iterators can work with it.
        /// </summary>
        JellyBeanIterator CreateIterator();
    }
}