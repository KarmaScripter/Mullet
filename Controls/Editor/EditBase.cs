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
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertTypeCheckPatternToNullCheck" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    public partial class EditBase : MetroForm
    {
        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public virtual Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public virtual Provider Provider { get; set; }

        /// <summary> Gets or sets the type of the command. </summary>
        /// <value> The type of the command. </value>
        public virtual SQL CommandType { get; set; }

        /// <summary> Gets or sets the type of the tool. </summary>
        /// <value> The type of the tool. </value>
        public virtual ToolType ToolType { get; set; }

        /// <summary> Gets or sets the active tab. </summary>
        /// <value> The active tab. </value>
        public virtual TabPageAdv ActiveTab { get; set; }

        /// <summary> Gets or sets the data model. </summary>
        /// <value> The data model. </value>
        public virtual DataBuilder DataModel { get; set; }

        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public virtual DataTable DataTable { get; set; }

        /// <summary> Gets or sets the columns. </summary>
        /// <value> The columns. </value>
        public virtual IEnumerable<string> Columns { get; set; }

        /// <summary> Gets or sets the fields. </summary>
        /// <value> The fields. </value>
        public virtual IList<string> Fields { get; set; }

        /// <summary> Gets or sets the numerics. </summary>
        /// <value> The numerics. </value>
        public virtual IList<string> Numerics { get; set; }

        /// <summary> Gets or sets the selected column. </summary>
        /// <value> The selected column. </value>
        public virtual string SelectedColumn { get; set; }

        /// <summary> Gets or sets the selected table. </summary>
        /// <value> The selected table. </value>
        public virtual string SelectedTable { get; set; }

        /// <summary> Gets or sets the form filter. </summary>
        /// <value> The form filter. </value>
        public virtual IDictionary<string, object> FormFilter { get; set; }

        /// <summary> Gets or sets the group boxes. </summary>
        /// <value> The group boxes. </value>
        public virtual IDictionary<string, Layout> Panels { get; set; }

        /// <summary> Gets or sets the list boxes. </summary>
        /// <value> The list boxes. </value>
        public virtual IDictionary<string, ListBox> ListBoxes { get; set; }

        /// <summary> Gets or sets the labels. </summary>
        /// <value> The labels. </value>
        public virtual IEnumerable<Label> Labels { get; set; }

        /// <summary> Gets or sets the tab pages. </summary>
        /// <value> The tab pages. </value>
        public virtual IDictionary<string, TabPageAdv> TabPages { get; set; }

        /// <summary> Gets or sets the radio buttons. </summary>
        /// <value> The radio buttons. </value>
        public virtual IDictionary<string, RadioButton> RadioButtons { get; set; }

        /// <summary> Gets or sets the combo boxes. </summary>
        /// <value> The combo boxes. </value>
        public virtual IDictionary<string, ComboBox> ComboBoxes { get; set; }

        /// <summary> Gets or sets the text boxes. </summary>
        /// <value> The text boxes. </value>
        public virtual IEnumerable<TextBox> TextBoxes { get; set; }

        /// <summary> Gets or sets the data types. </summary>
        /// <value> The data types. </value>
        public virtual IEnumerable<string> DataTypes { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="EditBase"/>
        /// class.
        /// </summary>
        public EditBase( )
        {
            InitializeComponent( );
            Size = new Size( 1310, 648 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            MetroColor = Color.FromArgb( 20, 20, 20 );
            BorderColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.Red;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarHeight = 26;
            CaptionFont = new Font( "Roboto", 11, FontStyle.Regular );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ShowIcon = false;
            ShowMouseOver = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            Text = string.Empty;
        }

        /// <summary> Gets the data types. </summary>
        /// <param name="provider"> The provider. </param>
        /// <returns> </returns>
        public virtual IEnumerable<string> GetDataTypes( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    var _query = "SELECT DISTINCT SchemaTypes.TypeName" + " FROM SchemaTypes" + $" WHERE SchemaTypes.Database = '{provider}'";
                    var _model = new DataBuilder( Source.SchemaTypes, Provider.Access, _query );
                    var _data = _model.DataTable.GetUniqueColumnValues( "TypeName" );
                    return _data?.Length > 0
                        ? _data
                        : default( IEnumerable<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary> Called when [close button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnCloseButtonClicked( object sender, EventArgs e )
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

        /// <summary> Populates the table ListBox items. </summary>
        /// <param name="listBox"> The list box. </param>
        public virtual void PopulateTableListBoxItems( ListBox listBox )
        {
            try
            {
                var _names = Enum.GetNames( typeof( Source ) );
                if( listBox?.Items.Count > 0 )
                {
                    listBox.Items.Clear( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var name = _names[ _i ];
                        if( name != "NS" )
                        {
                            listBox?.Items.Add( name );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Gets the radio buttons. </summary>
        /// <returns> </returns>
        public IDictionary<string, RadioButton> GetRadioButtons( )
        {
            if( TabPages?.Count > 0 )
            {
                try
                {
                    var _buttons = new Dictionary<string, RadioButton>( );
                    foreach( var _tabPage in TabPages.Values )
                    {
                        if( _tabPage is TabPageAdv _tab )
                        {
                            foreach( var _control in _tab.Controls )
                            {
                                if( _control is Layout _panel )
                                {
                                    foreach( var _item in _panel?.Controls )
                                    {
                                        if( _item is RadioButton _radioButton )
                                        {
                                            _buttons.Add( _radioButton.Name, _radioButton );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _buttons?.Any( ) == true
                        ? _buttons
                        : default( IDictionary<string, RadioButton> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary> Gets the combo boxes. </summary>
        /// <returns> </returns>
        public IDictionary<string, ComboBox> GetComboBoxes( )
        {
            if( TabPages?.Count > 0 )
            {
                try
                {
                    var _buttons = new Dictionary<string, ComboBox>( );
                    foreach( var _tabPage in TabPages.Values )
                    {
                        if( _tabPage is TabPageAdv _tab )
                        {
                            for( var _i = 0; _i < _tab.Controls.Count; _i++ )
                            {
                                var _control = _tab.Controls[ _i ];
                                if( _control.Controls.Count > 0 )
                                {
                                    foreach( Control _subControl in _control.Controls )
                                    {
                                        if( _subControl is ComboBox _comboBox )
                                        {
                                            _buttons.Add( _comboBox.Name, _comboBox );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _buttons?.Any( ) == true
                        ? _buttons
                        : default( IDictionary<string, ComboBox> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary> Gets the group boxes. </summary>
        /// <returns> </returns>
        public IDictionary<string, Layout> GetPanels( )
        {
            if( TabPages?.Count > 0 )
            {
                try
                {
                    var _panels = new Dictionary<string, Layout>( );
                    foreach( var _tabPage in TabPages.Values )
                    {
                        foreach( var _control in _tabPage.Controls )
                        {
                            if( _control is Layout _panel )
                            {
                                _panels.Add( _panel.Name, _panel );
                            }
                        }
                    }

                    return _panels?.Any( ) == true
                        ? _panels
                        : default( IDictionary<string, Layout> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary> Gets the list boxes. </summary>
        /// <returns> </returns>
        public virtual IDictionary<string, ListBox> GetListBoxes( )
        {
            if( TabPages?.Count > 0 )
            {
                try
                {
                    var _listBoxes = new Dictionary<string, ListBox>( );
                    foreach( var _tabPage in TabPages.Values )
                    {
                        if( _tabPage?.Controls?.Count > 0 )
                        {
                            foreach( var _control in _tabPage.Controls )
                            {
                                if( _control is ListBox _listBox )
                                {
                                    _listBoxes.Add( _listBox.Name, _listBox );
                                }
                            }
                        }
                    }

                    return _listBoxes?.Any( ) == true
                        ? _listBoxes
                        : default( IDictionary<string, ListBox> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static protected void Fail( Exception ex )
        {
            var  _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}