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
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ErrorDialog : MetroForm
    {
        /// <summary> Gets or sets the exception. </summary>
        /// <value> The exception. </value>
        public virtual Exception Exception { get; set; }

        /// <summary> Gets or sets the icon path. </summary>
        /// <value> The icon path. </value>
        public virtual string IconPath { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ErrorDialog"/>
        /// class.
        /// </summary>
        public ErrorDialog( )
        {
            InitializeComponent( );

            // Form Property Values
            BackColor = Color.FromArgb( 20, 20, 20 );
            BorderThickness = 2;
            BorderColor = Color.Red;
            Size = new Size( 700, 450 );
            MaximumSize = new Size( 700, 450 );
            MinimumSize = new Size( 700, 450 );
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            MetroColor = Color.FromArgb( 20, 20, 20 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ShowIcon = false;
            ShowMouseOver = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            Text = string.Empty;

            // Header Label Properties
            HeaderLabel.ForeColor = Color.Red;

            // TextBox Properties
            TextBox.Font = new Font( "Roboto", 8 );
            TextBox.ForeColor = Color.White;
            TextBox.BackColor = Color.FromArgb( 40, 40, 40 );
            TextBox.BorderColor = Color.Maroon;
            TextBox.HoverColor = Color.Maroon;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ErrorDialog"/>
        /// class.
        /// </summary>
        /// <param name="ext"> The ext. </param>
        public ErrorDialog( Exception ext )
            : this( )
        {
            Exception = ext;
            TextBox.Text = ext.ToLogString( Exception?.Message );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ErrorDialog"/>
        /// class.
        /// </summary>
        /// <param name="message"> The message. </param>
        public ErrorDialog( string message )
            : this( )
        {
            Exception = null;
            TextBox.Text = message;
        }

        /// <summary> </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
                HeaderLabel.ForeColor = Color.Red;
                if( Exception != null )
                {
                    var _message = Exception.Message;
                    TextBox.Text = Exception.ToLogString( _message );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the text. </summary>
        public void SetText( )
        {
            try
            {
                var _logString = Exception.ToLogString( "" );
                TextBox.Text = _logString;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the text. </summary>
        public void SetText( Exception exc )
        {
            try
            {
                var _logString = exc?.ToLogString( "" );
                TextBox.Text = _logString;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the text. </summary>
        public void SetText( string msg = "" )
        {
            TextBox.Text = msg;
        }

        /// <summary> Called when [click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button )
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
        /// <param name="ex"> The exception. </param>
        static private void Fail( Exception ex )
        {
            Console.WriteLine( ex.Message );
        }
    }
}