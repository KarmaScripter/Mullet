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

    /// <summary>
    /// Defines the
    /// <see cref="Label"/>
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Label : MetroSetLabel
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public virtual SmallTip ToolTip { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public virtual string HoverText { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Label"/>
        /// class.
        /// </summary>
        public Label( )
        {
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Size = new Size( 165, 23 );
            BackColor = Color.Transparent;
            ForeColor = Color.DarkGray;
            Font = new Font( "Roboto", 8 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Enabled = true;
            Visible = true;
            BorderStyle = BorderStyle.None;
            FlatStyle = FlatStyle.Flat;
            TextAlign = ContentAlignment.MiddleLeft;

            // Event Wiring
            MouseHover += OnMouseOver;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Label"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        public Label( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Label"/>
        /// class.
        /// </summary>
        /// <param name="label"> The label. </param>
        public Label( MetroSetLabel label )
            : this( label.Size, label.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Label"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        /// <param name="parent"> The parent. </param>
        public Label( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Label"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        /// <param name="parent"> The parent. </param>
        /// <param name="text"> The text. </param>
        public Label( Size size, Point location, Control parent, string text )
            : this( size, location, parent )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Label"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        /// <param name="parent"> The parent. </param>
        /// <param name="bindingSource"> The bindingSource. </param>
        public Label( Size size, Point location, Control parent, BindingSource bindingSource )
            : this( size, location, parent )
        {
            BindingSource = bindingSource;
        }

        /// <summary> Sets the text. </summary>
        /// <param name="text"> The text. </param>
        public void SetText( string text )
        {
            if( !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    Text = text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the tag. </summary>
        /// <param name="tag"> The tag. </param>
        public void SetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
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
            var _budgetLabel = sender as Label;
            try
            {
                if( _budgetLabel != null
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        var _hoverText = _budgetLabel?.HoverText;
                        var _ = new SmallTip( _budgetLabel, _hoverText );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            var _text = Tag?.ToString( )?.SplitPascal( );
                            var _ = new SmallTip( _budgetLabel, _text );
                        }
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
            try
            {
                if( sender is Label _budgetLabel )
                {
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static protected void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}