﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.Threading;

    /// <summary> </summary>
    public class AccessConversion : IDisposable
    {
        /// <summary> The connection </summary>
        private SQLiteConnection _connection;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessConversion"/>
        /// class.
        /// </summary>
        public AccessConversion( )
        {
            SQLiteConnection.CreateFile( "MyDatabase.sqlite" );
            _connection = new SQLiteConnection( "Data Source=MyDatabase.sqlite;Version=3;" );
            _connection.Open( );
        }

        /// <summary> Creates the table. </summary>
        /// <param name="name"> The name. </param>
        /// <returns> </returns>
        public int CreateTable( string name )
        {
            var _sql = "CREATE TABLE " + name + " (word varchar(200), image text)";
            var  _cmd = new SQLiteCommand( _sql, _connection );
            return _cmd.ExecuteNonQuery( );
        }

        /// <summary> Inserts the row. </summary>
        /// <param name="word"> The word. </param>
        /// <param name="image"> The image. </param>
        /// <param name="table"> The table. </param>
        /// <returns> </returns>
        public int InsertRow( string word, string image, string table )
        {
            var _sql = "INSERT INTO " + table + " (word,image) VALUES ( @word, @image )";
            var  _cmd = new SQLiteCommand( _sql, _connection );
            _cmd.Parameters.AddWithValue( "@word", word );
            _cmd.Parameters.AddWithValue( "@image", image );
            return _cmd.ExecuteNonQuery( );
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged
        /// resources.
        /// </summary>
        public void Dispose( )
        {
            if( _connection.State == ConnectionState.Open )
            {
                _connection = null;
            }

            GC.SuppressFinalize( this );
        }
    }
}