// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="ConnectionBase"/>
    /// <seealso cref="ISource"/>
    /// <seealso cref="IProvider"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ConnectionFactory : ConnectionBase, ISource, IProvider, IConnectionFactory
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionFactory"/>
        /// class.
        /// </summary>
        public ConnectionFactory( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        public ConnectionFactory( Source source, Provider provider = Provider.Access )
            : base( source, provider )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionFactory"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullPath. </param>
        public ConnectionFactory( string fullPath )
            : base( fullPath )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionFactory"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullPath. </param>
        /// <param name="provider"> The provider. </param>
        public ConnectionFactory( string fullPath, Provider provider = Provider.Access )
            : base( fullPath, provider )
        {
        }

        /// <summary> Gets the connection. </summary>
        /// <returns> </returns>
        public DbConnection GetConnection( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider ) )
            {
                try
                {
                    var _connectionString = ConnectionPath[ $"{Provider}" ]?.ConnectionString;
                    if( !string.IsNullOrEmpty( _connectionString ) )
                    {
                        switch( Provider )
                        {
                            case Provider.SQLite:
                            {
                                return new SQLiteConnection( _connectionString );
                            }
                            case Provider.SqlCe:
                            {
                                return new SqlCeConnection( _connectionString );
                            }
                            case Provider.SqlServer:
                            {
                                return new SqlConnection( _connectionString );
                            }
                            case Provider.Excel:
                            case Provider.CSV:
                            case Provider.Access:
                            case Provider.OleDb:
                            {
                                return new OleDbConnection( _connectionString );
                            }
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