// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public partial class ProgramProjectDialog : MetroForm
    {
        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public Provider Provider { get; set; }

        /// <summary> Gets or sets the data model. </summary>
        /// <value> The data model. </value>
        public DataBuilder DataModel { get; set; }

        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public DataTable DataTable { get; set; }

        /// <summary> Gets or sets the form filter. </summary>
        /// <value> The form filter. </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary> Gets or sets the selected value. </summary>
        /// <value> The selected value. </value>
        public string SelectedValue { get; set; }

        /// <summary> Gets or sets the SQL query. </summary>
        /// <value> The SQL query. </value>
        public string SqlQuery { get; set; }

        /// <summary> Gets or sets the select project. </summary>
        /// <value> The select project. </value>
        public string SelectedProgram { get; set; }

        /// <summary> Gets or sets the current. </summary>
        /// <value> The current. </value>
        public DataRow Current { get; set; }

        /// <summary> Gets or sets the program codes. </summary>
        /// <value> The program codes. </value>
        public IEnumerable<string> ProgramCodes { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProjectDialog"/>
        /// class.
        /// </summary>
        public ProgramProjectDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 908, 614 );
            MaximumSize = new Size( 908, 614 );
            MinimumSize = new Size( 908, 614 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 2;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterParent;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // Bind DataSource
            Source = Source.ProgramProjectDescriptions;
            Provider = Provider.Access;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            BindingSource.CurrentChanged += UpdateHeaderTitle;
            SearchButton.Click += OnSearchButtonClicked;
            MouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProjectDialog"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public ProgramProjectDialog( string code )
            : this( )
        {
            SelectedProgram = code;
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                FormFilter = new Dictionary<string, object>( );
                DataModel = new DataBuilder( Source, Provider );
                DataTable = DataModel.DataTable;
                BindingSource.DataSource = DataTable;
                Current = BindingSource.GetCurrentDataRow( );
                Header.ForeColor = Color.FromArgb( 0, 120, 212 );
                Header.Text = Current[ "ProgramTitle" ].ToString( );
                if( !string.IsNullOrEmpty( SelectedProgram ) )
                {
                    FormFilter.Add( "Code", SelectedProgram );
                    BindingSource.Filter = FormFilter.ToCriteria( );
                }

                DescriptionTable.CaptionText = "Program Description";
                BindData( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [close button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnCloseButtonClicked( object sender, EventArgs e )
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

        /// <summary> Called when [previous button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnSearchButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _keywords = StatutoryAuthorityTextBox.Text;
                var _search = new GoogleSearch( _keywords );
                var _list = _search.GetResults( );
                ProgramDescriptionTextBox.Text = string.Empty;
                var _results = new StringBuilder( );
                foreach( var item in _list )
                {
                    _results.Append( "Title : " );
                    _results.Append( item.Title );
                    _results.Append( Environment.NewLine );
                    _results.Append( "Link : " );
                    _results.Append( item.Link );
                    _results.Append( Environment.NewLine );
                    _results.Append( Environment.NewLine );
                }

                DescriptionTable.CaptionText = "Web Search Results";
                ProgramDescriptionTextBox.Text = _results.ToString( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void ClearHeaderText( )
        {
            try
            {
                Header.Text = string.Empty;
                ProgramAreaTable.CaptionText = "Program Area - ";
                ProgramProjectTable.CaptionText = "Program Project - ";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Gets the current program title. </summary>
        private void UpdateHeaderTitle( object sender, EventArgs e )
        {
            try
            {
                var _data = BindingSource.GetCurrentDataRow( );
                Header.Text = _data[ "ProgramTitle" ].ToString( );
                ProgramAreaTable.CaptionText = "Program Area - " + _data[ "ProgramAreaCode" ];
                ProgramProjectTable.CaptionText = "Program Project - " + _data[ "Code" ];
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Creates the bindings. </summary>
        private void BindData( )
        {
            if( BindingSource != null )
            {
                try
                {
                    var _programAreaName = new Binding( "Text", BindingSource, "ProgramAreaName" );
                    ProgramAreaNameTextBox.DataBindings.Add( _programAreaName );
                    var _programProjectName = new Binding( "Text", BindingSource, "Name" );
                    ProgramProjectNameTextBox.DataBindings.Add( _programProjectName );
                    var _laws = new Binding( "Text", BindingSource, "Laws" );
                    StatutoryAuthorityTextBox.DataBindings.Add( _laws );
                    var _description = new Binding( "Text", BindingSource, "Description" );
                    ProgramDescriptionTextBox.DataBindings.Add( _description );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}