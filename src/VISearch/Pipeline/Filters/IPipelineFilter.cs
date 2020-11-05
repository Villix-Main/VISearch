using System.Collections.Generic;
using System.Reflection;

namespace VISearch.Pipeline
{
    /// <summary>
    /// The representation of a pipeline filter
    /// </summary>
    internal interface IPipelineFilter
    {
        /// <summary>
        /// Creates a pipeline filter using a collection of 
        /// <see cref="MemberInfo"/> taking into account that <br />
        /// the member collection does not come from a class
        /// decorated with the <see cref="SearchObjectAttribute"/>
        /// </summary>
        /// <param name="members">
        /// The members to use to filter down all the ones decorated with the
        /// <see cref="SearchItemAttribute"/></param>
        /// <returns>
        /// A <see cref="List{T}"/> of <see cref="PipelineItem"/> that contains all
        /// the members that were decorated with the <see cref="SearchItemAttribute"/>
        /// </returns>IEnumerable<MemberInfo> members);
        List<PipelineItem> Create(IEnumerable<MemberInfo> members);

        /// <summary>
        /// Creates a pipeline filter using a collection of
        /// <see cref="MemberInfo"/> taking into account that <br />
        /// the member collection comes from class decorated with
        /// the <see cref="SearchObjectAttribute"/>.
        /// </summary>
        /// <param name="members">
        /// The members to use to filter down all the ones decorated with the
        /// <see cref="SearchItemAttribute"/>
        /// </param>
        /// <param name="priority">The priority level of the Search Object</param>
        /// <returns>
        /// A <see cref="List{T}"/> of <see cref="PipelineItem"/> that contains all
        /// the members that were decorated with the <see cref="SearchItemAttribute"/>
        /// </returns>
        List<PipelineItem> CreateFromSearchObject(IEnumerable<MemberInfo> members, int priority);
    }
}
