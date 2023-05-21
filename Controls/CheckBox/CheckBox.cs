﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
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
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;
    using CheckState = MetroSet_UI.Enums.CheckState;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CheckBox : MetroSetCheckBox
    {
        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public virtual SmallTip ToolTip { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public virtual string HoverText { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CheckBox"/>
        /// class.
        /// </summary>
        public CheckBox( )
        {
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Size = new Size( 125, 25 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            DisabledBorderColor = Color.FromArgb( 20, 20, 20 );
            Font = new Font( "Roboto", 8 );
            ForeColor = Color.LightGray;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Cursor = Cursors.Hand;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            CheckSignColor = Color.LimeGreen;
            CheckState = CheckState.Unchecked;

            // Disabled Color Configuration
            DisabledBorderColor = Color.Transparent;

            // Event Wiring
            MouseHover += OnMouseOver;
            MouseLeave += OnMouseLeave;
        }

        /// <summary> Called when [mouse over]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnMouseOver( object sender, EventArgs e )
        {
            var _checkBox = sender as CheckBox;
            try
            {
                if( _checkBox != null
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    var _hoverText = _checkBox?.HoverText;
                    var _ = new SmallTip( _checkBox, _hoverText );
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                    {
                        var _text = Tag?.ToString( )?.SplitPascal( );
                        var _ = new SmallTip( _checkBox, _text );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [mouse leave]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnMouseLeave( object sender, EventArgs e )
        {
            var _checkBox = sender as CheckBox;
            try
            {
                if( _checkBox != null )
                {
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected private void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}