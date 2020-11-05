using System;

namespace VISearch
{
    /// <summary>
    /// Specifies that all public members in class decorated with this attribute,
    /// will be a Search Item and will be included in the Search Pipeline. <br />
    /// </summary>
    /// 
    /// <remarks>
    /// <para>
    /// For any reason that you want one or more class members to not 
    /// be a Search Item and be ignored by the Search Pipeline, decorate <br />
    /// that class member with <see cref="SearchIgnoreAttribute"/>. Though
    /// remember that not all class members can decorated it, since the Search Pipeline <br />
    /// requires at least one Search Item.
    /// </para>
    /// 
    /// <para>
    /// You can also decorate class members with the 
    /// <see cref="SearchItemAttribute"/>, if you want one or more to have a higher <br />
    /// priority level then others.
    /// </para>
    /// </remarks>

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SearchObjectAttribute : VISearchAttribute
    {
        /// <summary>
        /// The priority level of the Search Object. This number 
        /// will apply to all properties and fields that are not
        /// decorated with the <see cref="SearchIgnoreAttribute"/>.
        /// </summary>
        /// <remarks>
        /// To find out more about priority levels check <see cref="SearchItemAttribute.Priority"/>
        /// </remarks>
        public int Priority { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchObjectAttribute"/>
        /// </summary>
        /// <remarks>
        /// The constructor also sets the base class <see cref="VISearchAttribute"/>
        /// name property to null since the name only applies to properties and fields <br />
        /// and not classes</remarks>
        /// <param name="priority">The priority level of the Search Object</param>
        public SearchObjectAttribute(int priority = 0)
            : base(string.Empty) => Priority = priority;
    }
}
