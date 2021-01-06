using System;

namespace VISearch
{
    /// <summary>
    /// Specifies that a property of field is a Search Item and will be
    /// included in the Search Pipeline. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class SearchItemAttribute : VISearchAttribute
    {
        #region Public Properties

        /// <summary>
        /// The priority level of the Search Item. This number
        /// will be used in the Search Pipeline to define which <br />
        /// properties and fields to compare first with the 
        /// Search Query. So if prop1 has a higher priority level <br />
        /// then prop2, prop1 will be first to be compared with the 
        /// Search Query and then prop2 if a comparison <br />
        /// was not made with prop1. Priority levels can 
        /// be set to any number and will be sorted in Search Pipeline <br />
        /// though it's recommended to go in order
        /// </summary>
        /// 
        /// <remarks>
        /// <para>
        /// Multiple properties and fields
        /// in one class can be decorated wit <see cref="SearchItemAttribute"/> <br />
        /// which tells the Search Pipeline that if any those properties or fields
        /// make a comparison with the Search Query. <br />
        /// a result can be created.
        /// </para>
        /// </remarks>
        public int Priority { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItemAttribute"/>
        /// </summary>
        /// <param name="priority">
        /// The priority level of the SearchItem. Click on '<see cref="Priority"/>'
        /// to find out more about Search Item priority levels
        /// </param>
        public SearchItemAttribute(int priority) => Priority = priority;

        #endregion
    }
}
