// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Edit.EditControl"/>
    public class Editor : EditControl
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Editor"/>
        /// class.
        /// </summary>
        public Editor( )
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            AlwaysShowScrollers = true;
            BackColor = SystemColors.ControlLight;
            ForeColor = Color.Black;
            BackgroundColor = new BrushInfo( SystemColors.ControlLight );
            BorderStyle = BorderStyle.FixedSingle;
            CanOverrideStyle = true;
            CanApplyTheme = true;
            ColumnGuidesMeasuringFont = new Font( "Roboto", 8 );
            ContextChoiceFont = new Font( "Roboto", 8 );
            ContextChoiceForeColor = Color.Black;
            ContextChoiceBackColor = SystemColors.ControlLight;
            ContextPromptBorderColor = Color.FromArgb( 0, 120, 212 );
            ContextPromptBackgroundBrush = new BrushInfo( Color.FromArgb( 233, 166, 50 ) );
            ContextTooltipBackgroundBrush = new BrushInfo( Color.FromArgb( 233, 166, 50 ) );
            ContextTooltipBorderColor = Color.FromArgb( 0, 120, 212 );
            EndOfLineBackColor = SystemColors.ControlLight;
            EndOfLineForeColor = SystemColors.ControlLight;
            HighlightCurrentLine = true;
            IndentationBlockBorderColor = Color.FromArgb( 0, 120, 212 );
            IndentLineColor = Color.FromArgb( 50, 93, 129 );
            IndicatorMarginBackColor = SystemColors.ActiveCaption;
            CurrentLineHighlightColor = Color.FromArgb( 0, 120, 212 );
            Font = new Font( "Roboto", 10 );
            LineNumbersColor = Color.Black;
            LineNumbersFont = new Font( "Roboto", 8, FontStyle.Bold );
            ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
            ScrollColorScheme = Office2007ColorScheme.Black;
            SelectionTextColor = Color.White;
            ShowEndOfLine = false;
            Style = EditControlStyle.Office2016Black;
            TabSize = 4;
            TextAreaWidth = 400;
            WordWrap = true;
            WordWrapColumn = 100;
        }
    }
}