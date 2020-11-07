namespace VISearch.Pipeline
{
    /// <summary>
    /// The main model that will be used the most throughout
    /// the Search Pipeline. This class will most likely be <br />
    /// instantiated in the <see cref="SearchContext{TSearchType}"/>. 
    /// </summary>
    public class PipelineItem : IPipelineItem
    {
        public string Name { get; set; }

        public int Priority { get; set; }
    }
}
