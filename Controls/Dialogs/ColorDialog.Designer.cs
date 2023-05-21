﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class ColorDialog
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
        var metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( ColorDialog ) );
        CloseButton =  new Button( ) ;
        ToolTip =  new SmallTip( ) ;
        BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
        SelectButton =  new Button( ) ;
        ButtonPanel =  new Layout( ) ;
        HeaderTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
        Picture =  new System.Windows.Forms.PictureBox( ) ;
        label1 =  new Label( ) ;
        ColorPicker =  new Syncfusion.Windows.Forms.ColorUIControl( ) ;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        HeaderTable.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) Picture  ).BeginInit( );
        SuspendLayout( );
        // 
        // CloseButton
        // 
        CloseButton.BindingSource =  null ;
        CloseButton.DataFilter =  null ;
        CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
        CloseButton.HoverText =  "Close Window" ;
        CloseButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        CloseButton.IsDerivedStyle =  true ;
        CloseButton.Location =  new System.Drawing.Point( 227, 364 ) ;
        CloseButton.Name =  "CloseButton" ;
        CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
        CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CloseButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CloseButton.PressTextColor =  System.Drawing.Color.White ;
        CloseButton.Size =  new System.Drawing.Size( 78, 26 ) ;
        CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        CloseButton.StyleManager =  null ;
        CloseButton.TabIndex =  2 ;
        CloseButton.Text =  "Close " ;
        CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
        CloseButton.ThemeName =  "Budget Execution" ;
        CloseButton.ToolTip =  ToolTip ;
        // 
        // ToolTip
        // 
        ToolTip.AutoPopDelay =  5000 ;
        ToolTip.BackColor =  System.Drawing.Color.FromArgb(   5  ,   5  ,   5   ) ;
        ToolTip.BindingSource =  BindingSource ;
        ToolTip.BorderColor =  System.Drawing.SystemColors.Highlight ;
        ToolTip.ForeColor =  System.Drawing.Color.White ;
        ToolTip.InitialDelay =  500 ;
        ToolTip.IsDerivedStyle =  true ;
        ToolTip.Name =  null ;
        ToolTip.OwnerDraw =  true ;
        ToolTip.ReshowDelay =  100 ;
        ToolTip.Style =  MetroSet_UI.Enums.Style.Custom ;
        ToolTip.StyleManager =  null ;
        ToolTip.ThemeAuthor =  "Terry D. Eppler" ;
        ToolTip.ThemeName =  "Budget Execution" ;
        ToolTip.TipIcon =  System.Windows.Forms.ToolTipIcon.Info ;
        ToolTip.TipText =  "" ;
        ToolTip.TipTitle =  null ;
        // 
        // SelectButton
        // 
        SelectButton.BindingSource =  null ;
        SelectButton.DataFilter =  null ;
        SelectButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        SelectButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        SelectButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        SelectButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SelectButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SelectButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        SelectButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
        SelectButton.HoverText =  "Choose Color" ;
        SelectButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        SelectButton.IsDerivedStyle =  true ;
        SelectButton.Location =  new System.Drawing.Point( 80, 364 ) ;
        SelectButton.Name =  "SelectButton" ;
        SelectButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        SelectButton.NormalColor =  System.Drawing.Color.Transparent ;
        SelectButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SelectButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        SelectButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SelectButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SelectButton.PressTextColor =  System.Drawing.Color.White ;
        SelectButton.Size =  new System.Drawing.Size( 78, 26 ) ;
        SelectButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        SelectButton.StyleManager =  null ;
        SelectButton.TabIndex =  3 ;
        SelectButton.Text =  "Select" ;
        SelectButton.ThemeAuthor =  "Terry D. Eppler" ;
        SelectButton.ThemeName =  "Budget Execution" ;
        SelectButton.ToolTip =  ToolTip ;
        // 
        // ButtonPanel
        // 
        ButtonPanel.BackColor =  System.Drawing.Color.Transparent ;
        ButtonPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        ButtonPanel.BindingSource =  null ;
        ButtonPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        ButtonPanel.BorderThickness =  1 ;
        ButtonPanel.Children =  null ;
        ButtonPanel.DataFilter =  null ;
        ButtonPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ButtonPanel.ForeColor =  System.Drawing.Color.Transparent ;
        ButtonPanel.HoverText =  null ;
        ButtonPanel.IsDerivedStyle =  true ;
        ButtonPanel.Location =  new System.Drawing.Point( 12, 38 ) ;
        ButtonPanel.Name =  "ButtonPanel" ;
        ButtonPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        ButtonPanel.Size =  new System.Drawing.Size( 305, 304 ) ;
        ButtonPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
        ButtonPanel.StyleManager =  null ;
        ButtonPanel.TabIndex =  5 ;
        ButtonPanel.ThemeAuthor =  "Terry D. Eppler" ;
        ButtonPanel.ThemeName =  "Budget Execution" ;
        ButtonPanel.ToolTip =  null ;
        // 
        // HeaderTable
        // 
        HeaderTable.ColumnCount =  2 ;
        HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 293F ) );
        HeaderTable.Controls.Add( Picture, 0, 0 );
        HeaderTable.Controls.Add( label1, 1, 0 );
        HeaderTable.Dock =  System.Windows.Forms.DockStyle.Top ;
        HeaderTable.Location =  new System.Drawing.Point( 0, 0 ) ;
        HeaderTable.Name =  "HeaderTable" ;
        HeaderTable.RowCount =  1 ;
        HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        HeaderTable.Size =  new System.Drawing.Size( 329, 30 ) ;
        HeaderTable.TabIndex =  6 ;
        // 
        // Picture
        // 
        Picture.Dock =  System.Windows.Forms.DockStyle.Fill ;
        Picture.Location =  new System.Drawing.Point( 3, 3 ) ;
        Picture.Name =  "Picture" ;
        Picture.Size =  new System.Drawing.Size( 30, 24 ) ;
        Picture.TabIndex =  0 ;
        Picture.TabStop =  false ;
        // 
        // label1
        // 
        label1.BindingSource =  null ;
        label1.DataFilter =  null ;
        label1.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
        label1.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        label1.HoverText =  null ;
        label1.IsDerivedStyle =  true ;
        label1.Location =  new System.Drawing.Point( 39, 3 ) ;
        label1.Margin =  new System.Windows.Forms.Padding( 3 ) ;
        label1.Name =  "label1" ;
        label1.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        label1.Size =  new System.Drawing.Size( 165, 23 ) ;
        label1.Style =  MetroSet_UI.Enums.Style.Custom ;
        label1.StyleManager =  null ;
        label1.TabIndex =  1 ;
        label1.Text =  "Color Selector" ;
        label1.TextAlign =  System.Drawing.ContentAlignment.MiddleLeft ;
        label1.ThemeAuthor =  "Terry D. Eppler" ;
        label1.ThemeName =  "Budget Execution" ;
        label1.ToolTip =  ToolTip ;
        // 
        // ColorPicker
        // 
        ColorPicker.BeforeTouchSize =  new System.Drawing.Size( 266, 269 ) ;
        ColorPicker.BorderStyle =  System.Windows.Forms.BorderStyle.None ;
        ColorPicker.ForeColor =  System.Drawing.Color.FromArgb(   150  ,   150  ,   150   ) ;
        ColorPicker.Location =  new System.Drawing.Point( 30, 53 ) ;
        ColorPicker.MetroColor =  System.Drawing.Color.FromArgb(   1  ,   115  ,   199   ) ;
        ColorPicker.MetroForeColor =  System.Drawing.Color.FromArgb(   68  ,   68  ,   68   ) ;
        ColorPicker.Name =  "ColorPicker" ;
        ColorPicker.ScrollMetroColorTable =  metroColorTable1 ;
        ColorPicker.Size =  new System.Drawing.Size( 266, 269 ) ;
        ColorPicker.TabIndex =  0 ;
        ColorPicker.ThemeName =  "Office2016Black" ;
        ColorPicker.ThemeStyle.ColorListStyle.PaletteBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ColorPicker.ThemeStyle.ColorListStyle.SelectedItemForeColor =  System.Drawing.Color.FromArgb(   80  ,   80  ,   80   ) ;
        ColorPicker.ThemeStyle.ColorPaletteStyle.BorderColor =  System.Drawing.Color.FromArgb(   210  ,   210  ,   210   ) ;
        ColorPicker.ThemeStyle.ColorPaletteStyle.SelectedBorderColor =  System.Drawing.Color.FromArgb(   0  ,   103  ,   176   ) ;
        ColorPicker.ThemeStyle.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ColorPicker.VisualStyle =  Syncfusion.Windows.Forms.ColorUIStyle.Office2016Black ;
        // 
        // ColorDialog
        // 
        AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
        AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
        BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        BorderThickness =  2 ;
        CaptionAlign =  System.Windows.Forms.HorizontalAlignment.Left ;
        CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionBarHeight =  5 ;
        CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        ClientSize =  new System.Drawing.Size( 329, 396 ) ;
        Controls.Add( SelectButton );
        Controls.Add( ColorPicker );
        Controls.Add( CloseButton );
        Controls.Add( HeaderTable );
        Controls.Add( ButtonPanel );
        Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ForeColor =  System.Drawing.Color.LightGray ;
        FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
        Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
        MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        Name =  "ColorDialog" ;
        ShowIcon =  false ;
        Text =  "ColorDialog" ;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        HeaderTable.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) Picture  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion
    private Layout ButtonPanel;
    public SmallTip ToolTip;
    public System.Windows.Forms.BindingSource BindingSource;
    public System.Windows.Forms.PictureBox Picture;
    public Syncfusion.Windows.Forms.ColorUIControl ColorPicker;
    public Label label1;
    public System.Windows.Forms.TableLayoutPanel HeaderTable;
    public Button CloseButton;
    public Button SelectButton;
}