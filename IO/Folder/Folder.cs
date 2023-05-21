// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.IO.Compression;
    using System.Security.AccessControl;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="FolderBase"/>
    /// <seealso cref="IFolder"/>
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class Folder : FolderBase, IFolder
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Folder"/>
        /// class.
        /// </summary>
        public Folder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Folder"/>
        /// class.
        /// </summary>
        /// <param name="dirPath"> The file. </param>
        public Folder( string dirPath )
            : base( dirPath )
        {
        }

        /// <summary> Gets the current directory. </summary>
        /// <returns> </returns>
        public static string GetCurrentDirectory( )
        {
            try
            {
                return !string.IsNullOrEmpty( Environment.CurrentDirectory )
                    ? Environment.CurrentDirectory
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Creates the specified filepath. </summary>
        /// <param name="fullPath"> The filepath. </param>
        /// <returns> </returns>
        public static DirectoryInfo Create( string fullPath )
        {
            try
            {
                return !string.IsNullOrEmpty( fullPath ) && !Directory.Exists( fullPath )
                    ? Directory.CreateDirectory( fullPath )
                    : default( DirectoryInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DirectoryInfo );
            }
        }

        /// <summary> Deletes the specified folderName. </summary>
        /// <param name="folderName"> The folderName. </param>
        public static void Delete( string folderName )
        {
            try
            {
                if( !string.IsNullOrEmpty( folderName )
                   && Directory.Exists( folderName ) )
                {
                    Directory.Delete( folderName, true );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Creats the zip file. </summary>
        /// <param name="source"> The sourcePath. </param>
        /// <param name="destination"> The destination. </param>
        public static void CreateZipFile( string source, string destination )
        {
            try
            {
                if( !string.IsNullOrEmpty( source ) )
                {
                    ZipFile.CreateFromDirectory( source, destination );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Creates the sub folder. </summary>
        /// <param name="dirName"> The folderName. </param>
        /// <returns> </returns>
        public DirectoryInfo CreateSubDirectory( string dirName )
        {
            if( !string.IsNullOrEmpty( dirName )
               && !Directory.Exists( dirName ) )
            {
                try
                {
                    return new DirectoryInfo( FullPath )?.CreateSubdirectory( dirName );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DirectoryInfo );
                }
            }

            return default( DirectoryInfo );
        }

        /// <summary> Moves the specified folderpath. </summary>
        /// <param name="destination"> The folderpath. </param>
        public void Move( string destination )
        {
            if( !string.IsNullOrEmpty( destination ) )
            {
                try
                {
                    var _directory = new DirectoryInfo( FullPath );
                    _directory.MoveTo( destination );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Zips the specified filepath. </summary>
        /// <param name="destination"> The filepath. </param>
        public void Zip( string destination )
        {
            try
            {
                if( !string.IsNullOrEmpty( destination )
                   && !string.IsNullOrEmpty( FullPath ) )
                {
                    ZipFile.CreateFromDirectory( FullPath, destination );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Uns the zip. </summary>
        /// <param name="zipPath"> The zipPath. </param>
        public void UnZip( string zipPath )
        {
            try
            {
                if( !string.IsNullOrEmpty( zipPath )
                   && File.Exists( zipPath ) )
                {
                    ZipFile.ExtractToDirectory( zipPath, FullPath );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the access control. </summary>
        /// <param name="security"> The security. </param>
        public void SetAccessControl( DirectorySecurity security )
        {
            if( security != null )
            {
                try
                {
                    var _directory = new DirectoryInfo( FullPath );
                    _directory?.SetAccessControl( security );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}