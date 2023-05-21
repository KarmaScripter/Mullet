﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;
    using CheckState = MetroSet_UI.Enums.CheckState;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class SqlDialog : EditBase
    {
        /// <summary> Gets or sets the current. </summary>
        /// <value> The current. </value>
        public DataRow Current { get; set; }

        /// <summary> Gets or sets the frames. </summary>
        /// <value> The frames. </value>
        public IEnumerable<Frame> Frames { get; set; }

        /// <summary> Gets or sets the database folder. </summary>
        /// <value> The database folder. </value>
        public string DatabaseDirectory { get; set; }

        /// <summary> Gets or sets the selected command. </summary>
        /// <value> The selected command. </value>
        public string SelectedCommand { get; set; }

        /// <summary> Gets or sets the selected query. </summary>
        /// <value> The selected query. </value>
        public string SelectedQuery { get; set; }

        /// <summary> Gets or sets the commands. </summary>
        /// <value> The commands. </value>
        public IList<string> Commands { get; set; }

        /// <summary> Gets or sets the statements. </summary>
        /// <value> The statements. </value>
        public IDictionary<string, object> Statements { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlDialog"/>
        /// class.
        /// </summary>
        public SqlDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1310, 646 );
            TabPage.TabForeColor = Color.FromArgb( 0, 120, 212 );
            FirstButton.Text = "Save";
            ThirdButton.Text = "Exit";
            DatabaseDirectory = @"C:\Users\terry\source\repos\Budget\Data\Database\";

            // Event Wiring
            ThirdButton.Click += OnCloseButtonClicked;
            Load += OnLoad;
            MouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlDialog"/>
        /// class.
        /// </summary>
        /// <param name="bindingSource"> The binding source. </param>
        /// <param name="provider"> The provider. </param>
        public SqlDialog( BindingSource bindingSource, Provider provider = Provider.Access )
            : this( )
        {
            ToolType = ToolType.EditSqlButton;
            BindingSource = bindingSource;
            Provider = provider;
            DataTable = BindingSource.GetDataTable( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider );
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
            Commands = new List<string>( );
            Statements = new Dictionary<string, object>( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlDialog"/>
        /// class.
        /// </summary>
        /// <param name="toolType"> Type of the tool. </param>
        /// <param name="bindingSource"> The binding source. </param>
        /// <param name="provider"> The provider. </param>
        public SqlDialog( ToolType toolType, BindingSource bindingSource, Provider provider = Provider.Access )
            : this( )
        {
            ToolType = toolType;
            BindingSource = bindingSource;
            Provider = provider;
            DataTable = BindingSource.GetDataTable( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider );
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlDialog"/>
        /// class.
        /// </summary>
        /// <param name="toolType"> Type of the tool. </param>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        public SqlDialog( ToolType toolType, Source source, Provider provider = Provider.Access )
            : this( )
        {
            ToolType = toolType;
            Provider = provider;
            Source = source;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataModel.DataTable;
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
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
                AccessRadioButton.Checked = true;
                Commands = new List<string>( );
                Statements = new Dictionary<string, object>( );
                AccessRadioButton.Click += OnRadioButtonChecked;
                SQLiteRadioButton.Click += OnRadioButtonChecked;
                SqlCeRadioButton.Click += OnRadioButtonChecked;
                SqlServerRadioButton.Click += OnRadioButtonChecked;
                SqlComboBox.SelectedValueChanged += OnComboBoxItemSelected;
                SqlListBox.SelectedValueChanged += OnListBoxItemSelected;
                SecondButton.Click += OnClearButtonClick;
                SetEditorConfiguration( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Clears the selections. </summary>
        private void ClearSelections( )
        {
            try
            {
                SqlEditor.Text = string.Empty;
                Commands?.Clear( );
                Statements?.Clear( );
                Provider = Provider.Access;
                AccessRadioButton.CheckState = CheckState.Checked;
                Commands = CreateCommandList( Provider );
                PopulateSqlComboBox( Commands );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the provider. </summary>
        /// <param name="provider"> The provider. </param>
        private void SetProvider( string provider )
        {
            if( !string.IsNullOrEmpty( provider ) )
            {
                try
                {
                    var _provider = (Provider)Enum.Parse( typeof( Provider ), provider );
                    if( Enum.IsDefined( typeof( Provider ), _provider ) )
                    {
                        Commands.Clear( );
                        switch( _provider )
                        {
                            case Provider.Access:
                            {
                                Provider = Provider.Access;
                                AccessRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SQLite:
                            {
                                Provider = Provider.SQLite;
                                SQLiteRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SqlCe:
                            {
                                Provider = Provider.SqlCe;
                                SqlCeRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SqlServer:
                            {
                                Provider = Provider.SqlServer;
                                SqlServerRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            default:
                            {
                                Provider = Provider.Access;
                                SetProvider( Provider.ToString( ) );
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Populates the SQL ComboBox. </summary>
        /// <param name="list"> The list. </param>
        private void PopulateSqlComboBox( IList<string> list )
        {
            if( list?.Any( ) == true )
            {
                try
                {
                    var _commands = Enum.GetNames( typeof( SQL ) );
                    SqlComboBox.Items.Clear( );
                    SqlListBox.Items.Clear( );
                    for( var _i = 0; _i < list.Count; _i++ )
                    {
                        if( _commands.Contains( list[ _i ] )
                           && list[ _i ].Equals( $"{SQL.CREATEDATABASE}" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE DATABASE" );
                        }
                        else if( _commands.Contains( list[ _i ] )
                                && list[ _i ].Equals( $"{SQL.CREATETABLE}" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE TABLE" );
                        }
                        else if( _commands.Contains( list[ _i ] )
                                && list[ _i ].Equals( $"{SQL.ALTERTABLE}" ) )
                        {
                            SqlComboBox.Items.Add( "ALTER TABLE" );
                        }
                        else if( _commands.Contains( list[ _i ] )
                                && list[ _i ].Equals( $"{SQL.CREATEVIEW}" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE VIEW" );
                        }
                        else if( _commands.Contains( list[ _i ] )
                                && list[ _i ].Equals( $"{SQL.SELECTALL}" ) )
                        {
                            SqlComboBox.Items.Add( "SELECT ALL" );
                        }
                        else if( _commands.Contains( list[ _i ] ) )
                        {
                            SqlComboBox.Items.Add( list[ _i ] );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Gets the command list. </summary>
        /// <param name="provider"> The provider. </param>
        /// <returns> </returns>
        private IList<string> CreateCommandList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _path = DatabaseDirectory + $@"\{provider}\DataModels\";
                    var _names = Directory.GetDirectories( _path );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[ _i ] ).Name;
                        if( !string.IsNullOrEmpty( _folder ) )
                        {
                            _list.Add( _folder );
                        }
                    }

                    return _list?.Count > 0
                        ? _list
                        : default( IList<string> );
                }

                return default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Creates the query list. </summary>
        /// <param name="provider"> The provider. </param>
        /// <returns> </returns>
        private IList<string> CreateQueryList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _path = DatabaseDirectory + $@"\{provider}\DataModels\";
                    var _names = Directory.GetDirectories( _path );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[ _i ] ).Name;
                        if( !string.IsNullOrEmpty( _folder ) )
                        {
                            _list.Add( _folder );
                        }
                    }

                    return _list?.Count > 0
                        ? _list
                        : default( IList<string> );
                }

                return default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        private string GetQueryText( )
        {
            try
            {
                return string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary> Called when [RadioButton checked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnRadioButtonChecked( object sender, EventArgs e )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    var _tag = _button.Tag?.ToString( );
                    if( !string.IsNullOrEmpty( _tag ) )
                    {
                        SetProvider( _tag );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the editor configuration. </summary>
        private void SetEditorConfiguration( )
        {
            try
            {
                SqlEditor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                SqlEditor.AlwaysShowScrollers = true;
                SqlEditor.BackColor = SystemColors.ControlLight;
                SqlEditor.ForeColor = Color.Black;
                SqlEditor.BackgroundColor = new BrushInfo( SystemColors.ControlLight );
                SqlEditor.BorderStyle = BorderStyle.FixedSingle;
                SqlEditor.CanOverrideStyle = true;
                SqlEditor.CanApplyTheme = true;
                SqlEditor.ColumnGuidesMeasuringFont = new Font( "Roboto", 8 );
                SqlEditor.ContextChoiceFont = new Font( "Roboto", 8 );
                SqlEditor.ContextChoiceForeColor = Color.Black;
                SqlEditor.ContextChoiceBackColor = SystemColors.ControlLight;
                SqlEditor.ContextPromptBorderColor = Color.FromArgb( 0, 120, 212 );
                SqlEditor.ContextPromptBackgroundBrush = new BrushInfo( Color.FromArgb( 233, 166, 50 ) );
                SqlEditor.ContextTooltipBackgroundBrush = new BrushInfo( Color.FromArgb( 233, 166, 50 ) );
                SqlEditor.ContextTooltipBorderColor = Color.FromArgb( 0, 120, 212 );
                SqlEditor.EndOfLineBackColor = SystemColors.ControlLight;
                SqlEditor.EndOfLineForeColor = SystemColors.ControlLight;
                SqlEditor.HighlightCurrentLine = true;
                SqlEditor.IndentationBlockBorderColor = Color.FromArgb( 0, 120, 212 );
                SqlEditor.IndentLineColor = Color.FromArgb( 50, 93, 129 );
                SqlEditor.IndicatorMarginBackColor = SystemColors.ControlLight;
                SqlEditor.CurrentLineHighlightColor = Color.FromArgb( 0, 120, 212 );
                SqlEditor.Font = new Font( "Roboto", 12 );
                SqlEditor.LineNumbersColor = Color.Black;
                SqlEditor.LineNumbersFont = new Font( "Roboto", 8, FontStyle.Bold );
                SqlEditor.ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
                SqlEditor.ScrollColorScheme = Office2007ColorScheme.Black;
                SqlEditor.SelectionTextColor = Color.FromArgb( 50, 93, 129 );
                SqlEditor.ShowEndOfLine = false;
                SqlEditor.Style = EditControlStyle.Office2016Black;
                SqlEditor.TabSize = 4;
                SqlEditor.TextAreaWidth = 400;
                SqlEditor.WordWrap = true;
                SqlEditor.WordWrapColumn = 100;
                SqlEditor.Dock = DockStyle.None;
                SqlEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [ComboBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SelectedCommand = string.Empty;
                    var _selection = _comboBox.SelectedItem?.ToString( );
                    SqlListBox.Items.Clear( );
                    if( _selection?.Contains( " " ) == true )
                    {
                        SelectedCommand = _selection.Replace( " ", "" );
                        var _path = DatabaseDirectory + $@"\{Provider}\DataModels\{SelectedCommand}";
                        var _files = Directory.GetFiles( _path );
                        for( var _i = 0; _i < _files.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _files[ _i ] );
                            var _caption = _item?.SplitPascal( );
                            SqlListBox.Items.Add( _caption );
                        }
                    }
                    else
                    {
                        SelectedCommand = _comboBox.SelectedItem?.ToString( );
                        var _path = DatabaseDirectory + $@"\{Provider}\DataModels\{SelectedCommand}";
                        var _names = Directory.GetFiles( _path );
                        for( var _i = 0; _i < _names.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _names[ _i ] );
                            var _caption = _item?.SplitPascal( );
                            SqlListBox.Items.Add( _caption );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [ListBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    SqlEditor.Text = string.Empty;
                    SelectedQuery = _listBox.SelectedItem?.ToString( );
                    if( SelectedQuery?.Contains( " " ) == true
                       || SelectedCommand?.Contains( " " ) == true )
                    {
                        var _command = SelectedCommand?.Replace( " ", "" );
                        var _query = SelectedQuery?.Replace( " ", "" );
                        var _filePath = DatabaseDirectory + $@"\{Provider}\DataModels\{_command}\{_query}.sql";
                        var _stream = File.OpenRead( _filePath );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        SqlEditor.Text = _text;
                    }
                    else
                    {
                        var _path = DatabaseDirectory + $@"\{Provider}\DataModels\{SelectedCommand}\{SelectedQuery}.sql";
                        var _stream = File.OpenRead( _path );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        SqlEditor.Text = _text;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [clear button click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnClearButtonClick( object sender, EventArgs e )
        {
            try
            {
                ClearSelections( );
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
    }
}