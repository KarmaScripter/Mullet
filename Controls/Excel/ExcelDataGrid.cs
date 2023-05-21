// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class ExcelDataGrid : Spreadsheet, ISpreadsheet
    {
        /// <summary> Gets or sets the grid. </summary>
        /// <value> The grid. </value>
        public SpreadsheetGrid Grid { get; set; }

        /// <summary> Gets or sets the model. </summary>
        /// <value> The model. </value>
        public SpreadsheetGridModel Model { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelDataGrid"/>
        /// class.
        /// </summary>
        public ExcelDataGrid( )
        {
            // Spreadsheet Properties
            CanApplyTheme = true;
            CanOverrideStyle = true;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            DefaultColumnCount = 26;
            DefaultRowCount = 66;
            AllowZooming = true;
            AllowCellContextMenu = true;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            Margin = new Padding( 1 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            ForeColor = Color.Black;
            DefaultColumnCount = 40;
            DefaultRowCount = 60;
            AllowZooming = true;
            AllowFiltering = true;
        }

        /// <summary> Opens the file. </summary>
        /// <param name="file"> The file. </param>
        public void OpenFile( Stream file )
        {
        }

        /// <summary> Displays the message box. </summary>
        /// <param name="text"> The text. </param>
        /// <param name="caption"> The caption. </param>
        /// <param name="button"> The button. </param>
        /// <param name="icon"> The icon. </param>
        /// <returns> </returns>
        public virtual bool DisplayMessageBox( string text, string caption, MessageBoxButtons button, MessageBoxIcon icon )
        {
            return false;
        }

        /// <summary> Called when [cell enter]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnCellEnter( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( CurrentCellValue ) )
                {
                    var _value = CurrentCellRange.DisplayText;
                    var _chars = _value.ToCharArray( );
                    if( _value.Length >= 6
                       && _value.Length <= 9
                       && _chars.Any( c => char.IsLetterOrDigit( c ) )
                       && _value.Substring( 0, 3 ) == "000" )
                    {
                        var _code = _value.Substring( 4, 2 );
                        var _dialog = new ProgramProjectDialog( _code );
                        _dialog.ShowDialog( );
                    }
                    else if( _chars?.All( c => char.IsNumber( c ) ) == true )
                    {
                        var _numeric = double.Parse( _value ?? "0.0" );
                        var _calculator = new CalculationForm( _numeric );
                        _calculator.ShowDialog( );
                    }
                    else if( _value.Length <= 22
                            && _value.Length >= 8
                            && ( _value.EndsWith( "AM" ) || _value.EndsWith( "PM" ) ) )
                    {
                        var _dateTime = DateTime.Parse( _value );
                        var _form = new CalendarDialog( _dateTime );
                        _form.ShowDialog( );
                    }
                    else if( ( _value.Contains( "-" ) || _value.Contains( "/" ) )
                            && _value.Length >= 8
                            && _value.Length <= 22 )
                    {
                        var _dt = DateTime.Parse( _value );
                        var _form = new CalendarDialog( _dt );
                        _form.ShowDialog( );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}