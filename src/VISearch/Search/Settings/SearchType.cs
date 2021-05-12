namespace VISearch
{
    /// <summary>
    /// The type of search that the Search Pipeline will
    /// execute. The search type will work with any Search <br />
    /// Format that does not already have it's own search 
    /// type such as the <see cref="SearchFormat.FilterString"/>
    /// which uses it's own version of the Strict SearchType <br />
    /// </summary>
    public enum SearchType
    {
        /// <summary>
        /// A sectional search will tell the Search Pipeline
        /// that a search string does not have to have full <br />
        /// equality with a item in the Searched Collection 
        /// for it to be added to the Search Results. The <br />
        /// strictness of a sectional search can be set
        /// in the <see cref="SearchSettings"/>.
        /// </summary>
        Sectional = 0,

        /// <summary>
        /// A strict search will tell the Search Pipeline
        /// to make sure that the search string matches <br />
        /// exact with a item in the Searched collection.
        /// Strict search settings such as case sensitive <br />
        /// search can be set in the <see cref="SearchSettings"/>.
        /// </summary>
        Strict = 1
    }
}
