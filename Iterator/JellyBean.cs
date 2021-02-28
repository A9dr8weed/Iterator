namespace Iterator
{
    /// <summary>
    /// Our collection item.
    /// </summary>
    public class JellyBean
    {
        /// <summary>
        /// Flavor of candy.
        /// </summary>
        private readonly string _flavor;

        public JellyBean(string flavor)
        {
            _flavor = flavor;
        }

        public string Flavor => _flavor;
    }
}