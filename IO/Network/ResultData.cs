// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public class ResultData
    {
        /// <summary> Gets or sets the link. </summary>
        /// <value> The link. </value>
        public string Link { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public string Name { get; set; }

        /// <summary> Gets or sets the content. </summary>
        /// <value> The content. </value>
        public string Content { get; set; }

        /// <summary> Gets or sets the title. </summary>
        /// <value> The title. </value>
        public string Title { get; set; }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResultData"/>
        /// class.
        /// </summary>
        public ResultData( )
        {
        }
    }
}