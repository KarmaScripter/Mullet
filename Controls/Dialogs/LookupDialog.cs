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

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class LookupDialog : EditBase
    {
        /// <summary> Gets the table prefix. </summary>
        /// <value> The table prefix. </value>
        public string TablePrefix { get; } = " Tables : ";

        /// <summary> Gets the column prefix. </summary>
        /// <value> The column prefix. </value>
        public string ColumnPrefix { get; } = " Columns : ";

        /// <summary> Gets the value prefix. </summary>
        /// <value> The value prefix. </value>
        public string ValuePrefix { get; } = " Values : ";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LookupDialog"/>
        /// class.
        /// </summary>
        public LookupDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1310, 646 );
            Panels = GetPanels( );
            RadioButtons = GetRadioButtons( );
            TabControl.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
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
                FormFilter = new Dictionary<string, object>
                {
                    { "BFY", "2022" },
                    { "FundCode", "B" }
                };

                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, FormFilter );
                BindingSource.DataSource = DataModel.DataTable;
                PopulateTableListBoxItems( );
                SourceTable.CaptionText = TablePrefix + TableListBox.Items.Count;
                ColumnTable.CaptionText = ColumnPrefix;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Populates the table ListBox items. </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data?.Where( dr => dr.Field<string>( "Model" ).Equals( "EXECUTION" ) )?.Select( dr => dr.Field<string>( "TableName" ) )?.ToList( );
                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var name = _names[ _i ];
                    TableListBox.Items.Add( name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [table ListBox selection changed]. </summary>
        /// <param name="sender"> The sender. </param>
        public void OnTableListBoxSelectionChanged( object sender )
        {
            try
            {
                FormFilter.Clear( );
                ColumnListBox.Items.Clear( );
                ValueListBox.Items.Clear( );
                ColumnTable.CaptionText = string.Empty;
                ValueTable.CaptionText = string.Empty;
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    var _columns = DataModel.GetDataColumns( );
                    foreach( var col in _columns )
                    {
                        ColumnListBox.Items.Add( col.ColumnName );
                    }

                    ColumnTable.CaptionText = ColumnPrefix + ColumnListBox.Items.Count;
                    ValueTable.CaptionText = ValuePrefix;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [column ListBox selection changed]. </summary>
        /// <param name="sender"> The sender. </param>
        public void OnColumnListBoxSelectionChanged( object sender )
        {
            try
            {
                ValueListBox.Items.Clear( );
                var _listBox = sender as ListBox;
                var _column = _listBox?.SelectedItem?.ToString( );
                var _series = DataModel.DataElements;
                if( !string.IsNullOrEmpty( _column ) )
                {
                    foreach( var item in _series[ _column ] )
                    {
                        ValueListBox.Items.Add( item );
                    }
                }

                ValueTable.CaptionText = ValuePrefix + ValueListBox.Items.Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}