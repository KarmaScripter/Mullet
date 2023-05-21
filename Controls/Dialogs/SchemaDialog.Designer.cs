// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class SchemaDialog
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
        var dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle( );
        var dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle( );
        var dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle( );
        var dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle( );
        var dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle( );
        var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea( );
        var legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend( );
        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series( );
        var title1 = new System.Windows.Forms.DataVisualization.Charting.Title( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( SchemaDialog ) );
        BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
        ToolTip =  new SmallTip( ) ;
        tableLayoutPanel1 =  new System.Windows.Forms.TableLayoutPanel( ) ;
        DataGrid =  new DataGrid( ) ;
        DataChart =  new System.Windows.Forms.DataVisualization.Charting.Chart( ) ;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        tableLayoutPanel1.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) DataGrid  ).BeginInit( );
        ( (System.ComponentModel.ISupportInitialize) DataChart  ).BeginInit( );
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
        ToolTip.TipIcon =  System.Windows.Forms.ToolTipIcon.Info ;
        ToolTip.TipText =  null ;
        ToolTip.TipTitle =  null ;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount =  3 ;
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 97.16714F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 2.83286119F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 597F ) );
        tableLayoutPanel1.Controls.Add( DataGrid, 0, 1 );
        tableLayoutPanel1.Controls.Add( DataChart, 2, 1 );
        tableLayoutPanel1.Location =  new System.Drawing.Point( 12, 29 ) ;
        tableLayoutPanel1.Name =  "tableLayoutPanel1" ;
        tableLayoutPanel1.RowCount =  3 ;
        tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 4.24028254F ) );
        tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 95.75972F ) );
        tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
        tableLayoutPanel1.Size =  new System.Drawing.Size( 1304, 612 ) ;
        tableLayoutPanel1.TabIndex =  0 ;
        // 
        // DataGrid
        // 
        DataGrid.AllowUserToOrderColumns =  true ;
        dataGridViewCellStyle1.BackColor =  System.Drawing.Color.FromArgb(   50  ,   50  ,   50   ) ;
        dataGridViewCellStyle1.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        dataGridViewCellStyle1.ForeColor =  System.Drawing.Color.LightGray ;
        dataGridViewCellStyle1.SelectionBackColor =  System.Drawing.Color.FromArgb(   26  ,   79  ,   125   ) ;
        dataGridViewCellStyle1.SelectionForeColor =  System.Drawing.Color.White ;
        DataGrid.AlternatingRowsDefaultCellStyle =  dataGridViewCellStyle1 ;
        DataGrid.BackgroundColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
        DataGrid.BindingSource =  null ;
        DataGrid.BorderStyle =  System.Windows.Forms.BorderStyle.None ;
        DataGrid.CellBorderStyle =  System.Windows.Forms.DataGridViewCellBorderStyle.None ;
        DataGrid.ColumnHeadersBorderStyle =  System.Windows.Forms.DataGridViewHeaderBorderStyle.Single ;
        dataGridViewCellStyle2.Alignment =  System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter ;
        dataGridViewCellStyle2.BackColor =  System.Drawing.Color.SteelBlue ;
        dataGridViewCellStyle2.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        dataGridViewCellStyle2.ForeColor =  System.Drawing.Color.White ;
        dataGridViewCellStyle2.SelectionBackColor =  System.Drawing.Color.FromArgb(   26  ,   79  ,   125   ) ;
        dataGridViewCellStyle2.SelectionForeColor =  System.Drawing.Color.White ;
        dataGridViewCellStyle2.WrapMode =  System.Windows.Forms.DataGridViewTriState.True ;
        DataGrid.ColumnHeadersDefaultCellStyle =  dataGridViewCellStyle2 ;
        DataGrid.ColumnHeadersHeightSizeMode =  System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
        DataGrid.DataFilter =  null ;
        dataGridViewCellStyle3.Alignment =  System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft ;
        dataGridViewCellStyle3.BackColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
        dataGridViewCellStyle3.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        dataGridViewCellStyle3.ForeColor =  System.Drawing.Color.LightGray ;
        dataGridViewCellStyle3.SelectionBackColor =  System.Drawing.Color.FromArgb(   26  ,   79  ,   125   ) ;
        dataGridViewCellStyle3.SelectionForeColor =  System.Drawing.Color.White ;
        dataGridViewCellStyle3.WrapMode =  System.Windows.Forms.DataGridViewTriState.False ;
        DataGrid.DefaultCellStyle =  dataGridViewCellStyle3 ;
        DataGrid.Dock =  System.Windows.Forms.DockStyle.Fill ;
        DataGrid.EnableHeadersVisualStyles =  false ;
        DataGrid.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        DataGrid.GridColor =  System.Drawing.Color.FromArgb(   141  ,   139  ,   138   ) ;
        DataGrid.HoverText =  null ;
        DataGrid.Location =  new System.Drawing.Point( 3, 28 ) ;
        DataGrid.MultiSelect =  false ;
        DataGrid.Name =  "DataGrid" ;
        DataGrid.RowHeadersBorderStyle =  System.Windows.Forms.DataGridViewHeaderBorderStyle.Single ;
        dataGridViewCellStyle4.Alignment =  System.Windows.Forms.DataGridViewContentAlignment.BottomCenter ;
        dataGridViewCellStyle4.BackColor =  System.Drawing.Color.FromArgb(   50  ,   50  ,   50   ) ;
        dataGridViewCellStyle4.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        dataGridViewCellStyle4.ForeColor =  System.Drawing.Color.Black ;
        dataGridViewCellStyle4.SelectionBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
        dataGridViewCellStyle4.SelectionForeColor =  System.Drawing.SystemColors.HighlightText ;
        dataGridViewCellStyle4.WrapMode =  System.Windows.Forms.DataGridViewTriState.True ;
        DataGrid.RowHeadersDefaultCellStyle =  dataGridViewCellStyle4 ;
        DataGrid.RowHeadersWidth =  20 ;
        dataGridViewCellStyle5.Alignment =  System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter ;
        dataGridViewCellStyle5.BackColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
        dataGridViewCellStyle5.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        dataGridViewCellStyle5.ForeColor =  System.Drawing.Color.LightGray ;
        dataGridViewCellStyle5.SelectionBackColor =  System.Drawing.Color.FromArgb(   26  ,   79  ,   125   ) ;
        dataGridViewCellStyle5.SelectionForeColor =  System.Drawing.Color.White ;
        DataGrid.RowsDefaultCellStyle =  dataGridViewCellStyle5 ;
        DataGrid.SelectionMode =  System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect ;
        DataGrid.Size =  new System.Drawing.Size( 680, 560 ) ;
        DataGrid.TabIndex =  0 ;
        DataGrid.ToolTip =  null ;
        // 
        // DataChart
        // 
        DataChart.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        DataChart.BorderlineColor =  System.Drawing.Color.Transparent ;
        DataChart.BorderSkin.BorderColor =  System.Drawing.Color.Transparent ;
        DataChart.BorderSkin.PageColor =  System.Drawing.Color.Transparent ;
        chartArea1.Area3DStyle.Enable3D =  true ;
        chartArea1.AxisX.InterlacedColor =  System.Drawing.Color.Transparent ;
        chartArea1.AxisX.IsLabelAutoFit =  false ;
        chartArea1.AxisX.LabelStyle.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        chartArea1.AxisX.LabelStyle.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        chartArea1.AxisX.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisX.MajorGrid.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisX.MajorTickMark.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisX.MinorGrid.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisX.MinorTickMark.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisX.Title =  "Category Axis " ;
        chartArea1.AxisX.TitleFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        chartArea1.AxisX.TitleForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        chartArea1.AxisY.InterlacedColor =  System.Drawing.Color.Transparent ;
        chartArea1.AxisY.IsLabelAutoFit =  false ;
        chartArea1.AxisY.LabelStyle.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        chartArea1.AxisY.LabelStyle.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        chartArea1.AxisY.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisY.MajorGrid.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisY.MajorTickMark.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisY.MinorGrid.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisY.MinorTickMark.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisY.ScaleBreakStyle.LineColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
        chartArea1.AxisY.Title =  "Value Axis" ;
        chartArea1.AxisY.TitleFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        chartArea1.AxisY.TitleForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        chartArea1.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        chartArea1.BackSecondaryColor =  System.Drawing.Color.Transparent ;
        chartArea1.BorderColor =  System.Drawing.Color.Transparent ;
        chartArea1.Name =  "Area" ;
        DataChart.ChartAreas.Add( chartArea1 );
        DataChart.Dock =  System.Windows.Forms.DockStyle.Fill ;
        legend1.BackColor =  System.Drawing.Color.Transparent ;
        legend1.BorderColor =  System.Drawing.Color.Transparent ;
        legend1.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        legend1.ForeColor =  System.Drawing.Color.LightSteelBlue ;
        legend1.HeaderSeparatorColor =  System.Drawing.Color.Transparent ;
        legend1.InterlacedRowsColor =  System.Drawing.Color.Transparent ;
        legend1.IsTextAutoFit =  false ;
        legend1.ItemColumnSeparatorColor =  System.Drawing.Color.Transparent ;
        legend1.LegendStyle =  System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column ;
        legend1.Name =  "Legend1" ;
        legend1.TitleBackColor =  System.Drawing.Color.Transparent ;
        legend1.TitleFont =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        legend1.TitleForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        legend1.TitleSeparatorColor =  System.Drawing.Color.Transparent ;
        DataChart.Legends.Add( legend1 );
        DataChart.Location =  new System.Drawing.Point( 709, 28 ) ;
        DataChart.Name =  "DataChart" ;
        DataChart.Palette =  System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None ;
        DataChart.PaletteCustomColors = ( new System.Drawing.Color[ ] { System.Drawing.Color.SteelBlue, System.Drawing.Color.Maroon, System.Drawing.Color.Green } );
        series1.ChartArea =  "Area" ;
        series1.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        series1.LabelBackColor =  System.Drawing.Color.Transparent ;
        series1.LabelBorderColor =  System.Drawing.Color.Transparent ;
        series1.LabelForeColor =  System.Drawing.Color.LightSteelBlue ;
        series1.Legend =  "Legend1" ;
        series1.Name =  "Series1" ;
        series1.SmartLabelStyle.CalloutLineColor =  System.Drawing.Color.LightSteelBlue ;
        DataChart.Series.Add( series1 );
        DataChart.Size =  new System.Drawing.Size( 592, 560 ) ;
        DataChart.TabIndex =  1 ;
        DataChart.Text =  "chart1" ;
        title1.BackColor =  System.Drawing.Color.Transparent ;
        title1.BackSecondaryColor =  System.Drawing.Color.Transparent ;
        title1.BorderColor =  System.Drawing.Color.Transparent ;
        title1.Font =  new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        title1.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        title1.Name =  "Title1" ;
        title1.Text =  "Title" ;
        DataChart.Titles.Add( title1 );
        // 
        // SchemaDialog
        // 
        AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
        AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
        BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        BorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionAlign =  System.Windows.Forms.HorizontalAlignment.Left ;
        CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionBarHeight =  1 ;
        CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ClientSize =  new System.Drawing.Size( 1328, 669 ) ;
        Controls.Add( tableLayoutPanel1 );
        Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ForeColor =  System.Drawing.Color.Gray ;
        FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
        Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
        Margin =  new System.Windows.Forms.Padding( 4, 3, 4, 3 ) ;
        MaximumSize =  new System.Drawing.Size( 1340, 676 ) ;
        MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        MinimumSize =  new System.Drawing.Size( 1340, 676 ) ;
        Name =  "SchemaDialog" ;
        ShowIcon =  false ;
        SizeGripStyle =  System.Windows.Forms.SizeGripStyle.Hide ;
        Text =  "Data Columns" ;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        tableLayoutPanel1.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) DataGrid  ).EndInit( );
        ( (System.ComponentModel.ISupportInitialize) DataChart  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private DataGrid DataGrid;
    public System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
}