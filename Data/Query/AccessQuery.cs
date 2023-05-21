// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.Query"/>
    public class AccessQuery : Query
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        public AccessQuery( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        public AccessQuery( Source source )
            : base( source, Provider.Access, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        public AccessQuery( Source source, IDictionary<string, object> dict )
            : base( source, Provider.Access, dict, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AccessQuery( Source source, IDictionary<string, object> dict, SQL commandType )
            : base( source, Provider.Access, dict, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="updates"> The updates. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AccessQuery( Source source, IDictionary<string, object> updates, IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, Provider.Access, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="criteria"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AccessQuery( Source source, IEnumerable<string> columns, IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, Provider.Access, columns, criteria, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The sqlStatement. </param>
        public AccessQuery( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public AccessQuery( Source source, string sqlText )
            : base( source, Provider.Access, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="sqlText"> </param>
        /// <param name="commandType"> The commandType. </param>
        public AccessQuery( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="commandType"> The commandType. </param>
        /// <param name="dict"> </param>
        public AccessQuery( string fullPath, SQL commandType, IDictionary<string, object> dict )
            : base( fullPath, commandType, dict )
        {
        }

        /// <summary> Releases unmanaged and - optionally - managed resources. </summary>
        /// <param name="disposing">
        /// <c> true </c>
        /// to release both managed and unmanaged resources;
        /// <c> false </c>
        /// to release only unmanaged resources.
        /// </param>
        override protected void Dispose( bool disposing )
        {
            if( disposing )
            {
                base.Dispose( disposing );
            }

            IsDisposed = true;
        }
    }
}