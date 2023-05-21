﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class SqlDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
        if( disposing && ( components != null ) )
        {
            components.Dispose( );
        }
        base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
        components =  new System.ComponentModel.Container( ) ;
        var config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( SqlDialog ) );
        TabControl =  new Syncfusion.Windows.Forms.Tools.TabControlAdv( ) ;
        TabPage =  new Syncfusion.Windows.Forms.Tools.TabPageAdv( ) ;
        EditorTable =  new HeaderPanel( ) ;
        EditorPanel =  new Layout( ) ;
        SqlEditor =  new Editor( ) ;
        SqlCommandTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
        ProviderTable =  new HeaderPanel( ) ;
        SecondPanel =  new Layout( ) ;
        SqlServerRadioButton =  new RadioButton( ) ;
        AccessRadioButton =  new RadioButton( ) ;
        ToollTip =  new SmallTip( ) ;
        SQLiteRadioButton =  new RadioButton( ) ;
        SqlCeRadioButton =  new RadioButton( ) ;
        CommandTable =  new HeaderPanel( ) ;
        ThirdPanel =  new Layout( ) ;
        SqlComboBox =  new ComboBox( ) ;
        SqlStatementTable =  new HeaderPanel( ) ;
        TextPanel =  new Layout( ) ;
        SqlListBox =  new ListBox( ) ;
        FirstButton =  new Button( ) ;
        SecondButton =  new Button( ) ;
        ThirdButton =  new Button( ) ;
        BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
        ContextMenu =  new ContextMenu( ) ;
        ( (System.ComponentModel.ISupportInitialize) TabControl  ).BeginInit( );
        TabControl.SuspendLayout( );
        TabPage.SuspendLayout( );
        EditorTable.SuspendLayout( );
        EditorPanel.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) SqlEditor  ).BeginInit( );
        SqlCommandTable.SuspendLayout( );
        ProviderTable.SuspendLayout( );
        SecondPanel.SuspendLayout( );
        CommandTable.SuspendLayout( );
        ThirdPanel.SuspendLayout( );
        SqlStatementTable.SuspendLayout( );
        TextPanel.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        SuspendLayout( );
        // 
        // TabControl
        // 
        TabControl.ActiveTabColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.ActiveTabFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        TabControl.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.BeforeTouchSize =  new System.Drawing.Size( 1310, 556 ) ;
        TabControl.BorderStyle =  System.Windows.Forms.BorderStyle.None ;
        TabControl.BorderWidth =  1 ;
        TabControl.CanOverrideStyle =  true ;
        TabControl.CloseButtonBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.Controls.Add( TabPage );
        TabControl.Dock =  System.Windows.Forms.DockStyle.Top ;
        TabControl.FixedSingleBorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.FocusOnTabClick =  false ;
        TabControl.InactiveCloseButtonForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.InactiveTabColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.ItemSize =  new System.Drawing.Size( 158, 23 ) ;
        TabControl.Location =  new System.Drawing.Point( 0, 0 ) ;
        TabControl.Margin =  new System.Windows.Forms.Padding( 1 ) ;
        TabControl.Name =  "TabControl" ;
        TabControl.Size =  new System.Drawing.Size( 1310, 556 ) ;
        TabControl.TabIndex =  9 ;
        TabControl.TabPanelBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.TabStyle =  typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro ) ;
        TabControl.ThemeName =  "TabRendererMetro" ;
        TabControl.ThemeStyle.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.ThemeStyle.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.ThemeStyle.DisabledTabPanelBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.ThemeStyle.EditableTabStyle.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.ThemeStyle.EditableTabStyle.ForeColor =  System.Drawing.Color.LightSteelBlue ;
        TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage =  null ;
        TabControl.ThemeStyle.TabPanelBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.ThemeStyle.TabStyle.ActiveBackColor =  System.Drawing.Color.FromArgb(   22  ,   39  ,   70   ) ;
        TabControl.ThemeStyle.TabStyle.ActiveBorderColor =  System.Drawing.Color.FromArgb(   22  ,   39  ,   70   ) ;
        TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor =  System.Drawing.Color.FromArgb(   22  ,   39  ,   70   ) ;
        TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabControl.ThemeStyle.TabStyle.ActiveForeColor =  System.Drawing.Color.White ;
        TabControl.ThemeStyle.TabStyle.InactiveBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        // 
        // TabPage
        // 
        TabPage.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabPage.Controls.Add( EditorTable );
        TabPage.Controls.Add( SqlCommandTable );
        TabPage.Image =  null ;
        TabPage.ImageSize =  new System.Drawing.Size( 14, 14 ) ;
        TabPage.Location =  new System.Drawing.Point( 0, 22 ) ;
        TabPage.Margin =  new System.Windows.Forms.Padding( 1 ) ;
        TabPage.Name =  "TabPage" ;
        TabPage.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        TabPage.ShowCloseButton =  true ;
        TabPage.Size =  new System.Drawing.Size( 1310, 534 ) ;
        TabPage.TabBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TabPage.TabForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        TabPage.TabIndex =  8 ;
        TabPage.ThemesEnabled =  false ;
        // 
        // EditorTable
        // 
        EditorTable.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        EditorTable.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
        EditorTable.CaptionText =  "SQL Text Editor" ;
        EditorTable.ColumnCount =  1 ;
        EditorTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        EditorTable.Controls.Add( EditorPanel, 0, 1 );
        EditorTable.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        EditorTable.ForeColor =  System.Drawing.Color.DarkGray ;
        EditorTable.Location =  new System.Drawing.Point( 30, 21 ) ;
        EditorTable.Name =  "EditorTable" ;
        EditorTable.RowCount =  2 ;
        EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.15264177F ) );
        EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.84736F ) );
        EditorTable.Size =  new System.Drawing.Size( 887, 509 ) ;
        EditorTable.TabIndex =  5 ;
        // 
        // EditorPanel
        // 
        EditorPanel.Anchor =      System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right   ;
        EditorPanel.BackColor =  System.Drawing.Color.Transparent ;
        EditorPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        EditorPanel.BindingSource =  null ;
        EditorPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        EditorPanel.BorderThickness =  1 ;
        EditorPanel.Children =  null ;
        EditorPanel.Controls.Add( SqlEditor );
        EditorPanel.DataFilter =  null ;
        EditorPanel.Font =  new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        EditorPanel.ForeColor =  System.Drawing.Color.Transparent ;
        EditorPanel.HoverText =  null ;
        EditorPanel.IsDerivedStyle =  true ;
        EditorPanel.Location =  new System.Drawing.Point( 3, 29 ) ;
        EditorPanel.Name =  "EditorPanel" ;
        EditorPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        EditorPanel.Size =  new System.Drawing.Size( 881, 477 ) ;
        EditorPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
        EditorPanel.StyleManager =  null ;
        EditorPanel.TabIndex =  0 ;
        EditorPanel.ThemeAuthor =  "Terry D. Eppler" ;
        EditorPanel.ThemeName =  "BudgetExecution" ;
        EditorPanel.ToolTip =  null ;
        // 
        // SqlEditor
        // 
        SqlEditor.AllowZoom =  false ;
        SqlEditor.AlwaysShowScrollers =  true ;
        SqlEditor.AutoSizeMode =  System.Windows.Forms.AutoSizeMode.GrowAndShrink ;
        SqlEditor.BackColor =  System.Drawing.SystemColors.ControlLight ;
        SqlEditor.BookmarkTooltipBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlEditor.BorderStyle =  System.Windows.Forms.BorderStyle.FixedSingle ;
        SqlEditor.CanOverrideStyle =  true ;
        SqlEditor.ChangedLinesMarkingLineColor =  System.Drawing.Color.FromArgb(   255  ,   238  ,   98   ) ;
        SqlEditor.CodeSnipptSize =  new System.Drawing.Size( 100, 100 ) ;
        SqlEditor.ColumnGuidesMeasuringFont =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SqlEditor.Configurator =  config1 ;
        SqlEditor.ContextChoiceBackColor =  System.Drawing.SystemColors.ControlLight ;
        SqlEditor.ContextChoiceBorderColor =  System.Drawing.Color.FromArgb(   233  ,   166  ,   50   ) ;
        SqlEditor.ContextPromptBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlEditor.ContextTooltipBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlEditor.CurrentLineHighlightColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlEditor.EndOfLineBackColor =  System.Drawing.SystemColors.ControlLight ;
        SqlEditor.EndOfLineForeColor =  System.Drawing.SystemColors.ControlLight ;
        SqlEditor.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SqlEditor.ForeColor =  System.Drawing.Color.Black ;
        SqlEditor.HighlightCurrentLine =  true ;
        SqlEditor.IndentationBlockBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlEditor.IndentBlockHighlightingColor =  System.Drawing.SystemColors.ActiveCaption ;
        SqlEditor.IndentLineColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlEditor.IndicatorMarginBackColor =  System.Drawing.SystemColors.ControlLight ;
        SqlEditor.LineNumbersColor =  System.Drawing.Color.Black ;
        SqlEditor.LineNumbersFont =  new System.Drawing.Font( "Hack", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
        SqlEditor.Location =  new System.Drawing.Point( 17, 14 ) ;
        SqlEditor.Name =  "SqlEditor" ;
        SqlEditor.RenderRightToLeft =  false ;
        SqlEditor.ScrollColorScheme =  Syncfusion.Windows.Forms.Office2007ColorScheme.Black ;
        SqlEditor.ScrollPosition =  new System.Drawing.Point( 0, 0 ) ;
        SqlEditor.ScrollVisualStyle =  Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016 ;
        SqlEditor.SelectionMarginBackgroundColor =  System.Drawing.SystemColors.ActiveCaption ;
        SqlEditor.SelectionTextColor =  System.Drawing.Color.White ;
        SqlEditor.ShowEndOfLine =  false ;
        SqlEditor.Size =  new System.Drawing.Size( 851, 448 ) ;
        SqlEditor.StatusBarSettings.CoordsPanel.Width =  150 ;
        SqlEditor.StatusBarSettings.EncodingPanel.Width =  100 ;
        SqlEditor.StatusBarSettings.FileNamePanel.Width =  100 ;
        SqlEditor.StatusBarSettings.InsertPanel.Width =  33 ;
        SqlEditor.StatusBarSettings.Offcie2007ColorScheme =  Syncfusion.Windows.Forms.Office2007Theme.Blue ;
        SqlEditor.StatusBarSettings.Offcie2010ColorScheme =  Syncfusion.Windows.Forms.Office2010Theme.Blue ;
        SqlEditor.StatusBarSettings.StatusPanel.Width =  70 ;
        SqlEditor.StatusBarSettings.TextPanel.Width =  214 ;
        SqlEditor.StatusBarSettings.VisualStyle =  Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Office2016Black ;
        SqlEditor.Style =  Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Black ;
        SqlEditor.TabIndex =  0 ;
        SqlEditor.TabSize =  4 ;
        SqlEditor.Text =  "" ;
        SqlEditor.TextAreaWidth =  400 ;
        SqlEditor.ThemeName =  "Office2016Black" ;
        SqlEditor.UserMarginTextColor =  System.Drawing.Color.DimGray ;
        SqlEditor.UseXPStyle =  false ;
        SqlEditor.UseXPStyleBorder =  true ;
        SqlEditor.VisualColumn =  1 ;
        SqlEditor.VScrollMode =  Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate ;
        SqlEditor.WordWrap =  true ;
        SqlEditor.WordWrapColumn =  80 ;
        SqlEditor.ZoomFactor =  1F ;
        // 
        // SqlCommandTable
        // 
        SqlCommandTable.AutoSizeMode =  System.Windows.Forms.AutoSizeMode.GrowAndShrink ;
        SqlCommandTable.ColumnCount =  1 ;
        SqlCommandTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        SqlCommandTable.Controls.Add( ProviderTable, 0, 0 );
        SqlCommandTable.Controls.Add( CommandTable, 0, 1 );
        SqlCommandTable.Controls.Add( SqlStatementTable, 0, 2 );
        SqlCommandTable.Location =  new System.Drawing.Point( 923, 21 ) ;
        SqlCommandTable.Name =  "SqlCommandTable" ;
        SqlCommandTable.RowCount =  3 ;
        SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 104F ) );
        SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 299F ) );
        SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
        SqlCommandTable.Size =  new System.Drawing.Size( 352, 509 ) ;
        SqlCommandTable.TabIndex =  4 ;
        // 
        // ProviderTable
        // 
        ProviderTable.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        ProviderTable.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
        ProviderTable.CaptionText =  "Providers" ;
        ProviderTable.ColumnCount =  1 ;
        ProviderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProviderTable.Controls.Add( SecondPanel, 0, 1 );
        ProviderTable.Dock =  System.Windows.Forms.DockStyle.Fill ;
        ProviderTable.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ProviderTable.ForeColor =  System.Drawing.Color.DarkGray ;
        ProviderTable.Location =  new System.Drawing.Point( 3, 3 ) ;
        ProviderTable.Name =  "ProviderTable" ;
        ProviderTable.RowCount =  2 ;
        ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 9.523809F ) );
        ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 90.47619F ) );
        ProviderTable.Size =  new System.Drawing.Size( 346, 100 ) ;
        ProviderTable.TabIndex =  5 ;
        // 
        // SecondPanel
        // 
        SecondPanel.BackColor =  System.Drawing.Color.Transparent ;
        SecondPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        SecondPanel.BindingSource =  null ;
        SecondPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        SecondPanel.BorderThickness =  1 ;
        SecondPanel.Children =  null ;
        SecondPanel.Controls.Add( SqlServerRadioButton );
        SecondPanel.Controls.Add( AccessRadioButton );
        SecondPanel.Controls.Add( SQLiteRadioButton );
        SecondPanel.Controls.Add( SqlCeRadioButton );
        SecondPanel.DataFilter =  null ;
        SecondPanel.Dock =  System.Windows.Forms.DockStyle.Fill ;
        SecondPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SecondPanel.ForeColor =  System.Drawing.Color.Transparent ;
        SecondPanel.HoverText =  null ;
        SecondPanel.IsDerivedStyle =  true ;
        SecondPanel.Location =  new System.Drawing.Point( 3, 27 ) ;
        SecondPanel.Name =  "SecondPanel" ;
        SecondPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        SecondPanel.Size =  new System.Drawing.Size( 340, 70 ) ;
        SecondPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
        SecondPanel.StyleManager =  null ;
        SecondPanel.TabIndex =  3 ;
        SecondPanel.ThemeAuthor =  "Terry D. Eppler" ;
        SecondPanel.ThemeName =  "Budget Execution" ;
        SecondPanel.ToolTip =  null ;
        // 
        // SqlServerRadioButton
        // 
        SqlServerRadioButton.BackgroundColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
        SqlServerRadioButton.BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlServerRadioButton.Checked =  false ;
        SqlServerRadioButton.CheckSignColor =  System.Drawing.Color.LimeGreen ;
        SqlServerRadioButton.CheckState =  MetroSet_UI.Enums.CheckState.Unchecked ;
        SqlServerRadioButton.DisabledBorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        SqlServerRadioButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SqlServerRadioButton.Group =  0 ;
        SqlServerRadioButton.HoverText =  null ;
        SqlServerRadioButton.IsDerivedStyle =  true ;
        SqlServerRadioButton.Location =  new System.Drawing.Point( 255, 29 ) ;
        SqlServerRadioButton.Name =  "SqlServerRadioButton" ;
        SqlServerRadioButton.Padding =  new System.Windows.Forms.Padding( 3 ) ;
        SqlServerRadioButton.Result =  null ;
        SqlServerRadioButton.Size =  new System.Drawing.Size( 81, 17 ) ;
        SqlServerRadioButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        SqlServerRadioButton.StyleManager =  null ;
        SqlServerRadioButton.TabIndex =  2 ;
        SqlServerRadioButton.Tag =  "SqlServer" ;
        SqlServerRadioButton.Text =  "SQL Server" ;
        SqlServerRadioButton.ThemeAuthor =  "Terry D. Eppler" ;
        SqlServerRadioButton.ThemeName =  "Budget Execution" ;
        SqlServerRadioButton.ToolTip =  null ;
        // 
        // AccessRadioButton
        // 
        AccessRadioButton.BackgroundColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
        AccessRadioButton.BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        AccessRadioButton.Checked =  false ;
        AccessRadioButton.CheckSignColor =  System.Drawing.Color.LimeGreen ;
        AccessRadioButton.CheckState =  MetroSet_UI.Enums.CheckState.Unchecked ;
        AccessRadioButton.DisabledBorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        AccessRadioButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        AccessRadioButton.Group =  0 ;
        AccessRadioButton.HoverText =  null ;
        AccessRadioButton.IsDerivedStyle =  true ;
        AccessRadioButton.Location =  new System.Drawing.Point( 14, 29 ) ;
        AccessRadioButton.Name =  "AccessRadioButton" ;
        AccessRadioButton.Padding =  new System.Windows.Forms.Padding( 3 ) ;
        AccessRadioButton.Result =  null ;
        AccessRadioButton.Size =  new System.Drawing.Size( 64, 17 ) ;
        AccessRadioButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        AccessRadioButton.StyleManager =  null ;
        AccessRadioButton.TabIndex =  0 ;
        AccessRadioButton.Tag =  "Access" ;
        AccessRadioButton.Text =  "Access" ;
        AccessRadioButton.ThemeAuthor =  "Terry D. Eppler" ;
        AccessRadioButton.ThemeName =  "Budget Execution" ;
        AccessRadioButton.ToolTip =  ToollTip ;
        // 
        // ToollTip
        // 
        ToollTip.AutoPopDelay =  5000 ;
        ToollTip.BackColor =  System.Drawing.Color.FromArgb(   5  ,   5  ,   5   ) ;
        ToollTip.BindingSource =  null ;
        ToollTip.BorderColor =  System.Drawing.SystemColors.Highlight ;
        ToollTip.ForeColor =  System.Drawing.Color.White ;
        ToollTip.InitialDelay =  500 ;
        ToollTip.IsDerivedStyle =  true ;
        ToollTip.Name =  null ;
        ToollTip.OwnerDraw =  true ;
        ToollTip.ReshowDelay =  100 ;
        ToollTip.Style =  MetroSet_UI.Enums.Style.Custom ;
        ToollTip.StyleManager =  null ;
        ToollTip.ThemeAuthor =  "Terry D. Eppler" ;
        ToollTip.ThemeName =  "Budget Execution" ;
        ToollTip.TipIcon =  System.Windows.Forms.ToolTipIcon.Info ;
        ToollTip.TipText =  null ;
        ToollTip.TipTitle =  null ;
        // 
        // SQLiteRadioButton
        // 
        SQLiteRadioButton.BackgroundColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
        SQLiteRadioButton.BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SQLiteRadioButton.Checked =  false ;
        SQLiteRadioButton.CheckSignColor =  System.Drawing.Color.LimeGreen ;
        SQLiteRadioButton.CheckState =  MetroSet_UI.Enums.CheckState.Unchecked ;
        SQLiteRadioButton.DisabledBorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        SQLiteRadioButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SQLiteRadioButton.Group =  0 ;
        SQLiteRadioButton.HoverText =  null ;
        SQLiteRadioButton.IsDerivedStyle =  true ;
        SQLiteRadioButton.Location =  new System.Drawing.Point( 84, 29 ) ;
        SQLiteRadioButton.Name =  "SQLiteRadioButton" ;
        SQLiteRadioButton.Padding =  new System.Windows.Forms.Padding( 3 ) ;
        SQLiteRadioButton.Result =  null ;
        SQLiteRadioButton.Size =  new System.Drawing.Size( 64, 17 ) ;
        SQLiteRadioButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        SQLiteRadioButton.StyleManager =  null ;
        SQLiteRadioButton.TabIndex =  1 ;
        SQLiteRadioButton.Tag =  "SQLite" ;
        SQLiteRadioButton.Text =  "SQLite" ;
        SQLiteRadioButton.ThemeAuthor =  "Terry D. Eppler" ;
        SQLiteRadioButton.ThemeName =  "Budget Execution" ;
        SQLiteRadioButton.ToolTip =  null ;
        // 
        // SqlCeRadioButton
        // 
        SqlCeRadioButton.BackgroundColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
        SqlCeRadioButton.BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlCeRadioButton.Checked =  false ;
        SqlCeRadioButton.CheckSignColor =  System.Drawing.Color.LimeGreen ;
        SqlCeRadioButton.CheckState =  MetroSet_UI.Enums.CheckState.Unchecked ;
        SqlCeRadioButton.DisabledBorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        SqlCeRadioButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SqlCeRadioButton.Group =  0 ;
        SqlCeRadioButton.HoverText =  null ;
        SqlCeRadioButton.IsDerivedStyle =  true ;
        SqlCeRadioButton.Location =  new System.Drawing.Point( 154, 29 ) ;
        SqlCeRadioButton.Name =  "SqlCeRadioButton" ;
        SqlCeRadioButton.Padding =  new System.Windows.Forms.Padding( 3 ) ;
        SqlCeRadioButton.Result =  null ;
        SqlCeRadioButton.Size =  new System.Drawing.Size( 95, 17 ) ;
        SqlCeRadioButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        SqlCeRadioButton.StyleManager =  null ;
        SqlCeRadioButton.TabIndex =  1 ;
        SqlCeRadioButton.Tag =  "SqlCe" ;
        SqlCeRadioButton.Text =  "SQL Compact" ;
        SqlCeRadioButton.ThemeAuthor =  "Terry D. Eppler" ;
        SqlCeRadioButton.ThemeName =  "Budget Execution" ;
        SqlCeRadioButton.ToolTip =  null ;
        // 
        // CommandTable
        // 
        CommandTable.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CommandTable.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
        CommandTable.CaptionText =  "Commands" ;
        CommandTable.ColumnCount =  1 ;
        CommandTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        CommandTable.Controls.Add( ThirdPanel, 0, 1 );
        CommandTable.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        CommandTable.ForeColor =  System.Drawing.Color.DarkGray ;
        CommandTable.Location =  new System.Drawing.Point( 3, 109 ) ;
        CommandTable.Name =  "CommandTable" ;
        CommandTable.RowCount =  2 ;
        CommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        CommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 90F ) );
        CommandTable.Size =  new System.Drawing.Size( 346, 96 ) ;
        CommandTable.TabIndex =  1 ;
        // 
        // ThirdPanel
        // 
        ThirdPanel.BackColor =  System.Drawing.Color.Transparent ;
        ThirdPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        ThirdPanel.BindingSource =  null ;
        ThirdPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        ThirdPanel.BorderThickness =  1 ;
        ThirdPanel.Children =  null ;
        ThirdPanel.Controls.Add( SqlComboBox );
        ThirdPanel.DataFilter =  null ;
        ThirdPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ThirdPanel.ForeColor =  System.Drawing.Color.Transparent ;
        ThirdPanel.HoverText =  null ;
        ThirdPanel.IsDerivedStyle =  true ;
        ThirdPanel.Location =  new System.Drawing.Point( 3, 27 ) ;
        ThirdPanel.Name =  "ThirdPanel" ;
        ThirdPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        ThirdPanel.Size =  new System.Drawing.Size( 340, 66 ) ;
        ThirdPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
        ThirdPanel.StyleManager =  null ;
        ThirdPanel.TabIndex =  2 ;
        ThirdPanel.ThemeAuthor =  "Terry D. Eppler" ;
        ThirdPanel.ThemeName =  "Budget Execution" ;
        ThirdPanel.ToolTip =  null ;
        // 
        // SqlComboBox
        // 
        SqlComboBox.AllowDrop =  true ;
        SqlComboBox.Anchor =      System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right   ;
        SqlComboBox.ArrowColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlComboBox.BackColor =  System.Drawing.Color.Transparent ;
        SqlComboBox.BackgroundColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
        SqlComboBox.BindingSource =  null ;
        SqlComboBox.BorderColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        SqlComboBox.CausesValidation =  false ;
        SqlComboBox.DataFilter =  null ;
        SqlComboBox.DisabledBackColor =  System.Drawing.Color.Transparent ;
        SqlComboBox.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        SqlComboBox.DisabledForeColor =  System.Drawing.Color.Transparent ;
        SqlComboBox.DrawMode =  System.Windows.Forms.DrawMode.OwnerDrawFixed ;
        SqlComboBox.DropDownStyle =  System.Windows.Forms.ComboBoxStyle.DropDownList ;
        SqlComboBox.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
        SqlComboBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SqlComboBox.FormattingEnabled =  true ;
        SqlComboBox.HoverText =  null ;
        SqlComboBox.IsDerivedStyle =  true ;
        SqlComboBox.ItemHeight =  24 ;
        SqlComboBox.Location =  new System.Drawing.Point( 46, 16 ) ;
        SqlComboBox.Name =  "SqlComboBox" ;
        SqlComboBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlComboBox.SelectedItemForeColor =  System.Drawing.Color.White ;
        SqlComboBox.Size =  new System.Drawing.Size( 252, 30 ) ;
        SqlComboBox.Style =  MetroSet_UI.Enums.Style.Custom ;
        SqlComboBox.StyleManager =  null ;
        SqlComboBox.TabIndex =  0 ;
        SqlComboBox.ThemeAuthor =  "Terry D. Eppler" ;
        SqlComboBox.ThemeName =  "Budget Execution" ;
        SqlComboBox.ToolTip =  null ;
        // 
        // SqlStatementTable
        // 
        SqlStatementTable.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        SqlStatementTable.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
        SqlStatementTable.CaptionText =  "SQL Statements" ;
        SqlStatementTable.ColumnCount =  1 ;
        SqlStatementTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        SqlStatementTable.Controls.Add( TextPanel, 0, 1 );
        SqlStatementTable.Dock =  System.Windows.Forms.DockStyle.Fill ;
        SqlStatementTable.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SqlStatementTable.ForeColor =  System.Drawing.Color.DarkGray ;
        SqlStatementTable.Location =  new System.Drawing.Point( 3, 213 ) ;
        SqlStatementTable.Name =  "SqlStatementTable" ;
        SqlStatementTable.RowCount =  2 ;
        SqlStatementTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.58422947F ) );
        SqlStatementTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.41577F ) );
        SqlStatementTable.Size =  new System.Drawing.Size( 346, 293 ) ;
        SqlStatementTable.TabIndex =  1 ;
        // 
        // TextPanel
        // 
        TextPanel.BackColor =  System.Drawing.Color.Transparent ;
        TextPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        TextPanel.BindingSource =  null ;
        TextPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        TextPanel.BorderThickness =  1 ;
        TextPanel.Children =  null ;
        TextPanel.Controls.Add( SqlListBox );
        TextPanel.DataFilter =  null ;
        TextPanel.Dock =  System.Windows.Forms.DockStyle.Fill ;
        TextPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        TextPanel.ForeColor =  System.Drawing.Color.Transparent ;
        TextPanel.HoverText =  null ;
        TextPanel.IsDerivedStyle =  true ;
        TextPanel.Location =  new System.Drawing.Point( 3, 28 ) ;
        TextPanel.Name =  "TextPanel" ;
        TextPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        TextPanel.Size =  new System.Drawing.Size( 340, 262 ) ;
        TextPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
        TextPanel.StyleManager =  null ;
        TextPanel.TabIndex =  1 ;
        TextPanel.ThemeAuthor =  "Terry D. Eppler" ;
        TextPanel.ThemeName =  "Budget Execution" ;
        TextPanel.ToolTip =  null ;
        // 
        // SqlListBox
        // 
        SqlListBox.Anchor =      System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right   ;
        SqlListBox.BackColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
        SqlListBox.BindingSource =  null ;
        SqlListBox.BorderColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
        SqlListBox.DataFilter =  null ;
        SqlListBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        SqlListBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        SqlListBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SqlListBox.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        SqlListBox.HoveredItemColor =  System.Drawing.Color.White ;
        SqlListBox.HoverText =  null ;
        SqlListBox.IsDerivedStyle =  true ;
        SqlListBox.ItemHeight =  28 ;
        SqlListBox.Location =  new System.Drawing.Point( 15, 23 ) ;
        SqlListBox.Margin =  new System.Windows.Forms.Padding( 1 ) ;
        SqlListBox.MultiSelect =  true ;
        SqlListBox.Name =  "SqlListBox" ;
        SqlListBox.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        SqlListBox.SelectedIndex =  -1 ;
        SqlListBox.SelectedItem =  null ;
        SqlListBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SqlListBox.SelectedItemColor =  System.Drawing.Color.White ;
        SqlListBox.SelectedText =  null ;
        SqlListBox.SelectedValue =  null ;
        SqlListBox.ShowBorder =  false ;
        SqlListBox.ShowScrollBar =  false ;
        SqlListBox.Size =  new System.Drawing.Size( 311, 221 ) ;
        SqlListBox.Style =  MetroSet_UI.Enums.Style.Custom ;
        SqlListBox.StyleManager =  null ;
        SqlListBox.TabIndex =  0 ;
        SqlListBox.ThemeAuthor =  "Terry D. Eppler" ;
        SqlListBox.ThemeName =  "Budget Execution" ;
        SqlListBox.ToolTip =  null ;
        // 
        // FirstButton
        // 
        FirstButton.BackColor =  System.Drawing.Color.Transparent ;
        FirstButton.BindingSource =  null ;
        FirstButton.DataFilter =  null ;
        FirstButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        FirstButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        FirstButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        FirstButton.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        FirstButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        FirstButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        FirstButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
        FirstButton.HoverText =  "Not Yet Implemented!" ;
        FirstButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        FirstButton.IsDerivedStyle =  true ;
        FirstButton.Location =  new System.Drawing.Point( 604, 600 ) ;
        FirstButton.Margin =  new System.Windows.Forms.Padding( 0 ) ;
        FirstButton.Name =  "FirstButton" ;
        FirstButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        FirstButton.NormalColor =  System.Drawing.Color.Transparent ;
        FirstButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        FirstButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        FirstButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        FirstButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        FirstButton.PressTextColor =  System.Drawing.Color.White ;
        FirstButton.Size =  new System.Drawing.Size( 78, 26 ) ;
        FirstButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        FirstButton.StyleManager =  null ;
        FirstButton.TabIndex =  12 ;
        FirstButton.Text =  "Select" ;
        FirstButton.ThemeAuthor =  "Terry D. Eppler" ;
        FirstButton.ThemeName =  "BudgetExecution" ;
        FirstButton.ToolTip =  null ;
        // 
        // SecondButton
        // 
        SecondButton.BackColor =  System.Drawing.Color.Transparent ;
        SecondButton.BindingSource =  null ;
        SecondButton.DataFilter =  null ;
        SecondButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        SecondButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        SecondButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        SecondButton.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SecondButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SecondButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SecondButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
        SecondButton.HoverText =  "Not Yet Implemented!" ;
        SecondButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        SecondButton.IsDerivedStyle =  true ;
        SecondButton.Location =  new System.Drawing.Point( 157, 600 ) ;
        SecondButton.Margin =  new System.Windows.Forms.Padding( 0 ) ;
        SecondButton.Name =  "SecondButton" ;
        SecondButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        SecondButton.NormalColor =  System.Drawing.Color.Transparent ;
        SecondButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SecondButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        SecondButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SecondButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SecondButton.PressTextColor =  System.Drawing.Color.White ;
        SecondButton.Size =  new System.Drawing.Size( 78, 26 ) ;
        SecondButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        SecondButton.StyleManager =  null ;
        SecondButton.TabIndex =  10 ;
        SecondButton.Text =  "Clear" ;
        SecondButton.ThemeAuthor =  "Terry D. Eppler" ;
        SecondButton.ThemeName =  "BudgetExecution" ;
        SecondButton.ToolTip =  null ;
        // 
        // ThirdButton
        // 
        ThirdButton.Anchor =    System.Windows.Forms.AnchorStyles.Bottom  |  System.Windows.Forms.AnchorStyles.Right   ;
        ThirdButton.BackColor =  System.Drawing.Color.Transparent ;
        ThirdButton.BindingSource =  null ;
        ThirdButton.DataFilter =  null ;
        ThirdButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        ThirdButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        ThirdButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        ThirdButton.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ThirdButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ThirdButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ThirdButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
        ThirdButton.HoverText =  "Close Window" ;
        ThirdButton.HoverTextColor =  System.Drawing.Color.White ;
        ThirdButton.IsDerivedStyle =  true ;
        ThirdButton.Location =  new System.Drawing.Point( 1099, 600 ) ;
        ThirdButton.Margin =  new System.Windows.Forms.Padding( 0 ) ;
        ThirdButton.Name =  "ThirdButton" ;
        ThirdButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        ThirdButton.NormalColor =  System.Drawing.Color.Transparent ;
        ThirdButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ThirdButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        ThirdButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ThirdButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ThirdButton.PressTextColor =  System.Drawing.Color.White ;
        ThirdButton.Size =  new System.Drawing.Size( 78, 26 ) ;
        ThirdButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        ThirdButton.StyleManager =  null ;
        ThirdButton.TabIndex =  11 ;
        ThirdButton.Text =  "Close" ;
        ThirdButton.ThemeAuthor =  "Terry D. Eppler" ;
        ThirdButton.ThemeName =  "BudgetExecution" ;
        ThirdButton.ToolTip =  null ;
        // 
        // ContextMenu
        // 
        ContextMenu.AutoSize =  false ;
        ContextMenu.BackColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
        ContextMenu.ForeColor =  System.Drawing.Color.White ;
        ContextMenu.IsDerivedStyle =  false ;
        ContextMenu.Name =  "ContextMenu" ;
        ContextMenu.RenderMode =  System.Windows.Forms.ToolStripRenderMode.System ;
        ContextMenu.Size =  new System.Drawing.Size( 156, 264 ) ;
        ContextMenu.Style =  MetroSet_UI.Enums.Style.Custom ;
        ContextMenu.StyleManager =  null ;
        ContextMenu.ThemeAuthor =  "Terry D. Eppler" ;
        ContextMenu.ThemeName =  "Budget Execution" ;
        // 
        // SqlDialog
        // 
        AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
        AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
        BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        CaptionFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
        ClientSize =  new System.Drawing.Size( 1310, 648 ) ;
        Controls.Add( FirstButton );
        Controls.Add( SecondButton );
        Controls.Add( ThirdButton );
        Controls.Add( TabControl );
        FormBorderStyle =  System.Windows.Forms.FormBorderStyle.None ;
        Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
        MaximumSize =  new System.Drawing.Size( 1310, 648 ) ;
        MinimumSize =  new System.Drawing.Size( 1310, 646 ) ;
        Name =  "SqlDialog" ;
        SizeGripStyle =  System.Windows.Forms.SizeGripStyle.Hide ;
        ( (System.ComponentModel.ISupportInitialize) TabControl  ).EndInit( );
        TabControl.ResumeLayout( false );
        TabPage.ResumeLayout( false );
        EditorTable.ResumeLayout( false );
        EditorPanel.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) SqlEditor  ).EndInit( );
        SqlCommandTable.ResumeLayout( false );
        ProviderTable.ResumeLayout( false );
        SecondPanel.ResumeLayout( false );
        CommandTable.ResumeLayout( false );
        ThirdPanel.ResumeLayout( false );
        SqlStatementTable.ResumeLayout( false );
        TextPanel.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion

    public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv TabPage;
    public Button FirstButton;
    public Button SecondButton;
    public Button ThirdButton;
    public Layout EditorPanel;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToollTip;
    public System.Windows.Forms.TableLayoutPanel SqlCommandTable;
    public Layout SecondPanel;
    public RadioButton SqlServerRadioButton;
    public RadioButton SqlCeRadioButton;
    public RadioButton SQLiteRadioButton;
    public Layout ThirdPanel;
    public ComboBox SqlComboBox;
    public Layout TextPanel;
    public ListBox SqlListBox;
    public RadioButton AccessRadioButton;
    public Editor SqlEditor;
    public HeaderPanel SqlStatementTable;
    public ContextMenu ContextMenu;
    public HeaderPanel CommandTable;
    public HeaderPanel ProviderTable;
    private HeaderPanel EditorTable;
}