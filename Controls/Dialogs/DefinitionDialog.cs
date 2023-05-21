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
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="EditBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class DefinitionDialog : EditBase
    {
        /// <summary> Gets or sets the sqlite data types. </summary>
        /// <value> The sqlite data types. </value>
        public override IEnumerable<string> DataTypes { get; set; }

        public override string SelectedTable { get; set; }

        public Provider SelectedProvider { get; set; }

        public string SelectedType { get; set; }

        public string ColumnName { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DefinitionDialog"/>
        /// class.
        /// </summary>
        public DefinitionDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1310, 646 );
            SqliteRadioButton.Tag = "SQLite";
            SqlServerRadioButton.Tag = "SqlServer";
            AccessRadioButton.Tag = "Access";
            TabPage.TabFont = new Font( "Roboto", 8, FontStyle.Regular );
            TabPage.TabForeColor = Color.FromArgb( 0, 120, 212 );
            TabControl.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            DataTypeComboBox.BackgroundColor = Color.FromArgb( 40, 40, 40 );
            TableNameComboBox.BackgroundColor = Color.FromArgb( 40, 40, 40 );

            // Populate Controls
            TabPages = GetTabPages( );
            Panels = GetPanels( );
            ListBoxes = GetListBoxes( );
            RadioButtons = GetRadioButtons( );
            ComboBoxes = GetComboBoxes( );

            // Wire Events
            AccessRadioButton.CheckedChanged += OnProviderButtonChecked;
            SqlServerRadioButton.CheckedChanged += OnProviderButtonChecked;
            SqliteRadioButton.CheckedChanged += OnProviderButtonChecked;
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            TabPage.MouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DefinitionDialog"/>
        /// class.
        /// </summary>
        /// <param name="toolType"> Type of the tool. </param>
        public DefinitionDialog( ToolType toolType )
            : this( )
        {
            ToolType = toolType;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DefinitionDialog"/>
        /// class.
        /// </summary>
        /// <param name="toolType"> Type of the tool. </param>
        /// <param name="bindingSource"> The binding source. </param>
        public DefinitionDialog( ToolType toolType, BindingSource bindingSource )
            : this( toolType )
        {
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = DataTable;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            Columns = DataTable.GetColumnNames( );
        }

        /// <summary> Called when [visible]. </summary>
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
                CloseButton.Text = "Exit";
                DataTypes = GetDataTypes( Provider );
                PopulateTableComboBoxItems( );
                PopulateDataTypeComboBoxItems( );
                SetActiveTab( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Populates the table ListBox items. </summary>
        public void PopulateTableComboBoxItems( )
        {
            try
            {
                TableNameComboBox.Items.Clear( );
                TableNameComboBox.SelectedItem = string.Empty;
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data?.Where( dr => dr.Field<string>( "Model" ).Equals( "EXECUTION" ) )?.Select( dr => dr.Field<string>( "TableName" ) )?.ToList( );
                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var name = _names[ _i ];
                    TableNameComboBox.Items.Add( name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Populates the data type combo boxes. </summary>
        public void PopulateDataTypeComboBoxItems( )
        {
            if( DataTypes?.Any( ) == true )
            {
                try
                {
                    DataTypeComboBox.Items.Clear( );
                    DataTypeComboBox.SelectedText = string.Empty;
                    var _types = DataTypes.ToArray( );
                    for( var i = 0; i < _types?.Length; i++ )
                    {
                        if( !string.IsNullOrEmpty( _types[ i ] ) )
                        {
                            DataTypeComboBox.Items.Add( _types[ i ] );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [provider button checked]. </summary>
        /// <param name="sender"> The sender. </param>
        public virtual void OnProviderButtonChecked( object sender )
        {
            if( sender is RadioButton button )
            {
                try
                {
                    var _name = button.Tag?.ToString( );
                    if( !string.IsNullOrEmpty( _name ) )
                    {
                        Provider = (Provider)Enum.Parse( typeof( Provider ), _name );
                        DataTypes = GetDataTypes( Provider );
                        PopulateDataTypeComboBoxItems( );
                        PopulateTableComboBoxItems( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the activet tab. </summary>
        public void SetActiveTab( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    switch( ToolType )
                    {
                        case ToolType.AddColumnButton:
                        {
                            ActiveTab = TabPage;
                            AccessRadioButton.Checked = true;
                            break;
                        }
                        case ToolType.AddDatabaseButton:
                        {
                            ActiveTab = TabPage;
                            AccessRadioButton.Checked = true;
                            break;
                        }
                        case ToolType.AddTableButton:
                        {
                            ActiveTab = TabPage;
                            AccessRadioButton.Checked = true;
                            break;
                        }
                        case ToolType.EditColumnButton:
                        {
                            ActiveTab = TabPage;
                            AccessRadioButton.Checked = true;
                            break;
                        }
                        case ToolType.DeleteColumnButton:
                        {
                            ActiveTab = TabPage;
                            AccessRadioButton.Checked = true;
                            break;
                        }
                        case ToolType.DeleteTableButton:
                        {
                            ActiveTab = TabPage;
                            AccessRadioButton.Checked = true;
                            break;
                        }
                        case ToolType.DeleteDatabaseButton:
                        {
                            ActiveTab = TabPage;
                            AccessRadioButton.Checked = true;
                            break;
                        }
                        default:
                        {
                            ActiveTab = TabPage;
                            AccessRadioButton.Checked = true;
                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Gets the tab pages. </summary>
        /// <returns> </returns>
        public IDictionary<string, TabPageAdv> GetTabPages( )
        {
            if( TabControl?.TabPages?.Count > 0 )
            {
                try
                {
                    var _tabPages = new Dictionary<string, TabPageAdv>( );
                    foreach( TabPageAdv page in TabControl.TabPages )
                    {
                        if( page != null
                           && !string.IsNullOrEmpty( page.Name ) )
                        {
                            _tabPages.Add( page.Name, page );
                        }
                    }

                    return _tabPages?.Any( ) == true
                        ? _tabPages
                        : default( IDictionary<string, TabPageAdv> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
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