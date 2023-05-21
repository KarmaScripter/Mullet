﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.PathBase"/>
    public class DataPath : PathBase, IDataPath
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataPath"/>
        /// class.
        /// </summary>
        public DataPath( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataPath"/>
        /// class.
        /// </summary>
        /// <param name="input"> The input. </param>
        public DataPath( string input )
            : base( input )
        {
        }
    }
}