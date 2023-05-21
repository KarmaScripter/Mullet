// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.IO;
    using System.Security.AccessControl;

    /// <summary> </summary>
    public interface IDataFile : IDataPath
    {
        /// <summary> Transfers the specified folder. </summary>
        /// <param name = "folder" > The folder. </param>
        void Transfer( DirectoryInfo folder );

        /// <summary> Determines whether this instance contains the object. </summary>
        /// <param name = "search" > The search. </param>
        /// <returns>
        /// <c> true </c>
        /// if [contains] [the specified search]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool Contains( string search );

        /// <summary> Searches the specified pattern. </summary>
        /// <param name = "pattern" > The pattern. </param>
        /// <returns> </returns>
        IEnumerable<FileInfo> Search( string pattern );

        /// <summary> Gets the parent. </summary>
        /// <returns> </returns>
        string GetParentDirectory( );

        /// <summary> Moves the specified destination. </summary>
        /// <param name = "filePath" > The destination. </param>
        void Move( string filePath );

        /// <summary> Copies the specified filePath. </summary>
        /// <param name = "filePath" > The filePath. </param>
        void Copy( string filePath );

        /// <summary> Deletes this instance. </summary>
        void Delete( );

        /// <summary> Gets the file security. </summary>
        /// <returns> </returns>
        FileSecurity GetFileSecurity( );

        /// <summary> Gets the base stream. </summary>
        /// <returns> </returns>
        FileStream GetBaseStream( );

        /// <summary> Converts to string. </summary>
        /// <returns>
        /// A
        /// <see cref = "System.String"/>
        /// that represents this instance.
        /// </returns>
        string ToString( );
    }
}