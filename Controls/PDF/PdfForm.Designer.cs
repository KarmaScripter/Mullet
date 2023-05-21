﻿namespace BudgetExecution
{
    using System.Windows.Forms;


    partial class PdfForm
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
            var messageBoxSettings2 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings( );
            var pdfViewerPrinterSettings2 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( PdfForm ) );
            var textSearchSettings2 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings( );
            ToolTip =  new SmallTip( ) ;
            BindingSource =  new BindingSource( components ) ;
            DocViewer =  new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl( ) ;
            LeftTable =  new TableLayoutPanel( ) ;
            PictureBox =  new PictureBox( ) ;
            HeaderLabel =  new Label( ) ;
            DocumentPanel =  new Layout( ) ;
            ListBoxPanel =  new Layout( ) ;
            ListBox =  new ListBox( ) ;
            CloseButtonTable =  new TableLayoutPanel( ) ;
            MenuButton =  new Button( ) ;
            CloseButton =  new Button( ) ;
            BackButton =  new Button( ) ;
            RightTable =  new TableLayoutPanel( ) ;
            CloseTablePanel =  new Layout( ) ;
            LeftButtonLayout =  new Layout( ) ;
            LeftButtonTable =  new TableLayoutPanel( ) ;
            ExcelButton =  new Button( ) ;
            ChartButton =  new Button( ) ;
            DataGridButton =  new Button( ) ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            LeftTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            DocumentPanel.SuspendLayout( );
            ListBoxPanel.SuspendLayout( );
            CloseButtonTable.SuspendLayout( );
            RightTable.SuspendLayout( );
            CloseTablePanel.SuspendLayout( );
            LeftButtonLayout.SuspendLayout( );
            LeftButtonTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay =  5000 ;
            ToolTip.BackColor =  System.Drawing.Color.FromArgb(   5  ,   5  ,   5   ) ;
            ToolTip.BindingSource =  null ;
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
            ToolTip.TipIcon =  ToolTipIcon.Info ;
            ToolTip.TipText =  null ;
            ToolTip.TipTitle =  null ;
            // 
            // DocViewer
            // 
            DocViewer.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            DocViewer.CursorMode =  Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool ;
            DocViewer.EnableContextMenu =  true ;
            DocViewer.EnableNotificationBar =  true ;
            DocViewer.HorizontalScrollOffset =  0 ;
            DocViewer.IsBookmarkEnabled =  true ;
            DocViewer.IsTextSearchEnabled =  true ;
            DocViewer.IsTextSelectionEnabled =  true ;
            DocViewer.Location =  new System.Drawing.Point( 9, 12 ) ;
            messageBoxSettings2.EnableNotification =  true ;
            DocViewer.MessageBoxSettings =  messageBoxSettings2 ;
            DocViewer.MinimumZoomPercentage =  50 ;
            DocViewer.Name =  "DocViewer" ;
            DocViewer.PageBorderThickness =  1 ;
            pdfViewerPrinterSettings2.Copies =  1 ;
            pdfViewerPrinterSettings2.PageOrientation =  Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto ;
            pdfViewerPrinterSettings2.PageSize =  Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize ;
            pdfViewerPrinterSettings2.PrintLocation =  (System.Drawing.PointF) resources.GetObject( "pdfViewerPrinterSettings2.PrintLocation" )  ;
            pdfViewerPrinterSettings2.ShowPrintStatusDialog =  true ;
            DocViewer.PrinterSettings =  pdfViewerPrinterSettings2 ;
            DocViewer.ReferencePath =  null ;
            DocViewer.ScrollDisplacementValue =  0 ;
            DocViewer.ShowHorizontalScrollBar =  true ;
            DocViewer.ShowToolBar =  true ;
            DocViewer.ShowVerticalScrollBar =  true ;
            DocViewer.Size =  new System.Drawing.Size( 1025, 624 ) ;
            DocViewer.SpaceBetweenPages =  8 ;
            DocViewer.TabIndex =  2 ;
            textSearchSettings2.CurrentInstanceColor =  System.Drawing.Color.FromArgb(   127  ,   255  ,   171  ,   64   ) ;
            textSearchSettings2.HighlightAllInstance =  true ;
            textSearchSettings2.OtherInstanceColor =  System.Drawing.Color.FromArgb(   127  ,   254  ,   255  ,   0   ) ;
            DocViewer.TextSearchSettings =  textSearchSettings2 ;
            DocViewer.ThemeName =  "Office2016Black" ;
            DocViewer.UseWaitCursor =  true ;
            DocViewer.VerticalScrollOffset =  0 ;
            DocViewer.VisualStyle =  Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black ;
            DocViewer.ZoomMode =  Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitWidth ;
            // 
            // LeftTable
            // 
            LeftTable.ColumnCount =  3 ;
            LeftTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 6.12855F ) );
            LeftTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 77.13004F ) );
            LeftTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 16.6666641F ) );
            LeftTable.Controls.Add( PictureBox, 0, 0 );
            LeftTable.Controls.Add( HeaderLabel, 1, 0 );
            LeftTable.Dock =  DockStyle.Top ;
            LeftTable.Location =  new System.Drawing.Point( 0, 0 ) ;
            LeftTable.Name =  "LeftTable" ;
            LeftTable.RowCount =  1 ;
            LeftTable.RowStyles.Add( new RowStyle( SizeType.Percent, 5.12820435F ) );
            LeftTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            LeftTable.Size =  new System.Drawing.Size( 1338, 32 ) ;
            LeftTable.TabIndex =  3 ;
            LeftTable.UseWaitCursor =  true ;
            // 
            // PictureBox
            // 
            PictureBox.Image =  Properties.Resources.EPA ;
            PictureBox.Location =  new System.Drawing.Point( 3, 3 ) ;
            PictureBox.Name =  "PictureBox" ;
            PictureBox.Size =  new System.Drawing.Size( 43, 22 ) ;
            PictureBox.SizeMode =  PictureBoxSizeMode.StretchImage ;
            PictureBox.TabIndex =  5 ;
            PictureBox.TabStop =  false ;
            PictureBox.UseWaitCursor =  true ;
            // 
            // HeaderLabel
            // 
            HeaderLabel.BindingSource =  null ;
            HeaderLabel.DataFilter =  null ;
            HeaderLabel.Dock =  DockStyle.Fill ;
            HeaderLabel.FlatStyle =  FlatStyle.Flat ;
            HeaderLabel.Font =  new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            HeaderLabel.HoverText =  null ;
            HeaderLabel.IsDerivedStyle =  true ;
            HeaderLabel.Location =  new System.Drawing.Point( 85, 3 ) ;
            HeaderLabel.Margin =  new Padding( 3 ) ;
            HeaderLabel.Name =  "HeaderLabel" ;
            HeaderLabel.Padding =  new Padding( 1 ) ;
            HeaderLabel.Size =  new System.Drawing.Size( 1026, 26 ) ;
            HeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            HeaderLabel.StyleManager =  null ;
            HeaderLabel.TabIndex =  7 ;
            HeaderLabel.Text =  "Title" ;
            HeaderLabel.TextAlign =  System.Drawing.ContentAlignment.MiddleCenter ;
            HeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            HeaderLabel.ThemeName =  "Budget Execution" ;
            HeaderLabel.ToolTip =  null ;
            HeaderLabel.UseWaitCursor =  true ;
            // 
            // DocumentPanel
            // 
            DocumentPanel.BackColor =  System.Drawing.Color.Transparent ;
            DocumentPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            DocumentPanel.BindingSource =  null ;
            DocumentPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            DocumentPanel.BorderThickness =  1 ;
            DocumentPanel.Children =  null ;
            DocumentPanel.Controls.Add( DocViewer );
            DocumentPanel.DataFilter =  null ;
            DocumentPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            DocumentPanel.ForeColor =  System.Drawing.Color.Transparent ;
            DocumentPanel.HoverText =  null ;
            DocumentPanel.IsDerivedStyle =  true ;
            DocumentPanel.Location =  new System.Drawing.Point( 3, 38 ) ;
            DocumentPanel.Name =  "DocumentPanel" ;
            DocumentPanel.Padding =  new Padding( 1 ) ;
            DocumentPanel.Size =  new System.Drawing.Size( 1046, 651 ) ;
            DocumentPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            DocumentPanel.StyleManager =  null ;
            DocumentPanel.TabIndex =  4 ;
            DocumentPanel.ThemeAuthor =  "Terry D. Eppler" ;
            DocumentPanel.ThemeName =  "Budget Execution" ;
            DocumentPanel.ToolTip =  null ;
            DocumentPanel.UseWaitCursor =  true ;
            // 
            // ListBoxPanel
            // 
            ListBoxPanel.BackColor =  System.Drawing.Color.Transparent ;
            ListBoxPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ListBoxPanel.BindingSource =  null ;
            ListBoxPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            ListBoxPanel.BorderThickness =  1 ;
            ListBoxPanel.Children =  null ;
            ListBoxPanel.Controls.Add( ListBox );
            ListBoxPanel.DataFilter =  null ;
            ListBoxPanel.Dock =  DockStyle.Fill ;
            ListBoxPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ListBoxPanel.ForeColor =  System.Drawing.Color.Transparent ;
            ListBoxPanel.HoverText =  null ;
            ListBoxPanel.IsDerivedStyle =  true ;
            ListBoxPanel.Location =  new System.Drawing.Point( 3, 38 ) ;
            ListBoxPanel.Name =  "ListBoxPanel" ;
            ListBoxPanel.Padding =  new Padding( 1 ) ;
            ListBoxPanel.Size =  new System.Drawing.Size( 277, 651 ) ;
            ListBoxPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            ListBoxPanel.StyleManager =  null ;
            ListBoxPanel.TabIndex =  3 ;
            ListBoxPanel.ThemeAuthor =  "Terry D. Eppler" ;
            ListBoxPanel.ThemeName =  "Budget Execution" ;
            ListBoxPanel.ToolTip =  null ;
            ListBoxPanel.UseWaitCursor =  true ;
            // 
            // ListBox
            // 
            ListBox.BackColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
            ListBox.BindingSource =  null ;
            ListBox.BorderColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
            ListBox.DataFilter =  null ;
            ListBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ListBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ListBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ListBox.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            ListBox.HoveredItemColor =  System.Drawing.Color.White ;
            ListBox.HoverText =  null ;
            ListBox.IsDerivedStyle =  true ;
            ListBox.ItemHeight =  45 ;
            ListBox.Location =  new System.Drawing.Point( 14, 12 ) ;
            ListBox.Margin =  new Padding( 1 ) ;
            ListBox.MultiSelect =  false ;
            ListBox.Name =  "ListBox" ;
            ListBox.Padding =  new Padding( 3 ) ;
            ListBox.SelectedIndex =  -1 ;
            ListBox.SelectedItem =  null ;
            ListBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ListBox.SelectedItemColor =  System.Drawing.Color.White ;
            ListBox.SelectedText =  null ;
            ListBox.SelectedValue =  null ;
            ListBox.ShowBorder =  false ;
            ListBox.ShowScrollBar =  false ;
            ListBox.Size =  new System.Drawing.Size( 248, 624 ) ;
            ListBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            ListBox.StyleManager =  null ;
            ListBox.TabIndex =  0 ;
            ListBox.ThemeAuthor =  "Terry D. Eppler" ;
            ListBox.ThemeName =  "Budget Execution" ;
            ListBox.ToolTip =  null ;
            ListBox.UseWaitCursor =  true ;
            // 
            // CloseButtonTable
            // 
            CloseButtonTable.ColumnCount =  4 ;
            CloseButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            CloseButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            CloseButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 85F ) );
            CloseButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 8F ) );
            CloseButtonTable.Controls.Add( MenuButton, 2, 0 );
            CloseButtonTable.Controls.Add( CloseButton, 1, 0 );
            CloseButtonTable.Controls.Add( BackButton, 0, 0 );
            CloseButtonTable.Dock =  DockStyle.Bottom ;
            CloseButtonTable.GrowStyle =  TableLayoutPanelGrowStyle.FixedSize ;
            CloseButtonTable.Location =  new System.Drawing.Point( 1, 6 ) ;
            CloseButtonTable.Name =  "CloseButtonTable" ;
            CloseButtonTable.RowCount =  1 ;
            CloseButtonTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            CloseButtonTable.Size =  new System.Drawing.Size( 275, 34 ) ;
            CloseButtonTable.TabIndex =  8 ;
            CloseButtonTable.UseWaitCursor =  true ;
            // 
            // MenuButton
            // 
            MenuButton.BindingSource =  null ;
            MenuButton.DataFilter =  null ;
            MenuButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            MenuButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            MenuButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            MenuButton.Dock =  DockStyle.Fill ;
            MenuButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            MenuButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            MenuButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            MenuButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            MenuButton.HoverText =  null ;
            MenuButton.HoverTextColor =  System.Drawing.Color.White ;
            MenuButton.IsDerivedStyle =  true ;
            MenuButton.Location =  new System.Drawing.Point( 185, 3 ) ;
            MenuButton.Name =  "MenuButton" ;
            MenuButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            MenuButton.NormalColor =  System.Drawing.Color.Transparent ;
            MenuButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            MenuButton.Padding =  new Padding( 1 ) ;
            MenuButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            MenuButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            MenuButton.PressTextColor =  System.Drawing.Color.White ;
            MenuButton.Size =  new System.Drawing.Size( 79, 28 ) ;
            MenuButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            MenuButton.StyleManager =  null ;
            MenuButton.TabIndex =  5 ;
            MenuButton.Text =  "Home" ;
            MenuButton.ThemeAuthor =  "Terry D. Eppler" ;
            MenuButton.ThemeName =  "Budget Execution" ;
            MenuButton.ToolTip =  null ;
            MenuButton.UseWaitCursor =  true ;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource =  null ;
            CloseButton.DataFilter =  null ;
            CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            CloseButton.Dock =  DockStyle.Fill ;
            CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverText =  null ;
            CloseButton.HoverTextColor =  System.Drawing.Color.White ;
            CloseButton.IsDerivedStyle =  true ;
            CloseButton.Location =  new System.Drawing.Point( 94, 3 ) ;
            CloseButton.Name =  "CloseButton" ;
            CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.Padding =  new Padding( 1 ) ;
            CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressTextColor =  System.Drawing.Color.White ;
            CloseButton.Size =  new System.Drawing.Size( 85, 28 ) ;
            CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseButton.StyleManager =  null ;
            CloseButton.TabIndex =  3 ;
            CloseButton.Text =  "Close" ;
            CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
            CloseButton.ThemeName =  "Budget Execution" ;
            CloseButton.ToolTip =  null ;
            CloseButton.UseWaitCursor =  true ;
            // 
            // BackButton
            // 
            BackButton.BindingSource =  null ;
            BackButton.DataFilter =  null ;
            BackButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            BackButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            BackButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            BackButton.Dock =  DockStyle.Fill ;
            BackButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            BackButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            BackButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            BackButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            BackButton.HoverText =  null ;
            BackButton.HoverTextColor =  System.Drawing.Color.White ;
            BackButton.IsDerivedStyle =  true ;
            BackButton.Location =  new System.Drawing.Point( 3, 3 ) ;
            BackButton.Name =  "BackButton" ;
            BackButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            BackButton.NormalColor =  System.Drawing.Color.Transparent ;
            BackButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            BackButton.Padding =  new Padding( 1 ) ;
            BackButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            BackButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            BackButton.PressTextColor =  System.Drawing.Color.White ;
            BackButton.Size =  new System.Drawing.Size( 85, 28 ) ;
            BackButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            BackButton.StyleManager =  null ;
            BackButton.TabIndex =  4 ;
            BackButton.Text =  "Back" ;
            BackButton.ThemeAuthor =  "Terry D. Eppler" ;
            BackButton.ThemeName =  "Budget Execution" ;
            BackButton.ToolTip =  null ;
            BackButton.UseWaitCursor =  true ;
            // 
            // RightTable
            // 
            RightTable.ColumnCount =  1 ;
            RightTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            RightTable.Controls.Add( CloseTablePanel, 0, 2 );
            RightTable.Controls.Add( ListBoxPanel, 0, 1 );
            RightTable.Location =  new System.Drawing.Point( 1054, 0 ) ;
            RightTable.Name =  "RightTable" ;
            RightTable.RowCount =  3 ;
            RightTable.RowStyles.Add( new RowStyle( SizeType.Percent, 5.113636F ) );
            RightTable.RowStyles.Add( new RowStyle( SizeType.Percent, 94.88636F ) );
            RightTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 46F ) );
            RightTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            RightTable.Size =  new System.Drawing.Size( 283, 739 ) ;
            RightTable.TabIndex =  4 ;
            RightTable.UseWaitCursor =  true ;
            // 
            // CloseTablePanel
            // 
            CloseTablePanel.BackColor =  System.Drawing.Color.Transparent ;
            CloseTablePanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CloseTablePanel.BindingSource =  null ;
            CloseTablePanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            CloseTablePanel.BorderThickness =  1 ;
            CloseTablePanel.Children =  null ;
            CloseTablePanel.Controls.Add( CloseButtonTable );
            CloseTablePanel.DataFilter =  null ;
            CloseTablePanel.Dock =  DockStyle.Fill ;
            CloseTablePanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CloseTablePanel.ForeColor =  System.Drawing.Color.Transparent ;
            CloseTablePanel.HoverText =  null ;
            CloseTablePanel.IsDerivedStyle =  true ;
            CloseTablePanel.Location =  new System.Drawing.Point( 3, 695 ) ;
            CloseTablePanel.Name =  "CloseTablePanel" ;
            CloseTablePanel.Padding =  new Padding( 1 ) ;
            CloseTablePanel.Size =  new System.Drawing.Size( 277, 41 ) ;
            CloseTablePanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseTablePanel.StyleManager =  null ;
            CloseTablePanel.TabIndex =  9 ;
            CloseTablePanel.ThemeAuthor =  "Terry D. Eppler" ;
            CloseTablePanel.ThemeName =  "Budget Execution" ;
            CloseTablePanel.ToolTip =  null ;
            CloseTablePanel.UseWaitCursor =  true ;
            // 
            // LeftButtonLayout
            // 
            LeftButtonLayout.BackColor =  System.Drawing.Color.Transparent ;
            LeftButtonLayout.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            LeftButtonLayout.BindingSource =  null ;
            LeftButtonLayout.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            LeftButtonLayout.BorderThickness =  1 ;
            LeftButtonLayout.Children =  null ;
            LeftButtonLayout.Controls.Add( LeftButtonTable );
            LeftButtonLayout.DataFilter =  null ;
            LeftButtonLayout.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            LeftButtonLayout.ForeColor =  System.Drawing.Color.Transparent ;
            LeftButtonLayout.HoverText =  null ;
            LeftButtonLayout.IsDerivedStyle =  true ;
            LeftButtonLayout.Location =  new System.Drawing.Point( 3, 698 ) ;
            LeftButtonLayout.Name =  "LeftButtonLayout" ;
            LeftButtonLayout.Padding =  new Padding( 1 ) ;
            LeftButtonLayout.Size =  new System.Drawing.Size( 1045, 41 ) ;
            LeftButtonLayout.Style =  MetroSet_UI.Enums.Style.Custom ;
            LeftButtonLayout.StyleManager =  null ;
            LeftButtonLayout.TabIndex =  10 ;
            LeftButtonLayout.ThemeAuthor =  "Terry D. Eppler" ;
            LeftButtonLayout.ThemeName =  "Budget Execution" ;
            LeftButtonLayout.ToolTip =  null ;
            LeftButtonLayout.UseWaitCursor =  true ;
            // 
            // LeftButtonTable
            // 
            LeftButtonTable.ColumnCount =  7 ;
            LeftButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 46.84015F ) );
            LeftButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 53.15985F ) );
            LeftButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 158F ) );
            LeftButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 171F ) );
            LeftButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 204F ) );
            LeftButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 155F ) );
            LeftButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 103F ) );
            LeftButtonTable.Controls.Add( ExcelButton, 4, 0 );
            LeftButtonTable.Controls.Add( ChartButton, 3, 0 );
            LeftButtonTable.Controls.Add( DataGridButton, 2, 0 );
            LeftButtonTable.Dock =  DockStyle.Bottom ;
            LeftButtonTable.GrowStyle =  TableLayoutPanelGrowStyle.FixedSize ;
            LeftButtonTable.Location =  new System.Drawing.Point( 1, 6 ) ;
            LeftButtonTable.Name =  "LeftButtonTable" ;
            LeftButtonTable.RowCount =  1 ;
            LeftButtonTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            LeftButtonTable.Size =  new System.Drawing.Size( 1043, 34 ) ;
            LeftButtonTable.TabIndex =  8 ;
            LeftButtonTable.UseWaitCursor =  true ;
            // 
            // ExcelButton
            // 
            ExcelButton.BindingSource =  null ;
            ExcelButton.DataFilter =  null ;
            ExcelButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            ExcelButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            ExcelButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            ExcelButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ExcelButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            ExcelButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            ExcelButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            ExcelButton.HoverText =  null ;
            ExcelButton.HoverTextColor =  System.Drawing.Color.White ;
            ExcelButton.IsDerivedStyle =  true ;
            ExcelButton.Location =  new System.Drawing.Point( 583, 3 ) ;
            ExcelButton.Name =  "ExcelButton" ;
            ExcelButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            ExcelButton.NormalColor =  System.Drawing.Color.Transparent ;
            ExcelButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            ExcelButton.Padding =  new Padding( 1 ) ;
            ExcelButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ExcelButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ExcelButton.PressTextColor =  System.Drawing.Color.White ;
            ExcelButton.Size =  new System.Drawing.Size( 85, 28 ) ;
            ExcelButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            ExcelButton.StyleManager =  null ;
            ExcelButton.TabIndex =  5 ;
            ExcelButton.Text =  "Excel " ;
            ExcelButton.ThemeAuthor =  "Terry D. Eppler" ;
            ExcelButton.ThemeName =  "Budget Execution" ;
            ExcelButton.ToolTip =  null ;
            ExcelButton.UseWaitCursor =  true ;
            // 
            // ChartButton
            // 
            ChartButton.BindingSource =  null ;
            ChartButton.DataFilter =  null ;
            ChartButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            ChartButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            ChartButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            ChartButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ChartButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            ChartButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            ChartButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            ChartButton.HoverText =  null ;
            ChartButton.HoverTextColor =  System.Drawing.Color.White ;
            ChartButton.IsDerivedStyle =  true ;
            ChartButton.Location =  new System.Drawing.Point( 412, 3 ) ;
            ChartButton.Name =  "ChartButton" ;
            ChartButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            ChartButton.NormalColor =  System.Drawing.Color.Transparent ;
            ChartButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            ChartButton.Padding =  new Padding( 1 ) ;
            ChartButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ChartButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ChartButton.PressTextColor =  System.Drawing.Color.White ;
            ChartButton.Size =  new System.Drawing.Size( 85, 28 ) ;
            ChartButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            ChartButton.StyleManager =  null ;
            ChartButton.TabIndex =  3 ;
            ChartButton.Text =  "Chart" ;
            ChartButton.ThemeAuthor =  "Terry D. Eppler" ;
            ChartButton.ThemeName =  "Budget Execution" ;
            ChartButton.ToolTip =  null ;
            ChartButton.UseWaitCursor =  true ;
            // 
            // DataGridButton
            // 
            DataGridButton.BindingSource =  null ;
            DataGridButton.DataFilter =  null ;
            DataGridButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            DataGridButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            DataGridButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            DataGridButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            DataGridButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            DataGridButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            DataGridButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            DataGridButton.HoverText =  null ;
            DataGridButton.HoverTextColor =  System.Drawing.Color.White ;
            DataGridButton.IsDerivedStyle =  true ;
            DataGridButton.Location =  new System.Drawing.Point( 254, 3 ) ;
            DataGridButton.Name =  "DataGridButton" ;
            DataGridButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            DataGridButton.NormalColor =  System.Drawing.Color.Transparent ;
            DataGridButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            DataGridButton.Padding =  new Padding( 1 ) ;
            DataGridButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            DataGridButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            DataGridButton.PressTextColor =  System.Drawing.Color.White ;
            DataGridButton.Size =  new System.Drawing.Size( 85, 28 ) ;
            DataGridButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            DataGridButton.StyleManager =  null ;
            DataGridButton.TabIndex =  4 ;
            DataGridButton.Text =  "Data " ;
            DataGridButton.ThemeAuthor =  "Terry D. Eppler" ;
            DataGridButton.ThemeName =  "Budget Execution" ;
            DataGridButton.ToolTip =  null ;
            DataGridButton.UseWaitCursor =  true ;
            // 
            // PdfForm
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   15  ,   15  ,   15   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            BorderThickness =  2 ;
            CaptionAlign =  HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 1338, 739 ) ;
            Controls.Add( LeftButtonLayout );
            Controls.Add( RightTable );
            Controls.Add( LeftTable );
            Controls.Add( DocumentPanel );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 1350, 750 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 1350, 750 ) ;
            Name =  "PdfForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            ShowMouseOver =  true ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "PDF Document" ;
            UseWaitCursor =  true ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            LeftTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            DocumentPanel.ResumeLayout( false );
            ListBoxPanel.ResumeLayout( false );
            CloseButtonTable.ResumeLayout( false );
            RightTable.ResumeLayout( false );
            CloseTablePanel.ResumeLayout( false );
            LeftButtonLayout.ResumeLayout( false );
            LeftButtonTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public BindingSource BindingSource;
        public SmallTip ToolTip;
        public Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl DocViewer;
        private TableLayoutPanel LeftTable;
        private Layout DocumentPanel;
        public PictureBox PictureBox;
        public Label HeaderLabel;
        public Button CloseButton;
        private TableLayoutPanel CloseButtonTable;
        public Layout ListBoxPanel;
        public Button MenuButton;
        public Button BackButton;
        private ListView listView1;
        public ListBox ListBox;
        private TableLayoutPanel RightTable;
        public Layout CloseTablePanel;
        public Layout LeftButtonLayout;
        private TableLayoutPanel LeftButtonTable;
        public Button ExcelButton;
        public Button ChartButton;
        public Button DataGridButton;
        private Layout RightTablePanel;
    }
}