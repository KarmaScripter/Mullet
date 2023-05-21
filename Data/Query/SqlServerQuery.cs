﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="Query"/>
    public class SqlServerQuery : Query
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        public SqlServerQuery( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        public SqlServerQuery( Source source )
            : base( source, Provider.SqlServer )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        public SqlServerQuery( Source source, IDictionary<string, object> dict )
            : base( source, Provider.SqlServer, dict, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source Data. </param>
        /// <param name="provider"> The provider used. </param>
        /// <param name="dict"> The dictionary of parameters. </param>
        /// <param name="commandType"> The type of sql command. </param>
        public SqlServerQuery( Source source, IDictionary<string, object> dict, SQL commandType )
            : base( source, Provider.SqlServer, dict, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlServerQuery( Source source, IDictionary<string, object> updates, IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, Provider.SqlServer, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="criteria"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlServerQuery( Source source, IEnumerable<string> columns, IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, Provider.SqlServer, columns, criteria, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The sqlStatement. </param>
        public SqlServerQuery( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public SqlServerQuery( Source source, string sqlText )
            : base( source, Provider.SqlServer, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="sqlText"> </param>
        /// <param name="commandType"> The commandType. </param>
        public SqlServerQuery( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="commandType"> The commandType. </param>
        /// <param name="dict"> The dictionary. </param>
        public SqlServerQuery( string fullPath, SQL commandType, IDictionary<string, object> dict )
            : base( fullPath, commandType, dict )
        {
        }

        /// <summary> The Dispose </summary>
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