// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="DbDataAdapter"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AdapterFactory : AdapterBase
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AdapterFactory"/>
        /// class.
        /// </summary>
        public AdapterFactory( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AdapterFactory"/>
        /// class.
        /// </summary>
        /// <param name="commandFactory"> The commandbuilder. </param>
        public AdapterFactory( ICommandFactory commandFactory )
            : base( commandFactory )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AdapterFactory"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The sqlstatement. </param>
        public AdapterFactory( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary> Gets the adapter. </summary>
        /// <returns> </returns>
        public DbDataAdapter GetAdapter( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider )
               && DataConnection != null
               && !string.IsNullOrEmpty( CommandText ) )
            {
                try
                {
                    switch( Provider )
                    {
                        case Provider.SQLite:
                        {
                            return GetSQLiteAdapter( );
                        }
                        case Provider.SqlCe:
                        {
                            return GetSqlCeAdapter( );
                        }
                        case Provider.SqlServer:
                        {
                            return GetSqlAdapter( );
                        }
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            return GetOleDbAdapter( );
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