// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Pdf.Parsing;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    public partial class PdfForm : MetroForm
    {
        /// <summary> Gets or sets the file path. </summary>
        /// <value> The file path. </value>
        public string FilePath { get; set; }

        /// <summary> Gets or sets the directory path. </summary>
        /// <value> The directory path. </value>
        public string DirectoryPath { get; set; }

        /// <summary> Gets or sets the name of the file. </summary>
        /// <value> The name of the file. </value>
        public string FileName { get; set; }

        /// <summary> Gets or sets the document. </summary>
        /// <value> The document. </value>
        public PdfLoadedDocument Document { get; set; }

        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PdfForm"/>
        /// class.
        /// </summary>
        public PdfForm( )
        {
            InitializeComponent( );

            // Basic Properties
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderThickness = 2;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            StartPosition = FormStartPosition.CenterScreen;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarHeight = 5;
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;

            // Event Wiring
            CloseButton.Click += OnCloseButtonClick;
            MenuButton.Click += OnMainMenuButtonClicked;
            BackButton.Click += OnBackButtonClicked;
            DataGridButton.Click += OnDataGridButtonClick;
            ChartButton.Click += OnChartButtonClick;
            ExcelButton.Click += OnExcelButtonClick;
            ListBox.SelectedValueChanged += OnListBoxItemSelected;
            Load += OnLoad;
            Shown += OnShown;
            Closing += OnClosing;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PdfForm"/>
        /// class.
        /// </summary>
        /// <param name="filePath"> The file path. </param>
        public PdfForm( string filePath )
            : this( )
        {
            FilePath = filePath;
            FileName = Path.GetFileName( filePath );
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
                DirectoryPath = ConfigurationManager.AppSettings[ "Documents" ];
                var _path = DirectoryPath + @"\\ApplicationLandingDocument.pdf";
                HeaderLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
                HeaderLabel.Text = "Budget Guidance";
                DataTable = new DataBuilder( Source.Resources, Provider.Access ).DataTable;
                Document = new PdfLoadedDocument( _path );
                DocViewer.Load( Document );
                PopulateItems( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [main menu button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                OpenMainForm( );
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

        /// <summary> Populates the table buttons. </summary>
        private void PopulateItems( )
        {
            try
            {
                var _criteria = new Dictionary<string, object>( );
                _criteria.Add( "FileExtension", "PDF" );
                var _dataRows = DataTable.Filter( _criteria );
                foreach( var row in _dataRows )
                {
                    var _name = row[ "Caption" ].ToString( );
                    ListBox.Items.Add( _name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Opens the main form. </summary>
        private void OpenMainForm( )
        {
            try
            {
                if( Owner != null
                   && Owner.Visible == false
                   && Owner.GetType( ) == typeof( MainForm ) )
                {
                    Owner.Visible = true;
                    Close( );
                }
                else if( Owner != null
                        && Owner.Visible == false
                        && Owner.GetType( ) != typeof( MainForm ) )
                {
                    var _mainForm = Program.Windows[ "MainForm" ];
                    _mainForm.Visible = true;
                    Owner.Close( );
                    Close( );
                }
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
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( ExcelDataForm ) ) == true )
                {
                    var _excelDataForm = _forms?.Where( f => f.GetType( ) == typeof( ExcelDataForm ) )?.First( );
                    _excelDataForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _excelDataForm = new ExcelDataForm( BindingSource );
                    _excelDataForm.Owner = this;
                    _excelDataForm.Show( );
                    Visible = false;
                }
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
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( DataGridForm ) ) == true )
                {
                    var _dataGridForm = _forms?.Where( f => f.GetType( ) == typeof( DataGridForm ) )?.First( );
                    _dataGridForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _dataGridForm = new DataGridForm( );
                    _dataGridForm.Owner = this;
                    _dataGridForm.Show( );
                    Visible = false;
                }
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
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( ChartDataForm ) ) == true )
                {
                    var _chartDataForm = _forms?.Where( f => f.GetType( ) == typeof( ChartDataForm ) )?.First( );
                    _chartDataForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _chartDataForm = new ChartDataForm( BindingSource );
                    _chartDataForm.Owner = this;
                    _chartDataForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [data grid button click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnDataGridButtonClick( object sender, EventArgs e )
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

        private void OnExcelButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenExcelDataForm( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnChartButtonClick( object sender, EventArgs e )
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

        /// <summary> Called when [close button click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( Owner != null
                   && Owner.Visible == false )
                {
                    Owner.Visible = true;
                    Owner.Refresh( );
                    Close( );
                }
                else
                {
                    Close( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [back button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( Owner != null
                   && Owner.Visible == false )
                {
                    Owner.Visible = true;
                    Owner.Refresh( );
                    Visible = false;
                }
                else
                {
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                if( !Program.Windows.ContainsKey( "PdfForm" ) )
                {
                    Program.Windows.Add( "PdfForm", this );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Raises the Close event. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnClosing( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( "PdfForm" ) )
                {
                    Program.Windows.Remove( "PdfForm" );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [button click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox listBox
               && DataTable != null )
            {
                try
                {
                    var _data = DataTable.AsEnumerable( );
                    var _caption = listBox.SelectedValue.ToString( );
                    var _file = _data?.Where( p => p.Field<string>( "Caption" ).Equals( _caption ) )?.Select( p => p.Field<string>( "Location" ) )?.Single( );
                    var _prefix = @"C:\Users\terry\source\repos\Budget\";
                    HeaderLabel.Text = _caption;
                    var _path = _prefix + _file;
                    Document = new PdfLoadedDocument( _path );
                    DocViewer.Load( Document );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}