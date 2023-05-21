// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.HTMLUI;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class WebPage : MetroForm
    {
        /// <summary> Gets or sets the web address. </summary>
        /// <value> The web address. </value>
        public Uri WebAddress { get; set; }

        /// <summary> Gets or sets the file path. </summary>
        /// <value> The file path. </value>
        public string FilePath { get; set; }

        /// <summary> Gets or sets the folder path. </summary>
        /// <value> The folder path. </value>
        public string FolderPath { get; set; }

        /// <summary> Gets or sets the base address. </summary>
        /// <value> The base address. </value>
        public Uri BaseAddress { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="WebPage"/>
        /// class.
        /// </summary>
        public WebPage( )
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
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // WebControl Properties
            WebControl = new HTMLUIControl( );

            // Event Wiring
            Load += OnLoad;
            Shown += OnShown;
            Closing += OnClose;
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
                Text = @"Budget Execution";
                BackButton.Click += OnBackButtonClicked;
                MenuButton.Click += OnMainMenuButtonClicked;
                ToolStrip.Office12Mode = true;
                ToolStrip.ShowCaption = true;
                ToolStrip.Text = string.Empty;
                PopulateToolBarDropDownItems( );
                FilePath = @"C:\Users\terry\source\repos\Budget\Resource\WebPages\index.html";
                FolderPath = @"C:\Users\terry\source\repos\Budget\Resource\WebPages";
                WebAddress = new Uri( @"https://www.google.com/" );
                WebControl.StartupDocument = FilePath;
                WebControl.StartupFolder = FolderPath;
                var _stream = File.Open( FilePath, FileMode.Open );
                WebControl.LoadHTML( WebAddress );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Populates the tool bar drop down items. </summary>
        public void PopulateToolBarDropDownItems( )
        {
            try
            {
                var _names = Enum.GetNames( typeof( Level ) );
                for( var _i = 0; _i < _names.Length; _i++ )
                {
                    if( _names[ _i ] != "NS" )
                    {
                        DropDown.Items.Add( _names[ _i ] );
                    }
                }
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
                if( Owner != null
                   && Owner.Visible == false
                   && Owner.GetType( ) == typeof( MainForm ) )
                {
                    Owner.Visible = true;
                }
                else if( Owner != null
                        && Owner.Visible == false
                        && Owner.GetType( ) != typeof( MainForm ) )
                {
                    Owner.Close( );
                    var _mainForm = Program.Windows[ "Main" ];
                    _mainForm.Visible = true;
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
                    Visible = false;
                }
                else if( Owner != null
                        && Owner.Visible == false
                        && Owner.GetType( ) != typeof( MainForm ) )
                {
                    Owner.Close( );
                    var _mainForm = Program.Windows[ "Main" ];
                    _mainForm.Refresh( );
                    _mainForm.Visible = true;
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
                }
                else
                {
                    var _dataGridForm = new DataGridForm( BindingSource );
                    _dataGridForm.Owner = this;
                    _dataGridForm.Show( );
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
                }
                else
                {
                    var _chartDataForm = new ChartDataForm( BindingSource );
                    _chartDataForm.Owner = this;
                    _chartDataForm.Show( );
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
                }
                else
                {
                    var _excelDataForm = new ExcelDataForm( BindingSource );
                    _excelDataForm.Owner = this;
                    _excelDataForm.Show( );
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
                if( !Program.Windows.ContainsKey( Name ) )
                {
                    Program.Windows.Add( Name, this );
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
        private void OnClose( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( Name ) )
                {
                    Program.Windows.Remove( Name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static protected private void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}