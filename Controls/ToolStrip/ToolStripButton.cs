// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;
    using static System.Configuration.ConfigurationManager;

    /// <summary> </summary>
    [ Serializable ]
    [ SuppressMessage( "ReSharper", "MergeConditionalExpression" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    public class ToolStripButton : ToolButtonBase, IToolStripButton
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripButton"/>
        /// class.
        /// </summary>
        public ToolStripButton( )
        {
            // Basic Properties
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackColor = Color.Transparent;
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            AutoToolTip = false;
            Text = string.Empty;
            Size = new Size( 24, 20 );

            // Event Wiring
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            Click += OnClick;
        }

        /// <summary>
        /// Initializes a new instance Mof the
        /// <see cref="ToolStripButton"/>
        /// class.
        /// </summary>
        /// <param name="toolType"> The tool. </param>
        public ToolStripButton( ToolType toolType )
            : this( )
        {
            ToolType = toolType;
            Name = toolType.ToString( );
            HoverText = GetHoverText( toolType );
            Tag = HoverText;
            Image = GetImage( toolType );
            Click += OnClick;
        }

        /// <summary> </summary>
        /// <param name="toolType"> </param>
        /// <param name="bindingSource"> </param>
        public ToolStripButton( ToolType toolType, BindingSource bindingSource )
            : this( toolType )
        {
            BindingSource = bindingSource;
        }

        /// <summary> Sets the button image. </summary>
        /// <returns> </returns>
        public Image GetImage( ToolType toolType )
        {
            if( Enum.IsDefined( typeof( ToolType ), toolType ) )
            {
                try
                {
                    var _path = AppSettings[ "ToolStrip" ] + $"{toolType}.png";
                    if( File.Exists( _path ) )
                    {
                        var  _stream = File.Open( _path, FileMode.Open );
                        var _image = Image.FromStream( _stream );
                        return ( _image != null )
                            ? _image
                            : default;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary> Called when [mouse over]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as ToolStripButton;
                if( _button != null
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    _button.Tag = HoverText;
                    var tip = new SmallTip( _button );
                    ToolTip = tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                    {
                        var _tool = new SmallTip( _button );
                        ToolTip = _tool;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [mouse leave]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                    ToolTip = null;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnClick( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    switch( _button?.ToolType )
                    {
                        case ToolType.FirstButton:
                        {
                            BindingSource?.MoveFirst( );
                            break;
                        }
                        case ToolType.PreviousButton:
                        {
                            BindingSource?.MovePrevious( );
                            break;
                        }
                        case ToolType.NextButton:
                        {
                            BindingSource?.MoveNext( );
                            break;
                        }
                        case ToolType.LastButton:
                        {
                            BindingSource?.MoveLast( );
                            break;
                        }
                        case ToolType.RemoveFiltersButton:
                        case ToolType.RefreshDataButton:
                        case ToolType.SearchDataButton:
                        case ToolType.GroupButton:
                        case ToolType.ExitButton:
                        case ToolType.ShutdownButton:
                        case ToolType.BackButton:
                        case ToolType.MenuButton:
                        case ToolType.HomeButton:
                        case ToolType.CalendarButton:
                        case ToolType.TableButton:
                        case ToolType.LookupButton:
                        case ToolType.EditSqlButton:
                        case ToolType.EditRecordButton:
                        case ToolType.AddButton:
                        case ToolType.AddTableButton:
                        case ToolType.AddDatabaseButton:
                        case ToolType.EditColumnButton:
                        case ToolType.DeleteRecordButton:
                        case ToolType.DeleteColumnButton:
                        case ToolType.DeleteTableButton:
                        case ToolType.DeleteDatabaseButton:
                        case ToolType.AddColumnButton:
                        case ToolType.ExcelExportButton:
                        case ToolType.ChartButton:
                        case ToolType.UploadButton:
                        {
                            break;
                        }
                        case ToolType.ImportDatabaseButton:
                        case ToolType.ImportButton:
                        case ToolType.CsvImportButton:
                        case ToolType.PdfImportButton:
                        case ToolType.ExcelImportButton:
                        {
                            var _fileDialog = new FileBrowser( );
                            _fileDialog.ShowDialog( );
                            break;
                        }
                        case ToolType.ExcelButton:
                        {
                            var _excel = @"C:\Users\terry\source\repos\Budget\Resource\Reports\Template.xlsx";
                            var  _excelForm = new ExcelDataForm( _excel );
                            _excelForm?.ShowDialog( );
                            break;
                        }
                        case ToolType.GuidanceButton:
                        case ToolType.PdfButton:
                        {
                            var  _message = new PdfForm( );
                            _message?.ShowDialog( );
                            break;
                        }
                        case ToolType.DeleteButton:
                        case ToolType.EditButton:
                        case ToolType.DataRowButton:
                        case ToolType.CopyButton:
                        case ToolType.AccountButton:
                        case ToolType.AddRecordButton:
                        {
                            var _dialog = new EditDialog( _button.ToolType, BindingSource );
                            _dialog?.ShowDialog( );
                            break;
                        }
                        case ToolType.InsertButton:
                        case ToolType.UpdateButton:
                        {
                            var _dialog = new SqlDialog( _button.ToolType, BindingSource );
                            _dialog?.ShowDialog( );
                            break;
                        }
                        case ToolType.GoButton:
                        case ToolType.GoogleButton:
                        case ToolType.BlueToothButton:
                        case ToolType.CancelRequestButton:
                        case ToolType.CsvButton:
                        case ToolType.CsvExportButton:
                        case ToolType.DataConfigButton:
                        case ToolType.EmailButton:
                        case ToolType.ExportDatabaseButton:
                        case ToolType.PauseButton:
                        case ToolType.GridButton:
                        case ToolType.PlayButton:
                        case ToolType.DownloadButton:
                        case ToolType.DownloadDataButton:
                        case ToolType.DatabaseSettingsButton:
                        case ToolType.NavigationButton:
                        case ToolType.PdfExportButton:
                        case ToolType.PowerPointButton:
                        case ToolType.PrintButton:
                        case ToolType.RedoButton:
                        case ToolType.RemoveButton:
                        case ToolType.SkipButton:
                        case ToolType.SqlServerButton:
                        case ToolType.StopButton:
                        case ToolType.PrinterButton:
                        case ToolType.MetricsButton:
                        case ToolType.WebNextButton:
                        case ToolType.WebBackButton:
                        case ToolType.ExportButton:
                        case ToolType.RewindButton:
                        case ToolType.SettingsButton:
                        case ToolType.TableSettingsButton:
                        case ToolType.TransferButton:
                        case ToolType.TransferInButton:
                        case ToolType.TransferOutButton:
                        case ToolType.TrashButton:
                        case ToolType.UploadDataButton:
                        case ToolType.UndoButton:
                        case ToolType.WordButton:
                        case ToolType.RefreshButton:
                        {
                            var _notification = new Notification( "NOT YET IMPLEMENTED!" );
                            _notification.Show( );
                            break;
                        }
                        case ToolType.CalculatorButton:
                        {
                            var  _calculator = new CalculationForm( );
                            _calculator?.ShowDialog( );
                            break;
                        }
                        case ToolType.BrowseButton:
                        {
                            var _browser = new FileBrowser( );
                            _browser?.ShowDialog( );
                            break;
                        }
                        case ToolType.WebButton:
                        {
                            var  _form = new WebPage( );
                            _form?.ShowDialog( );
                            break;
                        }
                        default:
                        {
                            var _notification = new Notification( "NOT YET IMPLEMENTED!" );
                            _notification.Show( );
                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the image. </summary>
        public void SetImage( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    var _path = AppSettings[ "ToolStrip" ] + $"{ToolType}.png";
                    var  _stream = File.Open( _path, FileMode.Open );
                    if( _stream != null )
                    {
                        var _image = Image.FromStream( _stream );
                        Image = _image;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}