// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    /// <summary> </summary>
    public interface IDataUnit
    {
        /// <summary> </summary>
        public int ID { get; set; }

        /// <summary> Gets the field. </summary>
        public string Code { get; set; }

        /// <summary> The name </summary>
        public string Name { get; set; }

        /// <summary> </summary>
        /// <value> </value>
        public DataRow Record { get; set; }

        /// <summary> Determines whether the specified element is match. </summary>
        /// <param name = "unit" > The element. </param>
        /// <returns>
        /// <c> true </c>
        /// if the specified element is match; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool IsMatch( IDataUnit unit );

        /// <summary> Determines whether the specified dictionary is match. </summary>
        /// <param name = "dict" > The dictionary. </param>
        /// <returns>
        /// <c> true </c>
        /// if the specified dictionary is match; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool IsMatch( IDictionary<string, object> dict );
    }
}