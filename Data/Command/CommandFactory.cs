// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="ICommand"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CommandFactory : CommandBase, ICommandFactory
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        public CommandFactory( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        public CommandFactory( Source source, Provider provider, string sqlText, SQL commandType )
            : base( source, provider, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The dictionary. </param>
        /// <param name="commandType"> </param>
        public CommandFactory( Source source, Provider provider, IDictionary<string, object> where, SQL commandType = SQL.SELECTALL )
            : base( source, provider, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> The updates. </param>
        /// <param name="where"> The criteria. </param>
        /// <param name="commandType"> </param>
        public CommandFactory( Source source, Provider provider, IDictionary<string, object> updates, IDictionary<string, object> where,
            SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <summary> </summary>
        /// <param name="source"> </param>
        /// <param name="provider"> </param>
        /// <param name="columns"> </param>
        /// <param name="where"> </param>
        /// <param name="commandType"> </param>
        public CommandFactory( Source source, Provider provider, IEnumerable<string> columns, IDictionary<string, object> where,
            SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="having"> The having. </param>
        /// <param name="commandType"> Type of the command. </param>
        public CommandFactory( Source source, Provider provider, IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> having, SQL commandType = SQL.SELECT )
            : base( source, provider, fields, numerics, having,
                commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        public CommandFactory( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary> Sets the command. </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        /// <returns> </returns>
        public DbCommand GetCommand( )
        {
            if( SqlStatement != null )
            {
                try
                {
                    switch( SqlStatement.Provider )
                    {
                        case Provider.SQLite:
                        {
                            return GetSQLiteCommand( );
                        }
                        case Provider.SqlCe:
                        {
                            return GetSqlCeCommand( );
                        }
                        case Provider.SqlServer:
                        {
                            return GetSqlCommand( );
                        }
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            return GetOleDbCommand( );
                        }
                        default:
                        {
                            return default;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }
    }
}