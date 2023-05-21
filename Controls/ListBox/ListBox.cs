﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ListBox : MetroSetListBox
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
        /// <see cref="ListBox"/>
        /// class.
        /// </summary>
        public ListBox( )
        {
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Size = new Size( 200, 100 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 1 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 8 );
            ForeColor = Color.LightGray;
            Enabled = true;
            Visible = true;

            // BackColor SeriesConfiguration
            BackColor = Color.FromArgb( 40, 40, 40 );
            ShowBorder = false;
            BorderColor = Color.FromArgb( 55, 55, 55 );

            // Disabled Color Configuration
            DisabledBackColor = Color.FromArgb( 20, 20, 20 );
            DisabledForeColor = Color.FromArgb( 20, 20, 20 );

            // Item Configuration
            ItemHeight = 28;
            MultiSelect = true;
            HoveredItemColor = Color.White;
            HoveredItemBackColor = Color.FromArgb( 17, 53, 84 );
            SelectedItemColor = Color.White;
            SelectedItemBackColor = Color.FromArgb( 0, 120, 212 );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListBox"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        public ListBox( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListBox"/>
        /// class.
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="parent"> The parent. </param>
        public ListBox( Point location, Control parent = null )
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
        /// <see cref="ListBox"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="parent"> The parent. </param>
        public ListBox( Size size, Control parent = null )
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
        /// <see cref="ListBox"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        /// <param name="parent"> The parent. </param>
        public ListBox( Size size, Point location, Control parent )
            : this( )
        {
            Size = size;
            Location = location;
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListBox"/>
        /// class.
        /// </summary>
        /// <param name="title"> The title. </param>
        public ListBox( string title )
            : this( )
        {
            Text = title;
        }

        /// <summary> Sets the color of the border. </summary>
        /// <param name="color"> The color. </param>
        public void SetBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    BorderColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [visible]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnVisible( object sender, EventArgs e )
        {
            try
            {
                ItemHeight = 30;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Adds the items. </summary>
        /// <param name="items"> The items. </param>
        public void AddItems( IEnumerable<object> items )
        {
            if( items?.Count( ) > -1 )
            {
                try
                {
                    foreach( var _item in items )
                    {
                        Items.Add( _item );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Adds the control item. </summary>
        /// <returns> </returns>
        public void AddItem( object item )
        {
            if( !string.IsNullOrEmpty( item?.ToString( ) ) )
            {
                try
                {
                    Items.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the hover information. </summary>
        /// <param name="text"> The text. </param>
        public void SetHoverText( string text )
        {
            if( !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    var _ = new SmallTip( this, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
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