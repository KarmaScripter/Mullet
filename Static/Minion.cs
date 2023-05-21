// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using static System.Configuration.ConfigurationManager;

    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public static class Minion
    {
        /// <summary> Opens the sq lite. </summary>
        public static void OpenSQLite( )
        {
            try
            {
                var _app = AppSettings[ "SQLiteMinion" ];
                var _args = AppSettings[ "SQLiteArgs" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                if( !string.IsNullOrEmpty( _args ) )
                {
                    _startInfo.Arguments = _args;
                }

                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Opens the SQL ce. </summary>
        public static void OpenSqlCe( )
        {
            try
            {
                var _app = AppSettings[ "SqlCeMinion" ];
                var _args = AppSettings[ "SqlCeArgs" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                if( !string.IsNullOrEmpty( _args ) )
                {
                    _startInfo.Arguments = _args;
                }

                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Opens the access database. </summary>
        public static void OpenAccess( )
        {
            try
            {
                var _app = AppSettings[ "AccessMinion" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Opens the excel. </summary>
        public static void OpenExcel( )
        {
            try
            {
                var _app = AppSettings[ "Reports" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> </summary>
        public static void OpenPdfDocument( )
        {
            try
            {
                var _app = AppSettings[ "Reports" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> </summary>
        public static void LaunchEdge( )
        {
            try
            {
                var _path = "";
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> </summary>
        public static void LaunchChrome( )
        {
            try
            {
                var _path = "";
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The exception. </param>
        static private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}