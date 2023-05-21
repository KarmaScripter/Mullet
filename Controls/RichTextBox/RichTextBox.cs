﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;

    /// <summary> </summary>
    public class RichTextBox : MetroSetRichTextBox
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
        /// <see cref="RichTextBox"/>
        /// class.
        /// </summary>
        public RichTextBox( )
        {
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Size = new Size( 140, 30 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 8 );
            ForeColor = Color.LightGray;
            BackColor = Color.FromArgb( 30, 30, 30 );
            Enabled = true;
            Visible = true;

            // BackColor SeriesConfiguration

            // Border SeriesConfiguration
            BorderColor = Color.FromArgb( 65, 65, 65 );
            HoverColor = Color.FromArgb( 0, 120, 212 );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextBox"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        public RichTextBox( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextBox"/>
        /// class.
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="parent"> The parent. </param>
        public RichTextBox( Point location, Control parent = null )
            : this( )
        {
            Location = location;
            if( parent != null )
            {
                Parent = parent;
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextBox"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="parent"> The parent. </param>
        public RichTextBox( Size size, Control parent = null )
            : this( )
        {
            Size = size;
            if( parent != null )
            {
                Parent = parent;
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextBox"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        /// <param name="parent"> The parent. </param>
        public RichTextBox( Size size, Point location, Control parent )
            : this( )
        {
            Size = size;
            Location = location;
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextBox"/>
        /// class.
        /// </summary>
        /// <param name="title"> The title. </param>
        public RichTextBox( string title )
            : this( )
        {
            Text = title;
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

        /// <summary> Sets the font style. </summary>
        /// <param name="fontFamily"> The font family. </param>
        /// <param name="fontColor"> The backColor. </param>
        /// <param name="fontSize"> Size of the font. </param>
        public void SetFontStyle( string fontFamily, Color fontColor, int fontSize = 10 )
        {
            if( !string.IsNullOrEmpty( fontFamily )
               && fontColor != Color.Empty )
            {
                try
                {
                    Font = new Font( fontFamily, fontSize );
                    ForeColor = fontColor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the backColor of the back. </summary>
        /// <param name="backColor"> The backColor. </param>
        public void SetBackColor( Color backColor )
        {
            if( backColor != Color.Empty )
            {
                try
                {
                    BackColor = backColor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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