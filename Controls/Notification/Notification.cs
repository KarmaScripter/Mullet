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
    using static System.Drawing.Region;
    using static System.Windows.Forms.Screen;
    using static FormAnimator;
    using static NativeMethods;
    using Timer = System.Windows.Forms.Timer;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class Notification : MetroForm
    {
        /// <summary> Gets or sets the time. </summary>
        /// <value> The time. </value>
        public int Time { get; set; }

        /// <summary> Gets or sets the seconds. </summary>
        /// <value> The seconds. </value>
        public int Seconds { get; set; }

        /// <summary> Gets or sets a value indicating whether [allow focus]. </summary>
        /// <value>
        /// <c> true </c>
        /// if [allow focus]; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool AllowFocus { get; set; }

        /// <summary>
        /// Gets a value indicating whether [shown without activation].
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if [shown without activation]; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool ShownWithoutActivation { get; } = true;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Notification"/>
        /// class.
        /// </summary>
        public Notification( )
        {
            InitializeComponent( );
            DoubleBuffered = true;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            Resize += OnResized;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Notification"/>
        /// class.
        /// </summary>
        /// <param name="body"> The body. </param>
        /// <param name="duration"> The duration. </param>
        /// <param name="animation"> The animation. </param>
        /// <param name="direction"> The direction. </param>
        public Notification( string body, int duration = 3, AnimationMethod animation = AnimationMethod.Fade, AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            Load += OnLoad;
            Time = 0;
            Seconds = duration;
            Timer.Interval = duration * 1000;
            Title.ForeColor = Color.FromArgb( 0, 120, 212 );
            Title.Text = "Budget Execution Notification";
            Message.Text = body;
            Region = FromHrgn( CreateRoundRectRgn( 0, 0, Width - 5, Height - 5, 20,
                20 ) );

            Click += ( s, e ) => Close( );
            Message.Click += ( s, e ) => Close( );
            Title.Click += ( s, e ) => Close( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Notification"/>
        /// class.
        /// </summary>
        /// <param name="title"> The title. </param>
        /// <param name="body"> The body. </param>
        /// <param name="duration"> The duration. </param>
        /// <param name="animation"> The animation. </param>
        /// <param name="direction"> The direction. </param>
        public Notification( string title, string body, int duration = 3, AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            Load += OnLoad;
            Time = 0;
            Seconds = duration;
            Timer.Interval = duration * 1000;
            Title.ForeColor = Color.FromArgb( 0, 120, 212 );
            Title.Text = title;
            Message.Text = body;
            Region = FromHrgn( CreateRoundRectRgn( 0, 0, Width - 5, Height - 5, 20,
                20 ) );

            Click += ( s, e ) => Close( );
            Message.Click += ( s, e ) => Close( );
            Title.Click += ( s, e ) => Close( );
        }

        /// <summary> Displays the control to the user. </summary>
        public new void Show( )
        {
            try
            {
                Opacity = 0;
                if( Seconds != 0 )
                {
                    Timer = new Timer( );
                    Timer.Interval = 1000;
                    Timer.Tick += ( sender, args ) =>
                    {
                        Time++;
                        if( Time == Seconds )
                        {
                            Timer.Stop( );
                            FadeOutAndClose( );
                        }
                    };
                }

                base.Show( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Notifications the close. </summary>
        public void OnClose( )
        {
            try
            {
                FadeOutAndClose( );
                Close( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [paint]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="PaintEventArgs"/>
        /// instance containing the event data.
        /// </param>
        override protected void OnPaint( PaintEventArgs e )
        {
            try
            {
                base.OnPaint( e );
                var g = e.Graphics;
                var  pen = new Pen( BorderColor );
                g.DrawRectangle( pen, 0, 0, Width - 1, Height - 1 );
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
                Location = new Point( PrimaryScreen.WorkingArea.Width - Width - 5, PrimaryScreen.WorkingArea.Height - Height - 5 );
                FadeIn( );
                Timer.Start( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Fades the in. </summary>
        private void FadeIn( )
        {
            try
            {
                var _timer = new Timer( );
                _timer.Interval = 10;
                _timer.Tick += ( sender, args ) =>
                {
                    if( Opacity == 1d )
                    {
                        _timer.Stop( );
                    }

                    Opacity += 0.02d;
                };

                _timer.Start( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Fades the out and close. </summary>
        private void FadeOutAndClose( )
        {
            try
            {
                var _timer = new Timer( );
                _timer.Interval = 10;
                _timer.Tick += ( sender, args ) =>
                {
                    if( Opacity == 0d )
                    {
                        _timer.Stop( );
                        Close( );
                    }

                    Opacity -= 0.02d;
                };

                _timer.Start( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [resized]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnResized( object sender, EventArgs e )
        {
            try
            {
                if( WindowState == FormWindowState.Minimized )
                {
                    WindowState = FormWindowState.Normal;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        protected private void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}