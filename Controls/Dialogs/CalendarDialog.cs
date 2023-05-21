// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.CellGrid.Helpers;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public partial class CalendarDialog : MetroForm
    {
        /// <summary> Gets or sets the selected date. </summary>
        /// <value> The selected date. </value>
        public string DateString { get; set; }

        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public DataSet Data { get; set; }

        /// <summary> Gets or sets the holidays. </summary>
        /// <value> The holidays. </value>
        public DataTable Holidays { get; set; }

        /// <summary> Gets or sets the fiscal years. </summary>
        /// <value> The fiscal years. </value>
        public DataTable FiscalYears { get; set; }

        /// <summary> Gets or sets the data model. </summary>
        /// <value> The data model. </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CalendarDialog"/>
        /// class.
        /// </summary>
        public CalendarDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Size = new Size( 446, 373 );
            MinimumSize = new Size( 446, 373 );
            MaximumSize = new Size( 446, 373 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.DarkGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 2;
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;

            // Close Button
            CloseButton.NormalTextColor = Color.FromArgb( 20, 20, 20 );
            CloseButton.HoverTextColor = Color.White;
            CloseButton.HoverBorderColor = Color.FromArgb( 50, 93, 129 );
            CloseButton.Text = "Close";
            CloseButton.HoverText = "Close Calendar";

            // HeaderLabel Settings
            HeaderLabel.Font = new Font( "Roboto", 11 );
            HeaderLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Event Wiring
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CalendarDialog"/>
        /// class.
        /// </summary>
        /// <param name="dateTime"> The date time. </param>
        public CalendarDialog( DateTime dateTime )
            : this( )
        {
            DateString = dateTime.ToString( );
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
                CloseButton.ForeColor = Color.FromArgb( 20, 20, 20 );
                CloseButton.Click += OnCloseButtonClicked;
                Calendar.SelectionChanged += OnSelectionChanged;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Gets the federal holidays. </summary>
        /// <returns> </returns>
        private DataTable GetFederalHolidays( )
        {
            try
            {
                var _data = new DataBuilder( Source.FederalHolidays, Provider.Access );
                var _table = _data.DataTable;
                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataTable );
            }
        }

        /// <summary> Gets the fiscal years. </summary>
        /// <returns> </returns>
        private DataTable GetFiscalYears( )
        {
            try
            {
                var _data = new DataBuilder( Source.FiscalYears, Provider.Access );
                var _table = _data.DataTable;
                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataTable );
            }
        }

        /// <summary> Called when [close button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCloseButtonClicked( object sender, EventArgs e )
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

        /// <summary> Called when [selection changed]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="SelectionChangedEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                var _date = Calendar.SelectedDate;
                DateString = _date.ToString( );
                Close( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}