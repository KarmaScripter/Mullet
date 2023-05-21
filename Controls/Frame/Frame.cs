// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary> </summary>
    public partial class Frame : UserControl
    {
        /// <summary> Gets or sets the index. </summary>
        /// <value> The index. </value>
        public int Index { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Frame"/>
        /// class.
        /// </summary>
        public Frame( )
        {
            InitializeComponent( );

            // Table Properties
            Table.BackColor = Color.Transparent;
            Table.ColumnCount = 1;
            Table.RowCount = 2;
            Table.Font = new Font( "Roboto", 8 );
            Table.ForeColor = Color.LightGray;

            // TextBox Properties
            TextBox.BorderColor = Color.FromArgb( 70, 70, 70 );
            TextBox.HoverColor = Color.FromArgb( 70, 70, 70 );
            TextBox.BackColor = Color.FromArgb( 30, 30, 30 );
        }
    }
}