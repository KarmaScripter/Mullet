// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary> </summary>
    public interface IAmount
    {
        /// <summary> Gets the funding. </summary>
        /// <returns> </returns>
        double Value { get; set; }

        /// <summary> Gets the numeric column. </summary>
        /// <returns> </returns>
        string Numeric { get; set; }

        /// <summary> Gets the IAmount </summary>
        /// <returns> </returns>
        public IAmount GetAmount( );
    }
}