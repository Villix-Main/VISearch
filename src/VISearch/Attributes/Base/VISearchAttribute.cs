using System;

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
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="VISearchAttribute"/> base class
        /// </summary>
        public VISearchAttribute() { }
        
        #endregion
    }
}
