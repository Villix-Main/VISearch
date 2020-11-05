using System.Collections.Generic;
using System.Reflection;

namespace VISearch.Pipeline
{
    /// <summary>
    /// The filters that would be used in the Search Pipeline
    /// to filter the TSearchType to only have the relevant <br />
    /// properties and fields that are decorated with the 
    /// <see cref="SearchItemAttribute"/>. This class is also the default <br />
    /// implementation of the <see cref="IPipelineFilter"/>
    /// </summary>
    /// <remarks>
    /// The pipeline filter is simply just a collection
    /// of <see cref="PipelineItem"/>.
    /// </remarks>
    internal class PipelineFilter : IPipelineFilter
    {
        public List<PipelineItem> Create(IEnumerable<MemberInfo> members)
        {
            // The list to add all the pipeline items to
            var items = new List<PipelineItem>();

            foreach (var member in members)
            {
                // Attempt to get the SearhItemAttribute from the member
                var searchItemAttr = member.GetCustomAttribute<SearchItemAttribute>();

                // If the member is decorated with the SearchItemAttribute
                if (searchItemAttr != null)
                {
                    items.Add(CreateItem(searchItemAttr, member));
                }
            }

            // Return all the pipeline items found from members
            return items;
        }

        public List<PipelineItem> CreateFromSearchObject(IEnumerable<MemberInfo> members, int priority)
        {
            // The list to add all pipeline items to
            var items = new List<PipelineItem>();

            foreach (var member in members)
            {
                // Make sure that the member is not decorated with the SearchIgnoreAttribute
                if (member.GetCustomAttribute<SearchIgnoreAttribute>() == null)
                {
                    // Attempt to get the SearhItemAttribute from the member
                    var searchItemAttr = member.GetCustomAttribute<SearchItemAttribute>();

                    // If the member is decorated with the SearchItemAttribute
                    if (searchItemAttr != null)
                    {
                        // Create the pipeline item using data from the 
                        // SearchItemAttribute
                        items.Add(CreateItem(searchItemAttr, member));
                    }
                    else
                    {
                        // Create the pipeline item using default data
                        var item = new PipelineItem
                        {
                            // Set the name to the name of the member itself
                            Name = member.Name,

                            // Set the priority the passed through priority value
                            Priority = priority
                        };

                        // Add the new pipeline item to the collection
                        items.Add(item);
                    }
                }
            }

            // Return the items 
            return items;
        }

        #region Private Helpers

        /// <summary>
        /// Helper to create an pipeline item using data from the <see cref="SearchItemAttribute"/>
        /// </summary>
        /// <param name="attr">The data to use to create the pipeline item</param>
        /// <param name="member">The member to use as a backup if the 'attr' has a null name</param>
        /// <returns></returns>
        private PipelineItem CreateItem(SearchItemAttribute attr, MemberInfo member)
        {
            // Create a new pipeline item using info 
            // From the SearchItemAttribute
            var item = new PipelineItem
            {
                // If the name from the SearchItemAttribute is 
                // Not null use that name, otherwise use the 
                // Member's name itself.
                Name = attr.Name ?? member.Name,

                Priority = attr.Priority
            };

            // Return the item
            return item;
        }

        #endregion
    }
}
