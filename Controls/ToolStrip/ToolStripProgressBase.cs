﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary> </summary>
    public abstract class ToolStripProgressBase : System.Windows.Forms.ToolStripProgressBar
    {
        /// <summary> Gets or sets the field. </summary>
        /// <value> The field. </value>
        public virtual Field Field { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public virtual SmallTip ToolTip { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripProgressBase"/>
        /// class.
        /// </summary>
        protected ToolStripProgressBase( )
        {
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}