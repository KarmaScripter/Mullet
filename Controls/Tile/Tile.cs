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
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.TileBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Tile : TileBase
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Tile"/>
        /// class.
        /// </summary>
        public Tile( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightSteelBlue;
            Size = new Size( 178, 108 );
            MinimumSize = new Size( 100, 100 );
            Font = new Font( "Roboto", 9 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            Dock = DockStyle.None;
            TileType = HubTileType.DefaultTile;
            Title.Font = new Font( "Roboto", 9, FontStyle.Regular );
            Title.TextColor = Color.FromArgb( 0, 120, 212 );
            Body.TextColor = Color.DarkGray;
            Body.Font = new Font( "Roboto", 9 );
            Footer.TextColor = Color.DarkGray;
            Footer.Font = new Font( "Roboto", 8 );
            SlideTransition = TransitionDirection.RightToLeft;
            ShowBanner = true;
            BannerColor = Color.Transparent;
            BannerHeight = 30;
            ShowBannerIcon = true;
            Banner.Font = new Font( "Roboto", 8 );
            Banner.TextColor = Color.DarkGray;
            HoveredBorderColor = Color.FromArgb( 17, 53, 84 );
            HoverColor = Color.FromArgb( 17, 53, 84 );
            HoverBorderLength = 1;
            EnableHoverColor = true;
            EnableSelectionMarker = false;
            Visible = true;
            Enabled = true;
            TurnLiveTileOn = true;

            // Event Wiring
            MouseEnter += OnMouseEnter;
            MouseLeave += OnMouseLeave;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Tile"/>
        /// class.
        /// </summary>
        /// <param name="type"> The type. </param>
        public Tile( HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            TileType = type;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Tile"/>
        /// class.
        /// </summary>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        public Tile( string name, HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            Name = name;
            TileType = type;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Tile"/>
        /// class.
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="size"> The size. </param>
        /// <param name="type"> The type. </param>
        public Tile( Point location, Size size, HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            Size = size;
            Location = location;
            TileType = type;
        }

        /// <summary> Called when [mouse enter]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnMouseEnter( object sender, EventArgs e )
        {
            try
            {
                BackColor = Color.FromArgb( 17, 53, 84 );
                HoveredBorderColor = Color.FromArgb( 0, 120, 212 );
                Title.Font = new Font( "Roboto", 10, FontStyle.Regular );
                Title.TextColor = Color.White;
                Body.Font = new Font( "Roboto", 9, FontStyle.Regular );
                Body.TextColor = Color.White;
                Footer.Font = new Font( "Roboto", 9, FontStyle.Regular );
                Footer.TextColor = Color.White;
                Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
                Banner.TextColor = Color.White;
                Refresh( );
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
        private void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                BackColor = Color.FromArgb( 20, 20, 20 );
                HoveredBorderColor = Color.FromArgb( 0, 120, 212 );
                Title.Font = new Font( "Roboto", 9, FontStyle.Regular );
                Title.TextColor = Color.FromArgb( 0, 120, 212 );
                Body.Font = new Font( "Roboto", 9, FontStyle.Regular );
                Body.TextColor = Color.DarkGray;
                Footer.Font = new Font( "Roboto", 8, FontStyle.Regular );
                Footer.TextColor = Color.DarkGray;
                Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
                Banner.TextColor = Color.DarkGray;
                Refresh( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}