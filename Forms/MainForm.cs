// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
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
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public partial class MainForm : MetroForm
    {
        /// <summary> Gets or sets the tiles. </summary>
        /// <value> The tiles. </value>
        public IEnumerable<Tile> Tiles { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MainForm"/>
        /// class.
        /// </summary>
        public MainForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Name = "Main";
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;
            ExitButton.HoverText = "Exit Application";
            Tiles = GetTiles( );

            // Event Wiring
            ExitButton.Click += null;
            DatabaseTile.Click += OnDatabaseTileClicked;
            UtilityTile.Click += OnUtilityTileClicked;
            ReportingTile.Click += OnReportingTileClicked;
            ClientTile.Click += OnClientTileClicked;
            GuidanceTile.Click += OnGuidanceTileClicked;
            WebTile.Click += OnWebTileClicked;
            ExitButton.Click += OnExitButtonClicked;
            TestButton.Click += OnTestButtonClick;
            Load += OnLoad;
            Shown += OnShown;
            MouseClick += OnRightClick;
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetTileProperties( );
                SetTileText( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Gets the tiles. </summary>
        /// <returns> </returns>
        private IEnumerable<Tile> GetTiles( )
        {
            try
            {
                var _tiles = new List<Tile>( );
                for( var i = 0; i < Controls.Count; i++ )
                {
                    var control = Controls[ i ];
                    if( control.GetType( ) == typeof( Tile ) )
                    {
                        var _tile = control as Tile;
                        _tiles.Add( _tile );
                    }
                }

                return _tiles?.Any( ) == true
                    ? _tiles
                    : Enumerable.Empty<Tile>( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<Tile> );
            }
        }

        /// <summary> Sets the tile titles. </summary>
        private void SetTileText( )
        {
            try
            {
                DatabaseTile.Title.Text = "Data Management";
                DatabaseTile.Body.Text = string.Empty;
                DatabaseTile.Banner.Text = "Schema, Records";
                UtilityTile.Title.Text = "Utilities";
                UtilityTile.Body.Text = string.Empty;
                UtilityTile.Banner.Text = "Calculator, Calendar";
                ReportingTile.Title.Text = "Reporting";
                ReportingTile.Body.Text = string.Empty;
                ReportingTile.Banner.Text = "Charts, Graphs";
                ClientTile.Title.Text = "DB Clients";
                ClientTile.Body.Text = string.Empty;
                ClientTile.Banner.Text = "SQLite, SQL Server, Access";
                GuidanceTile.Title.Text = "Guidance";
                GuidanceTile.Body.Text = string.Empty;
                GuidanceTile.Banner.Text = "RMDS 2520, OMB A-11";
                WebTile.Title.Text = "Web Resource";
                WebTile.Body.Text = string.Empty;
                WebTile.Banner.Text = "Web Clients, Browsers";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the tile properties. </summary>
        private void SetTileProperties( )
        {
            try
            {
                if( Tiles?.Any( ) == true )
                {
                    foreach( var tile in Tiles )
                    {
                        tile.Size = new Size( 178, 108 );
                        tile.Title.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        tile.Body.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        tile.Footer.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        tile.Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        tile.TurnLiveTileOn = true;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Shows the selection dialog. </summary>
        private void ShowSelectionDialog( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Opens the chart data form. </summary>
        private void OpenChartDataForm( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Opens the excel data form. </summary>
        private void OpenExcelDataForm( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OpenPdfForm( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Opens the data grid form. </summary>
        private void OpenDataGridForm( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [database tile clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnDatabaseTileClicked( object sender, EventArgs e )
        {
            try
            {
                OpenDataGridForm( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [reporting tile clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnReportingTileClicked( object sender, EventArgs e )
        {
            try
            {
                OpenChartDataForm( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [client tile clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnClientTileClicked( object sender, EventArgs e )
        {
            try
            {
                ShowSelectionDialog( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [utility tile clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnUtilityTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                var _notification = new Notification( _msg );
                _notification.Show( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [guidance tile clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnGuidanceTileClicked( object sender, EventArgs e )
        {
            try
            {
                OpenPdfForm( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [tool tile clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnWebTileClicked( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [exit button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnExitButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnTestButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _loader = new LoadingForm( Status.Processing );
                _loader.StartPosition = FormStartPosition.CenterParent;
                _loader.ShowDialog( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [right click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    ContextMenu.Show( this, e.Location );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [shown]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}