﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VISearch.Pipeline;

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

        /// <summary>
        /// The list that would contain all the properties and fields
        /// in <see cref="TSearchType"/> that are decorated with the <br />
        /// <see cref="VISearchAttribute"/> or all non-ignored properties 
        /// and fields if <see cref="TSearchType"/> is decorated with the <br />
        /// <see cref="SearchObjectAttribute"/>.
        /// </summary>
        /// <remarks>
        /// This list would be used intensively in the Search Pipeline
        /// </remarks>
        private List<PipelineItem> _items;

        #endregion

        #region Constructor

        /// <summary>
        /// The default constructor of the Search Context. The main
        /// purpose of the constructor is to validate <see cref="TSearchType"/>
        /// and to make sure it meet's requirements of the Search Pipeline. Any 
        /// signs of breaking these requirements 
        /// </summary>
        public SearchContext()
        {
            // Get the SearchType
            var type = typeof(TSearchType);

            // Get all the properties and fields from TSearchType and storing it in members
            var members = (type.GetProperties(BindingFlags.Public | BindingFlags.Instance) as IEnumerable<MemberInfo>)
                .Concat(type.GetFields(BindingFlags.Public | BindingFlags.Instance));

            // Make sure the TSearchType contains at least one property or field
            // And if not throw an exception
            if (members == null)
                throw new InvalidOperationException($"'{ nameof(TSearchType) }' must contain at least property or field as required by the Search Pipeline");

            // Create a new instance of the pipeline filter
            var filter = new PipelineFilter();
            
            // If TSearchType is not decorated with the SearchObjectAttribute
            // Create the pipeline filters using default method
            if (type.GetCustomAttribute<SearchObjectAttribute>() == null)
                _items = filter.Create(members);

            // Otherwise use method for a class decorated with the SearchObjectAttribute
            else
                _items = filter.CreateFromSearchObject(members, type.GetCustomAttribute<SearchObjectAttribute>().Priority);

            // If the pipeline item list is empty, throw exception
            if (_items.Count <= 0)
                throw new InvalidOperationException($"'{ nameof(TSearchType) }' must have at least one property or field decorated with the '{ nameof(SearchItemAttribute) }' as required by the Search Pipeline");
        }

        #endregion  
    }
}
