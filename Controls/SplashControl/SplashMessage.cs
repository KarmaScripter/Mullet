﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Tools;
    using Color = System.Drawing.Color;
    using Font = System.Drawing.Font;
    using Image = System.Drawing.Image;
    using Point = System.Drawing.Point;
    using Size = System.Drawing.Size;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class SplashMessage : SplashPanel
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the images. </summary>
        /// <value> The images. </value>
        public virtual IEnumerable<Image> Images { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public virtual SmallTip ToolTip { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SplashMessage"/>
        /// class.
        /// </summary>
        /// <remarks>
        /// The default value for the
        /// <see cref="P:Syncfusion.Windows.Forms.Tools.SplashPanel.TimerInterval"/>
        /// is set to The splash panel has animation turned and by default will appear in the middle of the
        /// screen.
        /// </remarks>
        public SplashMessage( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            Size = new Size( 300, 150 );
            BorderStyle = Border3DStyle.Flat;
            BorderType = SplashBorderType.Border3D;
            BackgroundColor = new BrushInfo( GradientStyle.PathEllipse, Color.FromArgb( 20, 20, 20 ), Color.FromArgb( 45, 45, 45 ) );
            ShowAnimation = true;
            ShowAsTopMost = true;
            AnimationSpeed = 20;
            AnimationSteps = 3;
            AnimationDirection = AnimationDirection.Default;
            DesktopAlignment = SplashAlignment.Center;
            DiscreetLocation = new Point( 0, 0 );
            SuspendAutoCloseWhenMouseOver = false;
            TabIndex = 0;
            TimerInterval = 5000;
            CloseOnClick = true;
            MarqueePosition = MarqueePosition.BottomRight;
            MarqueeDirection = SplashPanelMarqueeDirection.RightToLeft;
            SlideStyle = SlideStyle.FadeIn;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SplashMessage"/>
        /// class.
        /// </summary>
        /// <param name="message"> The message. </param>
        public SplashMessage( string message )
            : this( )
        {
            Text = message;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SplashMessage"/>
        /// class.
        /// </summary>
        /// <param name="toolTip"> The tool tip. </param>
        public SplashMessage( SmallTip toolTip )
            : this( )
        {
            Text = toolTip?.TipText;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SplashMessage"/>
        /// class.
        /// </summary>
        /// <param name="control"> The control. </param>
        /// <param name="message"> The message. </param>
        public SplashMessage( Control control, string message )
            : this( )
        {
            Parent = control;
            Text = message;
        }

        /// <summary>
        /// Displays the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.SplashPanel"/>
        /// Splash panel.
        /// </summary>
        public void ShowMessage( )
        {
            if( !string.IsNullOrEmpty( Text ) )
            {
                try
                {
                    ShowSplash( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the size. </summary>
        /// <param name="size"> The size. </param>
        public virtual void ReSize( Size size )
        {
            try
            {
                Size = size;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the size. </summary>
        /// <param name="width"> The width. </param>
        /// <param name="height"> The height. </param>
        public virtual void ReSize( int width = 300, int height = 150 )
        {
            try
            {
                Size = new Size( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the text. </summary>
        /// <param name="text"> The text. </param>
        public virtual void SetText( string text )
        {
            try
            {
                Text = text;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the color of the back. </summary>
        /// <param name="color"> The color. </param>
        public virtual void SetBackColor( Color color )
        {
            try
            {
                BackColor = color;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the image. </summary>
        /// <param name="path"> </param>
        public virtual void ResetIcon( string path )
        {
            if( !string.IsNullOrEmpty( path )
               && File.Exists( path ) )
            {
                try
                {
                    var _stream = File.Open( path, FileMode.Open );
                    FormIcon = new Icon( _stream );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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