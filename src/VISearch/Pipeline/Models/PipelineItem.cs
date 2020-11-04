namespace VISearch.Pipeline
{
    /// <summary>
    /// The main model that will be used the most throughout
    /// the Search Pipeline. This class will most likely be <br />
    /// instantiated in the <see cref="SearchContext{TSearchType}"/>. 
    /// </summary>
    public class PipelineItem
    {
        /// <summary>
        /// The name of the pipeline item. This property will be used 
        /// in the Search Pipeline to filter down the properties and <br />
        /// fields in the TSearchType. This name will most likely be the 
        /// name of a property of field of TSearchType.
        /// </summary> 
        /// <seealso cref="SearchContext{TSearchType}"/>
        public string Name { get; set; }

        /// <summary>
        /// The priority level of the pipeline item. This level will 
        /// be used to tell the Search Pipeline in which first properties <br />
        /// and fields to compare first with the search query. 
        /// </summary>
        /// <remarks>
        /// To learn about the priority level check <see cref="SearchItemAttribute"/>
        /// </remarks>
        public int Priority { get; set; }
    }
}
