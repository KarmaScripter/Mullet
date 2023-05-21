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

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public partial class GuidanceDialog : MetroForm
    {
        /// <summary> Gets or sets the SQL query. </summary>
        /// <value> The SQL query. </value>
        public string SqlQuery { get; set; }

        /// <summary> Gets or sets the data model. </summary>
        /// <value> The data model. </value>
        public DataBuilder DataModel { get; set; }

        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public DataTable DataTable { get; set; }

        /// <summary> Gets or sets the form filter. </summary>
        /// <value> The form filter. </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary> Gets or sets the selected columns. </summary>
        /// <value> The selected columns. </value>
        public IList<string> SelectedColumns { get; set; }

        /// <summary> Gets or sets the numerics. </summary>
        /// <value> The numerics. </value>
        public IList<string> Numerics { get; set; }

        /// <summary> Gets or sets the fields. </summary>
        /// <value> The fields. </value>
        public IList<string> Fields { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public Provider Provider { get; set; }

        /// <summary> Gets or sets the extenstion. </summary>
        /// <value> The extenstion. </value>
        public EXT Extenstion { get; set; }

        /// <summary> Gets or sets the selected path. </summary>
        /// <value> The selected path. </value>
        public string SelectedPath { get; set; }

        /// <summary> Gets or sets the selected item. </summary>
        /// <value> The selected item. </value>
        public string SelectedItem { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SchemaDialog"/>
        /// class.
        /// </summary>
        public GuidanceDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 503, 429 );
            MaximumSize = new Size( 503, 429 );
            MinimumSize = new Size( 503, 429 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 2;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // Label Properties
            HeaderLabel.Font = new Font( "Roboto", 10 );
            HeaderLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            HeaderLabel.FlatStyle = FlatStyle.Flat;

            // Picture Properties
            Picture.Size = new Size( 22, 20 );
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;

            // File Dialog Properties
            OpenFileDialog.Title = "Search for Document";
            OpenFileDialog.CheckPathExists = true;
            OpenFileDialog.CheckFileExists = true;

            // Data Properties
            Source = Source.Resources;
            Provider = Provider.Access;
            Extenstion = EXT.PDF;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            SelectButton.Click += OnSelectButtonClicked;
            ClearButton.Click += OnClearButtonClicked;
            BrowseButton.Click += OnBrowseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SchemaDialog"/>
        /// class.
        /// </summary>
        /// <param name="bindingSource"> The binding source. </param>
        public GuidanceDialog( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
        }

        /// <summary> Called when [browse button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnBrowseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                OpenFileDialog.ShowDialog( );
                SelectedPath = OpenFileDialog.SafeFileName;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [first button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnClearButtonClicked( object sender, EventArgs e )
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

        /// <summary> Called when [second button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnSelectButtonClicked( object sender, EventArgs e )
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
                SelectedColumns = new List<string>( );
                CloseButton.HoverText = "Close Window";
                SelectButton.HoverText = "Open Selected Item";
                ClearButton.HoverText = "Clear Selected Item";
                BrowseButton.HoverText = "Search for File";
                PopulateListBox( );
                SetLabelText( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the label configuration. </summary>
        private void SetLabelText( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Populates the column ListBox. </summary>
        private void PopulateListBox( )
        {
            try
            {
                ListBox.Items.Clear( );
                DataModel = new DataBuilder( Source, Provider );
                DataTable = DataModel.DataTable;
                BindingSource.DataSource = DataModel.DataTable;
                Fields = DataModel.Fields;
                Numerics = DataModel.Numerics;
                var _data = DataTable.AsEnumerable( );
                var _names = _data?.Where( r => r.Field<string>( "Type" ).Equals( "DOCUMENT" ) )?.Select( r => r.Field<string>( "Caption" ) )?.ToList( );
                foreach( var name in _names )
                {
                    ListBox.Items.Add( name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Populates the numeric ListBox. </summary>
        private void PopulateSecondTabListBox( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Updates the header text. </summary>
        private void UpdateHeaderText( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [column ListBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        private void OnListViewSelectedValueChanged( object sender )
        {
            try
            {
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