// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    public partial class ColorDialog : MetroForm
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ColorDialog"/>
        /// class.
        /// </summary>
        public ColorDialog( )
        {
            InitializeComponent( );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Size = new Size( 326, 407 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );

            // Color Picker Properties
            ColorPicker.ForeColor = Color.LightGray;
            ColorPicker.Font = new Font( "Roboto", 9 );
            ColorPicker.MetroForeColor = Color.LightGray;
            ColorPicker.BorderStyle = BorderStyle.None;
            ColorPicker.MetroColor = Color.FromArgb( 0, 120, 212 );
            ColorPicker.BackColor = Color.FromArgb( 20, 20, 20 );
            ColorPicker.VisualStyle = ColorUIStyle.Office2016Black;
            ColorPicker.Size = new Size( 246, 284 );
            ColorPicker.Location = new Point( 34, 16 );

            // Wire Events
            Load += OnLoad;
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
                CloseButton.Click += OnCloseButtonClicked;
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
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}