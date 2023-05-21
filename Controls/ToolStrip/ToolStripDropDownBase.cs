// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="System.Windows.Forms.ToolStripComboBox"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ToolStripDropDownBase : ToolStripComboBoxEx
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public virtual string HoverText { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripDropDownBase"/>
        /// class.
        /// </summary>
        protected ToolStripDropDownBase( )
        {
        }

        /// <summary> Sets the font. </summary>
        /// <param name="font"> The font. </param>
        public virtual void SetFont( Font font )
        {
            try
            {
                Font = font ?? new Font( "Roboto", 8 );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the color of the fore. </summary>
        /// <param name="color"> The color. </param>
        public virtual void SetForeColor( Color color )
        {
            try
            {
                ForeColor = color != Color.Empty
                    ? color
                    : Color.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the color of the back. </summary>
        /// <param name="color"> The color. </param>
        public virtual void SetBackColor( Color color )
        {
            try
            {
                BackColor = color != Color.Empty
                    ? color
                    : Color.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the field. </summary>
        /// <param name="field"> The field. </param>
        public virtual void SetField( Field field )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the hover text. </summary>
        /// <param name="item"> The item. </param>
        public virtual void SetHoverText( ToolStripItem item )
        {
            try
            {
                var _text = item?.Tag?.ToString( );
                HoverText = !string.IsNullOrEmpty( _text )
                    ? _text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the hover text. </summary>
        /// <param name="text"> The text. </param>
        public virtual void SetHoverText( string text )
        {
            try
            {
                HoverText = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
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