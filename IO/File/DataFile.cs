﻿// <copyright file = "DataFile.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;
    using static System.IO.Directory;

    /// <summary> </summary>
    /// <seealso cref="PathBase"/>
    public class DataFile : FileBase, IDataFile
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataFile"/>
        /// class.
        /// </summary>
        public DataFile( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataFile"/>
        /// class.
        /// </summary>
        /// <param name="input"> The input. </param>
        public DataFile( string input )
            : base( input )
        {
        }

        /// <summary> Transfers the specified folder. </summary>
        /// <param name="folder"> The folder. </param>
        public void Transfer( DirectoryInfo folder )
        {
            if( folder != null
               && !Exists( folder.FullName ) )
            {
                CreateDirectory( folder.FullName );
            }

            try
            {
                var _files = folder?.GetFiles( );
                if( _files?.Any( ) == true )
                {
                    foreach( var _fileInfo in _files )
                    {
                        Directory.Move( _fileInfo.FullName, folder.Name );
                    }
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Determines whether this instance contains the object. </summary>
        /// <param name="search"> The search. </param>
        /// <returns>
        /// <c> true </c>
        /// if [contains] [the specified search]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        public bool Contains( string search )
        {
            try
            {
                if( !string.IsNullOrEmpty( search )
                   && File.Exists( search ) )
                {
                    var  _stream = File.Open( search, FileMode.Open );
                    var  _reader = new StreamReader( _stream );
                    if( _reader != null )
                    {
                        var _text = _reader?.ReadLine( );
                        var _result = false;
                        while( _text == string.Empty )
                        {
                            if( Regex.IsMatch( _text, search ) )
                            {
                                _result = true;
                                break;
                            }

                            _text = _reader.ReadLine( );
                        }

                        return _result;
                    }
                }

                return false;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary> Searches the specified pattern. </summary>
        /// <param name="pattern"> The pattern. </param>
        /// <returns> </returns>
        public IEnumerable<FileInfo> Search( string pattern )
        {
            if( !string.IsNullOrEmpty( pattern ) )
            {
                try
                {
                    var _input = Path.GetFullPath( Buffer );
                    if( !string.IsNullOrEmpty( _input )
                       && File.Exists( _input ) )
                    {
                        IEnumerable<string> _enumerable = GetDirectories( _input, pattern );
                        var _list = new List<FileInfo>( );
                        foreach( var file in _enumerable )
                        {
                            _list.Add( new FileInfo( file ) );
                        }

                        return _list?.Any( ) == true
                            ? _list
                            : default;
                    }
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary> Gets the parent. </summary>
        /// <returns> </returns>
        public string GetParentDirectory( )
        {
            if( !string.IsNullOrEmpty( Buffer ) )
            {
                try
                {
                    return HasParent
                        ? GetParent( Buffer )?.FullName
                        : string.Empty;
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary> Returns a string that represents the current object. </summary>
        /// <returns> A string that represents the current object. </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( Name )
                    ? Name
                    : string.Empty;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary> Creates the specified file path. </summary>
        /// <param name="filePath"> The file path. </param>
        /// <returns> </returns>
        public static FileInfo Create( string filePath )
        {
            try
            {
                return !string.IsNullOrEmpty( filePath )
                    ? new FileInfo( filePath )
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Browses this instance. </summary>
        /// <returns> </returns>
        public static string Browse( )
        {
            try
            {
                var _dialog = new OpenFileDialog( );
                _dialog.CheckFileExists = true;
                _dialog.CheckPathExists = true;
                _dialog.ShowDialog( );
                return _dialog.FileName;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary> Saves this instance. </summary>
        /// <returns> </returns>
        public static string Save( )
        {
            try
            {
                var _dialog = new SaveFileDialog( );
                _dialog.CreatePrompt = true;
                _dialog.OverwritePrompt = true;
                _dialog.CheckFileExists = true;
                _dialog.CheckPathExists = true;
                _dialog.ShowDialog( );
                return _dialog.FileName;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }
    }
}