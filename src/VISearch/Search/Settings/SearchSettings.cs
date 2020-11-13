namespace VISearch
{
    public class SearchSettings
    {
        #region Enum Values

        /// <summary>
        /// The type of search to be done by the Search Pipeline
        /// </summary>
        public SearchType Type { get; set; }

        /// <summary>
        /// The format of the search string
        /// </summary>
        public SearchFormat Format { get; set; }

        #endregion

        #region Search String

        /// <summary>
        /// Determines if the search string must be
        /// equal to the casing of the data in a item <br />
        /// from the searched collection, for it to
        /// be added to the Search Result. If this <br />
        /// flag is set to false, the Search Pipeline
        /// will set all data to lower case.
        /// </summary>
        public bool CaseSensitive { get; set; }

        /// <summary>
        /// Sets the minimal length of the search string
        /// for it to be even used by the Search Pipeline. <br />
        /// This number must not be higher than the maximum
        /// search string length.
        /// </summary>
        public int MinSearchStringLength { get; set; }

        /// <summary>
        /// Sets the maximum length of the search string.
        /// If a search string length exceeds this number, <br />
        /// it will not be used by the Search Pipeline.
        /// This number must not be higher than the minimum <br />
        /// search string length
        /// </summary>
        public int MaxSearchStringLength { get; set; }

        #endregion

        #region Object Notation



        #endregion

        #region Search Filters

        /// <summary>
        /// The maximum number of filters that can be used
        /// at one search.
        /// </summary>
        public int MaximumFilterAmount { get; set; }

        #endregion

    }
}
