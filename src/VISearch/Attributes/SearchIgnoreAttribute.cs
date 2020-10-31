using System;

namespace VISearch
{
    /// <summary>
    /// Specifies that a class or property will not be included
    /// in the Search Pipeline and will simply be ignored as the <br />
    /// name suggests. 
    /// </summary>
    /// <remarks>
    /// Please note that the <see cref="SearchIgnoreAttribute"/> is only
    /// relevant when the class that the property or field is in is decorated <br />
    /// with the <see cref="SearchObjectAttribute"/> because if it's not all 
    /// properties and fields are ignored by the Search Pipeline by default.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class SearchIgnoreAttribute : VISearchAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIgnoreAttribute"/> 
        /// </summary>
        /// <remarks>
        /// The constructor also sets the base class <see cref="VISearchAttribute"/>
        /// name property to null since the Search Pipeline <br />
        /// which uses the name property, will be ignoring 
        /// the property or field decorated with the <see cref="SearchIgnoreAttribute"/>
        /// </remarks>
        public SearchIgnoreAttribute() :
            base(string.Empty){ }
    }
}
