﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="System.Windows.Forms.ToolStripTextBox"/>
    /// <seealso cref="IToolStripTextBox"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ToolStripTextBox : ToolStripTextBase, IToolStripTextBox
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripTextBox"/>
        /// class.
        /// </summary>
        public ToolStripTextBox( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            Size = new Size( 200, 32 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 141, 139, 138 );
            Font = new Font( "Roboto", 9 );
            Visible = true;
            Enabled = true;
            Tag = Name;
            ToolTipText = Tag.ToString( );
            HoverText = string.Empty;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripTextBox"/>
        /// class.
        /// </summary>
        /// <param name="text"> The text. </param>
        public ToolStripTextBox( string text )
            : this( )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripTextBox"/>
        /// class.
        /// </summary>
        /// <param name="text"> The text. </param>
        /// <param name="hoverText"> The hover text. </param>
        public ToolStripTextBox( string text, string hoverText = "" )
            : this( text )
        {
            HoverText = hoverText;
        }

        /// <summary> Sets the text. </summary>
        /// <param name="text"> The text. </param>
        public void ResetText( string text )
        {
            try
            {
                Text = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the hover text. </summary>
        /// <param name="item"> The item. </param>
        public void SetHoverText( ToolStripItem item )
        {
            var _text = item?.Tag?.ToString( );
            if( !string.IsNullOrEmpty( _text ) )
            {
                try
                {
                    var _ = new SmallTip( item, _text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [mouse hover]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as ToolStripTextBox;
                if( _button != null
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    _button.Tag = HoverText;
                    var _tip = new SmallTip( _button );
                    ToolTip = _tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                    {
                        var _tool = new SmallTip( _button );
                        ToolTip = _tool;
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
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                    ToolTip = null;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}