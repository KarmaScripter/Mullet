// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public static class ThrowIf
    {
        /// <summary> </summary>
        public static class Argument
        {
            /// <summary> Determines whether the specified argument is null. </summary>
            /// <param name="argument"> The argument. </param>
            /// <param name="argumentName"> Name of the argument. </param>
            /// <exception cref="System.ArgumentNullException"> </exception>
            public static void IsNull( object argument, string argumentName )
            {
                if( argument == null )
                {
                    throw new ArgumentNullException( argumentName );
                }
            }

            /// <summary> Determines whether the specified argument is negative. </summary>
            /// <param name="argument"> The argument. </param>
            /// <param name="argumentName"> Name of the argument. </param>
            /// <exception cref="System.ArgumentOutOfRangeException"> </exception>
            public static void IsNegative( int argument, string argumentName )
            {
                if( argument < 0 )
                {
                    var _message = $"{argumentName} Must Be Greater Than Zero.";
                    throw new ArgumentOutOfRangeException( argumentName, _message );
                }
            }

            /// <summary>
            /// Determines whether [is zero or negative] [the specified argument].
            /// </summary>
            /// <param name="argument"> The argument. </param>
            /// <param name="argumentName"> Name of the argument. </param>
            /// <exception cref="System.ArgumentOutOfRangeException"> </exception>
            public static void IsZeroOrNegative( int argument, string argumentName )
            {
                if( argument <= 0 )
                {
                    var _message = $"{argumentName} Must Be Greater Than Zero.";
                    throw new ArgumentOutOfRangeException( argumentName, _message );
                }
            }
        }
    }
}