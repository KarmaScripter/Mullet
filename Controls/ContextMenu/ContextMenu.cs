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
    using MetroSet_UI.Child;
    using MetroSet_UI.Enums;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class ContextMenu : MenuBase
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ContextMenu"/>
        /// class.
        /// </summary>
        public ContextMenu( )
        {
            BackColor = Color.FromArgb( 30, 30, 30 );
            BackgroundColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.White;
            ArrowColor = Color.FromArgb( 50, 93, 129 );
            SeparatorColor = Color.FromArgb( 65, 65, 65 );
            AutoSize = false;
            Size = new Size( 156, 264 );
            IsDerivedStyle = false;
            RenderMode = ToolStripRenderMode.System;
            Style = Style.Custom;
            ShowCheckMargin = false;
            ShowImageMargin = true;
            SelectedItemBackColor = Color.FromArgb( 50, 93, 129 );
            SelectedItemColor = Color.White;
            ThemeAuthor = "Terry Eppler";
            ThemeName = "Budget Execution";

            // Menu Items
            FileOption = CreateFileOption( );
            FolderOption = CreateFolderOption( );
            CalculatorOption = CreateCalculatorOption( );
            CalendarOption = CreateCalendarOption( );
            GuidanceOption = CreateGuidanceOption( );
            SaveOption = CreateSaveOption( );
            CloseOption = CreateCloseOption( );
            ExitOption = CreateExitOption( );
        }

        /// <summary> Initializes the file option. </summary>
        private MetroSetToolStripMenuItem CreateFileOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.File.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuOption.File}";
                _item.Tag = MenuOption.File.ToString( );
                _item.Checked = false;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary> Initializes the folder option. </summary>
        private MetroSetToolStripMenuItem CreateFolderOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Folder.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuOption.Folder}";
                _item.Tag = MenuOption.Folder.ToString( );
                _item.Checked = false;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary> Initializes the calculator option. </summary>
        private MetroSetToolStripMenuItem CreateCalculatorOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Calculator.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuOption.Calculator}";
                _item.Tag = MenuOption.Calculator.ToString( );
                _item.Checked = false;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary> Initializes the calendar option. </summary>
        private MetroSetToolStripMenuItem CreateCalendarOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Calendar.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuOption.Calendar}";
                _item.Tag = MenuOption.Calendar.ToString( );
                _item.Checked = false;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary> Initializes the guidance option. </summary>
        private MetroSetToolStripMenuItem CreateGuidanceOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Guidance.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuOption.Guidance}";
                _item.Tag = MenuOption.Guidance.ToString( );
                _item.Checked = false;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary> Initializes the save option. </summary>
        private MetroSetToolStripMenuItem CreateSaveOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Save.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuOption.Save}";
                _item.Tag = MenuOption.Save.ToString( );
                _item.Checked = false;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary> Initializes the close option. </summary>
        private MetroSetToolStripMenuItem CreateCloseOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Close.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuOption.Close}";
                _item.Tag = MenuOption.Close.ToString( );
                _item.Checked = false;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary> Initializes the exit option. </summary>
        private MetroSetToolStripMenuItem CreateExitOption( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Exit.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.White;
                _item.Text = $"{MenuOption.Exit}";
                _item.Tag = MenuOption.Exit.ToString( );
                _item.Checked = false;
                _item.MouseEnter += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary> Called when [item clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnItemClicked( object sender, MouseEventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem item
               && e?.Button == MouseButtons.Left )
            {
                try
                {
                    var _name = item.Tag.ToString( );
                    if( !string.IsNullOrEmpty( _name ) )
                    {
                        var _option = Enum.Parse( typeof( MenuOption ), _name );
                        switch( _option )
                        {
                            case MenuOption.File:
                            {
                                var _file = new FileBrowser( );
                                _file.Location = e.Location;
                                _file.Show( );
                                break;
                            }
                            case MenuOption.Folder:
                            {
                                var _file = new FileBrowser( );
                                _file.Location = e.Location;
                                _file.Show( );
                                break;
                            }
                            case MenuOption.Calculator:
                            {
                                var _form = new CalculationForm( );
                                _form.Location = e.Location;
                                _form.ShowDialog( );
                                break;
                            }
                            case MenuOption.Calendar:
                            {
                                var _form = new CalendarDialog( );
                                _form.Location = e.Location;
                                _form.ShowDialog( );
                                break;
                            }
                            case MenuOption.Guidance:
                            {
                                var _pdfForm = new PdfForm( );
                                _pdfForm.Show( );
                                break;
                            }
                            case MenuOption.Save:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuOption.Close:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuOption.Exit:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            default:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                        }

                        Close( );
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