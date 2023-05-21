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
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class TabControl : TabControlAdv
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TabControl"/>
        /// class.
        /// </summary>
        public TabControl( )
        {
            TabStyle = typeof( TabRendererMetro );
            BackColor = Color.FromArgb( 20, 20, 20 );
            Size = new Size( 350, 500 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            BorderStyle = BorderStyle.None;
            CloseButtonBackColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonForeColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonHoverForeColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonPressedForeColor = Color.FromArgb( 20, 20, 20 );
            SeparatorColor = Color.FromArgb( 20, 20, 20 );
            ShowSeparator = false;
            ItemSize = new Size( 100, 30 );
            TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            CanOverrideStyle = true;
            CanApplyTheme = true;
            ActiveTabColor = Color.FromArgb( 20, 20, 20 );
            ActiveTabFont = new Font( "Roboto", 8 );
            ActiveTabForeColor = Color.DarkGray;
            InActiveTabForeColor = Color.FromArgb( 20, 20, 20 );
            InactiveCloseButtonForeColor = Color.FromArgb( 20, 20, 20 );
            InactiveTabColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderFillColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveFont = new Font( "Roboto", 8 );
            ThemeStyle.TabStyle.ActiveForeColor = Color.DarkGray;
            ThemeStyle.TabStyle.SeparatorColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.TabStyle.ActiveBackColor = Color.FromArgb( 20, 20, 20 );
        }
    }
}