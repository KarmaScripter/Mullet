// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    /// <summary> </summary>
    public interface IDataGrid
    {
        /// <summary> Gets the filter values. </summary>
        /// <param name = "dict" > The dictionary. </param>
        /// <returns> </returns>
        string GetFilterValues( IDictionary<string, object> dict );

        /// <summary> Gets the current data row. </summary>
        /// <returns> </returns>
        DataRow GetCurrentDataRow( );

        /// <summary> Called when [right click]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "DataGridViewCellMouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnRightClick( object sender, DataGridViewCellMouseEventArgs e );
    }
}