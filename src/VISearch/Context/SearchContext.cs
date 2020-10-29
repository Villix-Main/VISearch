using System.Collections;
using System.Collections.Generic;

namespace VISearch
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchContext<TSearchType>
        where TSearchType : class
    {
        #region Private Members

        #endregion

        #region Constructor

        public SearchContext()
        {
            // Get the type of TSearchType
            var serachType = typeof(TSearchType);
        }

        #endregion

        public void BeginPipeline(IEnumerable<TSearchType> collection)
        {

        }
    }
}
