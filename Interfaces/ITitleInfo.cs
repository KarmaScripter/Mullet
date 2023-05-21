// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary> </summary>
    public interface ITitleInfo
    {
        /// <summary> Gets the main title. </summary>
        /// <returns> </returns>
        ChartTitle CreateMainTitle( );

        /// <summary> Gets the axis title. </summary>
        /// <returns> </returns>
        ChartTitle CreateAxisTitle( );

        /// <summary> Gets the main title. </summary>
        /// <param name = "color" > The color. </param>
        /// <param name = "font" > The font. </param>
        /// <returns> </returns>
        ChartTitle CreateMainTitle( Color color, Font font );

        /// <summary> Gets the axis title. </summary>
        /// <param name = "color" > The color. </param>
        /// <param name = "font" > The font. </param>
        /// <returns> </returns>
        ChartTitle CreateAxisTitle( Color color, Font font );
    }
}