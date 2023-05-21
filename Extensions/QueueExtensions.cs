// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public static class QueueExtensions
    {
        public static void Add<T>( this Queue<T> queue, T item )
        {
            queue.Enqueue( item );
        }
    }
}