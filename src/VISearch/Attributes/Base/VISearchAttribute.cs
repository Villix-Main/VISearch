using System;
using System.Xml.Serialization;

namespace VISearch
{
    /// <summary>
    /// The base that contains all basic functionality for all 
    /// VISearch attributes to derive from. Decorating a entity <br />
    /// with attribute will serve no purpose as the <see cref="VISearchAttribute"/>
    /// just serves as a base class.
    /// </summary>
    public class VISearchAttribute : Attribute
    {
        #region Public Properties
        
        /// <summary>
        /// The name that will be used by the Search Pipeline. 
        /// This name will most likely be the name of the class <br />
        /// member itself.
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructor
        
        /// <summary>
        /// Initializes a new instance of the <see cref="VISearchAttribute"/> base class
        /// </summary>
        /// <param name="name">
        /// The name of a class member that will be used by the
        /// Search Pipeline. This name will most likely be the <br />
        /// class member itself</param>
        public VISearchAttribute(string name) => Name = name;
        
        #endregion
    }
}
