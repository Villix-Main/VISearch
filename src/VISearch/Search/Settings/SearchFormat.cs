namespace VISearch
{
    /// <summary>
    /// The format of the search string that the Search Pipeline will
    /// use. The default search format that Search Pipeline <br />
    /// will use will be <see cref="SearchString"/>
    /// </summary>
    public enum SearchFormat
    {
        /// <summary>
        /// Search string is a string in which it is to
        /// be compared to a item in searched collection. <br />
        /// Search strings are interpreted as strings but can
        /// be interpreted as a number, boolean and <br /> other built 
        /// in .NET types. Search strings don't have to be strict
        /// when it comes to spelling <br /> and can be interpreted as 
        /// another string if the <see cref="SearchSettings"/> allow for it.
        /// </summary>
        /// <remarks>
        /// This will the default search format that Search Pipeline
        /// uses.
        /// </remarks>
        SearchString = 0,
       
        /// <summary>
        /// Object notation is a string that represents an 
        /// class object such as JSON. Object notation can be <br />
        /// represented in different formats in which the format
        /// can be set in the <see cref="SearchSettings"/>. 
        /// </summary>
        ObjectNotation = 1,

        /// <summary>
        /// Filter string is a string that represents one
        /// or more filter. The filter string must match <br />
        /// the info of a real filter such as the name
        /// and filter parameters. If there is a use case<br />
        /// to use more than one filter, filters must be
        /// separated with a coma.
        /// </summary>
        FilterString = 2
    }
}
