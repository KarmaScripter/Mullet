// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="ToolStripBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class ToolStrip : ToolStripBase, IToolStrip
    {
        /// <summary> The image path </summary>
        public virtual string ImageDirectory { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary> Gets the buttons. </summary>
        /// <value> The buttons. </value>
        public IDictionary<string, ToolStripButton> Buttons { get; }

        /// <summary> Gets or sets the size of the image. </summary>
        /// <value> The size of the image. </value>
        public Size ImageSize { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStrip"/>
        /// class.
        /// </summary>
        public ToolStrip( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            BackColor = Color.Transparent;
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 9 );
            Height = 20;
            ShowCaption = true;
            CaptionFont = new Font( "Roboto", 8 );
            CaptionStyle = CaptionStyle.Top;
            CaptionAlignment = CaptionAlignment.Near;
            CaptionTextStyle = CaptionTextStyle.Plain;
            Text = "";
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.Bottom;
            BorderStyle = ToolStripBorderStyle.StaticEdge;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            ImageScalingSize = new Size( 16, 16 );
            Office12Mode = true;
            LauncherStyle = LauncherStyle.Office12;
            ShowLauncher = true;
            GripStyle = ToolStripGripStyle.Hidden;
            VisualStyle = ToolStripExStyle.Office2016DarkGray;
            OfficeColorScheme = ColorScheme.Blue;
            ThemeStyle.BackColor = Color.Transparent;
            ThemeStyle.ArrowColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.BottomToolStripBackColor = Color.Transparent;
            ThemeStyle.CaptionBackColor = Color.FromArgb( 28, 28, 28 );
            ThemeStyle.CaptionForeColor = Color.Black;
            ThemeStyle.ComboBoxStyle.BorderColor = Color.FromArgb( 65, 65, 65 );
            ThemeStyle.DropDownStyle.BorderColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.ComboBoxStyle.HoverBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverItemBackColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverItemForeColor = Color.White;
            Buttons = GetButtons( );
        }

        /// <summary> Gets the buttons. </summary>
        /// <returns> </returns>
        public IDictionary<string, ToolStripButton> GetButtons( )
        {
            var _buttons = new SortedList<string, ToolStripButton>( );
            if( Items?.Count > 0 )
            {
                foreach( var control in Items )
                {
                    if( control is ToolStripButton _item )
                    {
                        if( !string.IsNullOrEmpty( _item?.Name ) )
                        {
                            _buttons.Add( _item?.Name, _item );
                        }
                    }
                }

                return _buttons?.Count > 0
                    ? _buttons
                    : default;
            }

            return default;
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnVisible( object sender, EventArgs e )
        {
            if( sender is ToolStrip toolStrip )
            {
                foreach( var button in toolStrip.Buttons.Values )
                {
                    button.BindingSource = BindingSource;
                }
            }
        }
    }
}