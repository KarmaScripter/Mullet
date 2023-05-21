// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="IDisposable"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public class Query : QueryBase, IQuery
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        public Query( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> The commandType. </param>
        public Query( Source source, Provider provider = Provider.Access, SQL commandType = SQL.SELECTALL )
            : base( source, provider, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source Data. </param>
        /// <param name="provider"> The provider used. </param>
        /// <param name="where"> The dictionary of parameters. </param>
        /// <param name="commandType"> The type of sql command. </param>
        public Query( Source source, Provider provider, IDictionary<string, object> where, SQL commandType )
            : base( source, provider, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public Query( Source source, Provider provider, IDictionary<string, object> updates, IDictionary<string, object> where,
            SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public Query( Source source, Provider provider, IEnumerable<string> columns, IDictionary<string, object> where,
            SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="having"> The having. </param>
        /// <param name="commandType"> Type of the command. </param>
        public Query( Source source, Provider provider, IEnumerable<string> columns, IEnumerable<string> numerics,
            IDictionary<string, object> having, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, having, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The sqlStatement. </param>
        public Query( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public Query( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The dictionary. </param>
        public Query( Source source, Provider provider, IDictionary<string, object> where )
            : base( source, provider, where )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="sqlText"> </param>
        /// <param name="commandType"> The commandType. </param>
        public Query( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Query"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="commandType"> The commandType. </param>
        /// <param name="where"> The dictionary. </param>
        public Query( string fullPath, SQL commandType, IDictionary<string, object> where )
            : base( fullPath, commandType, where )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged
        /// resources.
        /// </summary>
        public virtual void Dispose( )
        {
            try
            {
                Dispose( true );
                GC.SuppressFinalize( this );
            }
            catch( Exception ex )
            {
                IsDisposed = false;
                Fail( ex );
            }
        }

        /// <summary> Releases unmanaged and - optionally - managed resources. </summary>
        /// <param name="disposing">
        /// <c> true </c>
        /// to release both managed and unmanaged resources;
        /// <c> false </c>
        /// to release only unmanaged resources.
        /// </param>
        virtual protected void Dispose( bool disposing )
        {
            if( ConnectionFactory?.Connection != null )
            {
                try
                {
                    ConnectionFactory?.Connection?.Close( );
                    ConnectionFactory?.Connection?.Dispose( );
                    IsDisposed = true;
                }
                catch( Exception ex )
                {
                    IsDisposed = false;
                    Fail( ex );
                }
            }
        }
    }
}