// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public class EmailContent
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is HTML.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is HTML; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool IsHtml { get; set; }

        /// <summary> Gets or sets the content. </summary>
        /// <value> The content. </value>
        public string Content { get; set; }

        /// <summary> Gets or sets the name of the attach file. </summary>
        /// <value> The name of the attach file. </value>
        public string AttachFileName { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="EmailContent"/>
        /// class.
        /// </summary>
        public EmailContent( )
        {
        }
    }
}