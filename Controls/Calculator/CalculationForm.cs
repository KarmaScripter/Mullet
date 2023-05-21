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
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    public partial class CalculationForm : MetroForm
    {
        /// <summary> Gets or sets the initial value. </summary>
        /// <value> The initial value. </value>
        public double InitialValue { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CalculationForm"/>
        /// class.
        /// </summary>
        public CalculationForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Font = new Font( "Roboto", 9 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Size = new Size( 373, 451 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionFont = new Font( "Roboto", 10 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.Red;
            ShowMouseOver = true;
            MinimizeBox = false;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            // Calculator Configuration
            Calculator.Font = new Font( "Roboto", 10 );
            Calculator.Dock = DockStyle.Fill;
            Calculator.BorderStyle = Border3DStyle.Adjust;
            Calculator.HorizontalSpacing = 10;
            Calculator.VerticalSpacing = 10;
            Calculator.UseVerticalAndHorizontalSpacing = true;
            Calculator.ShowDisplayArea = false;
            Calculator.BackColor = Color.FromArgb( 20, 20, 20 );

            // Label Configuration
            ValueLabel.Font = new Font( "Roboto", 14 );
            ValueLabel.Dock = DockStyle.Top;
            ValueLabel.BackColor = Color.Transparent;
            ValueLabel.ForeColor = Color.White;
            ValueLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CalculationForm"/>
        /// class.
        /// </summary>
        /// <param name="initial"> The initial. </param>
        public CalculationForm( double initial )
            : this( )
        {
            InitialValue = initial;
            Calculator.Value = new CalculatorValue( InitialValue );
            ValueLabel.Text = Calculator.Value.ToString( );
        }

        /// <summary> Called when [calculation value changed]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="CalculatorValueCalculatedEventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnCalculationValueChanged( object sender, CalculatorValueCalculatedEventArgs e )
        {
            if( sender != null )
            {
                try
                {
                    ValueLabel.Text = Calculator.Value.ToString( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
                Calculator.ValueCalculated += OnCalculationValueChanged;
                Calculator.BorderStyle = Border3DStyle.Adjust;
                Calculator.BackColor = Color.FromArgb( 20, 20, 20 );
                CloseButton.HoverText = "Exit Calculator";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [close button click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCloseButtonClick( object sender, EventArgs e )
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

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}