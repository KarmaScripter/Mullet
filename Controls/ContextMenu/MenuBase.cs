// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using MetroSet_UI.Child;
    using MetroSet_UI.Controls;

    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class MenuBase : MetroSetContextMenuStrip
    {
        /// <summary> Gets or sets the file option. </summary>
        /// <value> The file option. </value>
        public MetroSetToolStripMenuItem FileOption { get; set; }

        /// <summary> Gets or sets the folder option. </summary>
        /// <value> The folder option. </value>
        public MetroSetToolStripMenuItem FolderOption { get; set; }

        /// <summary> Gets or sets the calculator option. </summary>
        /// <value> The calculator option. </value>
        public MetroSetToolStripMenuItem CalculatorOption { get; set; }

        /// <summary> Gets or sets the calendar option. </summary>
        /// <value> The calendar option. </value>
        public MetroSetToolStripMenuItem CalendarOption { get; set; }

        /// <summary> Gets or sets the guidance option. </summary>
        /// <value> The guidance option. </value>
        public MetroSetToolStripMenuItem GuidanceOption { get; set; }

        /// <summary> Gets or sets the save option. </summary>
        /// <value> The save option. </value>
        public MetroSetToolStripMenuItem SaveOption { get; set; }

        /// <summary> Gets or sets the close option. </summary>
        /// <value> The close option. </value>
        public MetroSetToolStripMenuItem CloseOption { get; set; }

        /// <summary> Gets or sets the exit option. </summary>
        /// <value> The exit option. </value>
        public MetroSetToolStripMenuItem ExitOption { get; set; }

        /// <summary> Called when [mouse enter]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        protected void OnMouseEnter( object sender, EventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem item )
            {
                try
                {
                    item.BackColor = Color.FromArgb( 50, 93, 129 );
                    item.ForeColor = Color.White;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [mouse leave]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        protected void OnMouseLeave( object sender, EventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem item )
            {
                try
                {
                    item.BackColor = Color.FromArgb( 30, 30, 30 );
                    item.ForeColor = Color.White;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected private void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}