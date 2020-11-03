using System.Collections.Generic;

/// <summary>
/// The main context is the day
/// </summary>
namespace VISearch
{
    /// <summary>
    /// The context to be used for all VISearch operations such as 
    /// beginning the Search Pipeline. The context will usually <br />
    /// be derived from another class and will contain Filters. The 
    /// search context will also contain validators to validate type <br />
    /// to meet the Search Pipeline requirements.
    /// </summary>
    /// <typeparam name="TSearchType">
    /// The type of the collection to be searched and the type to be used
    /// by the Search Pipeline for comparison with the Search Query. If <br />
    /// you use Entity Framework, <see cref="TSearchType"/> will most
    /// likely be the same type of a DbSet. <see cref="TSearchType"/> will
    /// be required have at least <br /> property or field decorated with the 
    /// <see cref="SearchItemAttribute"/>. This type will be validated in
    /// context constructor and any errors will be <br /> given if requirements
    /// are not met.
    /// </typeparam>
    public class SearchContext<TSearchType> 
        where TSearchType : class
    {
        #region Private Members

        #endregion

        #region Constructor

        /// <summary>
        /// The default constructor of the Search Context. The main
        /// purpose of the constructor is to validate <see cref="TSearchType"/>
        /// and to make sure it meet's requirements of the Search Pipeline. Any 
        /// signs of breaking these requirements 
        /// </summar
        public SearchContext()
        {
        }

        #endregion  
    }
}
