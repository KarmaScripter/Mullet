// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// Defines the
    /// <see cref="TimeSpanExtensions"/>
    /// .
    /// </summary>
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public static class TimeSpanExtensions
    {
        /// <summary> Defines the AvgDaysInAYear. </summary>
        public const double AvgDaysInAYear = 365.2425d;

        /// <summary> Defines the AvgDaysInAMonth. </summary>
        public const double AvgDaysInAMonth = 30.436875d;

        /// <summary> The GetYears. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="int"/>
        /// .
        /// </returns>
        public static int GetYears( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays / AvgDaysInAYear );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary> The GetTotalYears. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="double"/>
        /// .
        /// </returns>
        public static double GetTotalYears( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / AvgDaysInAYear;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary> The GetMonths. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="int"/>
        /// .
        /// </returns>
        public static int GetMonths( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % AvgDaysInAYear / AvgDaysInAMonth );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary> The GetTotalMonths. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="double"/>
        /// .
        /// </returns>
        public static double GetTotalMonths( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / AvgDaysInAMonth;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary> The GetWeeks. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="int"/>
        /// .
        /// </returns>
        public static int GetWeeks( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % AvgDaysInAYear % AvgDaysInAMonth / 7d );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary> The GetTotalWeeks. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="double"/>
        /// .
        /// </returns>
        public static double GetTotalWeeks( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / 7d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary> The GetDays. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="int"/>
        /// .
        /// </returns>
        public static int GetDays( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % 7d );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary> The GetMicroseconds. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="double"/>
        /// .
        /// </returns>
        public static double GetMicroseconds( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.Ticks / 10d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary> The GetNanoseconds. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="double"/>
        /// .
        /// </returns>
        public static double GetNanoseconds( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.Ticks / 100d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary> The Round. </summary>
        /// <param name="timeSpan">
        /// The timeSpan
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <param name="roundinginterval">
        /// The roundingInterval
        /// <see cref="TimeSpan"/>
        /// .
        /// </param>
        /// <param name="roundingtype">
        /// The roundingType
        /// <see cref="MidpointRounding"/>
        /// .
        /// </param>
        /// <returns>
        /// The
        /// <see cref="TimeSpan"/>
        /// .
        /// </returns>
        public static TimeSpan Round( this TimeSpan timeSpan, TimeSpan roundinginterval, MidpointRounding roundingtype = MidpointRounding.ToEven )
        {
            try
            {
                return new TimeSpan( Convert.ToInt64( Math.Round( timeSpan.Ticks / (double)roundinginterval.Ticks, roundingtype ) ) * roundinginterval.Ticks );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( TimeSpan );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}