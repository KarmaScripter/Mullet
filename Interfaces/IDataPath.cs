// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.IO;
    using System.Security.AccessControl;

    /// <summary> </summary>
    public interface IDataPath
    {
        /// <summary> The path </summary>
        string Buffer { get; set; }

        /// <summary> Gets or sets the name of the file. </summary>
        /// <value> The name of the file. </value>
        string Name { get; set; }

        /// <summary> Gets or sets the full name. </summary>
        /// <value> The full name. </value>
        string FullPath { get; set; }

        /// <summary> Gets or sets the full path. </summary>
        /// <value> The full path. </value>
        string AbsolutePath { get; set; }

        /// <summary> Gets or sets the changed date. </summary>
        /// <value> The changed date. </value>
        DateTime Modified { get; set; }

        /// <summary> Gets or sets the extension. </summary>
        /// <value> The extension. </value>
        string Extension { get; set; }

        /// <summary> Gets or sets a value indicating whether this instance has parent. </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance has parent { get; set; } otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        bool HasParent { get; set; }

        /// <summary> Gets or sets the creation date. </summary>
        /// <value> The creation date.p/// </value>
        DateTime Created { get; set; }

        /// <summary> Gets or sets the lengeth. </summary>
        /// <value> The lengeth. </value>
        long Length { get; set; }

        /// <summary> Gets or sets the attributes. </summary>
        /// <value> The attributes. </value>
        FileAttributes Attributes { get; set; }

        /// <summary> Gets or sets the security. </summary>
        /// <value> The security. </value>
        FileSecurity FileSecurity { get; set; }

        /// <summary> Gets the dir sep. </summary>
        /// <value> The dir sep. </value>
        char DirSep { get; }

        /// <summary> Gets the path sep. </summary>
        /// <value> The path sep. </value>
        char PathSep { get; }

        /// <summary> Gets the invalid path character. </summary>
        /// <value> The invalid path character. </value>
        char[ ] InvalidPathChars { get; }

        /// <summary> Gets the invalid chars. </summary>
        /// <value> The invalid chars. </value>
        char[ ] InvalidNameChars { get; }
    }
}