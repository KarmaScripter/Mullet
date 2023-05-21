﻿namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    partial class CalendarDialog
    {
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components =  new Container( ) ;
            var resources = new ComponentResourceManager( typeof( CalendarDialog ) );
            Calendar =  new Syncfusion.WinForms.Input.SfCalendar( ) ;
            ToolTip =  new SmallTip( ) ;
            BindingSource =  new BindingSource( components ) ;
            CloseButton =  new Button( ) ;
            Header =  new TableLayoutPanel( ) ;
            PictureBox =  new PictureBox( ) ;
            HeaderLabel =  new Label( ) ;
            SelectButton =  new Button( ) ;
            ( (ISupportInitialize) BindingSource  ).BeginInit( );
            Header.SuspendLayout( );
            ( (ISupportInitialize) PictureBox  ).BeginInit( );
            SuspendLayout( );
            // 
            // Calendar
            // 
            Calendar.CanOverrideStyle =  true ;
            Calendar.FirstDayOfWeek =  System.DayOfWeek.Monday ;
            Calendar.Location =  new System.Drawing.Point( 27, 52 ) ;
            Calendar.MinimumSize =  new System.Drawing.Size( 196, 196 ) ;
            Calendar.Name =  "Calendar" ;
            Calendar.ShowToolTip =  true ;
            Calendar.Size =  new System.Drawing.Size( 385, 255 ) ;
            Calendar.Style.BorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.BlackoutDatesBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.BlackoutDatesFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.BlackoutDatesForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.CellBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.CellFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.CellForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Cell.CellHoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Cell.SelectedCellBackColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Cell.SelectedCellBorderColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Cell.SelectedCellFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.SelectedCellForeColor =  System.Drawing.Color.White ;
            Calendar.Style.Cell.SelectedCellHoverBorderColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Cell.TodayBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.TodayFont =  new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.TodayForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Cell.TodayHoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Cell.TrailingCellBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.TrailingCellFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.TrailingCellForeColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Cell.WeekNumberBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.WeekNumberFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.WeekNumberForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Footer.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Footer.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Footer.HoverBackColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Footer.HoverForeColor =  System.Drawing.Color.White ;
            Calendar.Style.Header.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Header.DayNamesBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Header.DayNamesFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Header.DayNamesForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Header.Font =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Header.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Header.HoverForeColor =  System.Drawing.Color.White ;
            Calendar.Style.Header.NavigationButtonDisabledForeColor =  System.Drawing.Color.DimGray ;
            Calendar.Style.Header.NavigationButtonForeColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Header.NavigationButtonHoverForeColor =  System.Drawing.Color.White ;
            Calendar.Style.HorizontalSplitterColor =  System.Drawing.Color.DimGray ;
            Calendar.Style.VerticalSplitterColor =  System.Drawing.Color.DimGray ;
            Calendar.TabIndex =  0 ;
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
            // CloseButton
            // 
            CloseButton.BindingSource =  null ;
            CloseButton.DataFilter =  null ;
            CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverText =  "Close Calendar" ;
            CloseButton.HoverTextColor =  System.Drawing.Color.White ;
            CloseButton.IsDerivedStyle =  true ;
            CloseButton.Location =  new System.Drawing.Point( 341, 331 ) ;
            CloseButton.Name =  "CloseButton" ;
            CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CloseButton.Padding =  new Padding( 1 ) ;
            CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressTextColor =  System.Drawing.Color.White ;
            CloseButton.Size =  new System.Drawing.Size( 78, 26 ) ;
            CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseButton.StyleManager =  null ;
            CloseButton.TabIndex =  1 ;
            CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
            CloseButton.ThemeName =  "Budget Execution" ;
            CloseButton.ToolTip =  null ;
            // 
            // Header
            // 
            Header.ColumnCount =  2 ;
            Header.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.59085131F ) );
            Header.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 94.40915F ) );
            Header.Controls.Add( PictureBox, 0, 0 );
            Header.Controls.Add( HeaderLabel, 1, 0 );
            Header.Dock =  DockStyle.Top ;
            Header.Location =  new System.Drawing.Point( 0, 0 ) ;
            Header.Name =  "Header" ;
            Header.RowCount =  1 ;
            Header.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            Header.Size =  new System.Drawing.Size( 434, 34 ) ;
            Header.TabIndex =  2 ;
            // 
            // PictureBox
            // 
            PictureBox.Image =  Properties.Resources.Calendar ;
            PictureBox.Location =  new System.Drawing.Point( 3, 3 ) ;
            PictureBox.Name =  "PictureBox" ;
            PictureBox.Size =  new System.Drawing.Size( 18, 23 ) ;
            PictureBox.SizeMode =  PictureBoxSizeMode.Zoom ;
            PictureBox.TabIndex =  0 ;
            PictureBox.TabStop =  false ;
            // 
            // HeaderLabel
            // 
            HeaderLabel.BindingSource =  null ;
            HeaderLabel.DataFilter =  null ;
            HeaderLabel.Dock =  DockStyle.Fill ;
            HeaderLabel.FlatStyle =  FlatStyle.Flat ;
            HeaderLabel.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            HeaderLabel.HoverText =  null ;
            HeaderLabel.IsDerivedStyle =  true ;
            HeaderLabel.Location =  new System.Drawing.Point( 27, 3 ) ;
            HeaderLabel.Margin =  new Padding( 3 ) ;
            HeaderLabel.Name =  "HeaderLabel" ;
            HeaderLabel.Padding =  new Padding( 1 ) ;
            HeaderLabel.Size =  new System.Drawing.Size( 404, 28 ) ;
            HeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            HeaderLabel.StyleManager =  null ;
            HeaderLabel.TabIndex =  1 ;
            HeaderLabel.Text =  "Budget Calendar" ;
            HeaderLabel.TextAlign =  System.Drawing.ContentAlignment.MiddleCenter ;
            HeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            HeaderLabel.ThemeName =  "Budget Execution" ;
            HeaderLabel.ToolTip =  null ;
            // 
            // SelectButton
            // 
            SelectButton.BindingSource =  null ;
            SelectButton.DataFilter =  null ;
            SelectButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            SelectButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            SelectButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            SelectButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SelectButton.ForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SelectButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            SelectButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            SelectButton.HoverText =  null ;
            SelectButton.HoverTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SelectButton.IsDerivedStyle =  true ;
            SelectButton.Location =  new System.Drawing.Point( 161, 394 ) ;
            SelectButton.Name =  "SelectButton" ;
            SelectButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            SelectButton.NormalColor =  System.Drawing.Color.Transparent ;
            SelectButton.NormalTextColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SelectButton.Padding =  new Padding( 1 ) ;
            SelectButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SelectButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SelectButton.PressTextColor =  System.Drawing.Color.White ;
            SelectButton.Size =  new System.Drawing.Size( 90, 30 ) ;
            SelectButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            SelectButton.StyleManager =  null ;
            SelectButton.TabIndex =  4 ;
            SelectButton.Text =  "Select" ;
            SelectButton.ThemeAuthor =  "Terry D. Eppler" ;
            SelectButton.ThemeName =  "Budget Execution" ;
            SelectButton.ToolTip =  null ;
            // 
            // CalendarDialog
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            BorderThickness =  2 ;
            CaptionAlign =  HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.Red ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 434, 362 ) ;
            Controls.Add( Calendar );
            Controls.Add( SelectButton );
            Controls.Add( Header );
            Controls.Add( CloseButton );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 446, 373 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 446, 373 ) ;
            Name =  "CalendarDialog" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            ShowMouseOver =  true ;
            SizeGripStyle =  SizeGripStyle.Hide ;
            StartPosition =  FormStartPosition.CenterScreen ;
            ( (ISupportInitialize) BindingSource  ).EndInit( );
            Header.ResumeLayout( false );
            ( (ISupportInitialize) PictureBox  ).EndInit( );
            ResumeLayout( false );
        }

        public Syncfusion.WinForms.Input.SfCalendar Calendar;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public Button CloseButton;
        public PictureBox PictureBox;
        public TableLayoutPanel Header;
        public Label HeaderLabel;
        public Button SelectButton;
    }
}