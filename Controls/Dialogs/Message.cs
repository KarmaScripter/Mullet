// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class Message : MetroForm
    {

        /// <summary> </summary>
        public Message( )
        {
            InitializeComponent( );
            Size = new Size( 700, 400 );
            MinimumSize = new Size( 700, 400 );
            MaximumSize = new Size( 700, 400 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderThickness = 2;
            BackColor = Color.FromArgb( 20, 20, 20 );
            StartPosition = FormStartPosition.CenterScreen;
            CaptionBarHeight = 5;
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            Enabled = true;
            Visible = true;

            // Control Properties
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.Text = "Close";
            CloseButton.ForeColor = Color.FromArgb( 0, 120, 212 );
            CloseButton.BackColor = Color.FromArgb( 20, 20, 20 );
            TextBox.BackColor = Color.FromArgb( 40, 40, 40 );
            CloseButton.Focus( );

            //Event Wiring
            CloseButton.Click += OnCloseButtonClick;
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Message"/>
        /// class.
        /// </summary>
        /// <param name="text"> The text displayed by the control. </param>
        public Message( string text )
            : this( )
        {
            TextBox.Text = Environment.NewLine + text;
            CloseButton.Focus( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Message"/>
        /// class.
        /// </summary>
        /// <param name="text"> The text. </param>
        /// <param name="caption"> The caption. </param>
        public Message( string text, string caption )
            : this( text )
        {
            Header.Text = caption;
            CloseButton.Focus( );
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e"> instance containing the event data. </param>
        public virtual void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Header.ForeColor = Color.FromArgb( 0, 120, 212 );
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
        public virtual void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && !string.IsNullOrEmpty( _button?.Name ) )
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