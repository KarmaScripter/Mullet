﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    /// <summary> </summary>
    public interface IToolStripButton
    {
        /// <summary> Called when [mouse over]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnMouseHover( object sender, EventArgs e );

        /// <summary> Called when [mouse leave]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnMouseLeave( object sender, EventArgs e );

        /// <summary> Called when [click]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnClick( object sender, EventArgs e );

        /// <summary> Sets the hover text. </summary>
        /// <param name = "text" > The text. </param>
        void SetHoverText( string text );

        /// <summary> Sets the image. </summary>
        Image GetImage( ToolType toolType );
    }
}