// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ColorConfig
    {
        /// <summary> The border blue </summary>
        public Color Blue { get; }

        /// <summary> The fore red </summary>
        public Color Red { get; }

        /// <summary> The fore gray </summary>
        public Color Gray { get; }

        /// <summary> The fore white </summary>
        public Color White { get; }

        /// <summary> The fore black </summary>
        public Color Black { get; }

        /// <summary> The transparent </summary>
        public Color Transparent { get; }

        /// <summary> The hover gray </summary>
        public Color HoverGray { get; }

        /// <summary> The hover blue </summary>
        public Color HoverBlue { get; }

        /// <summary> The hover blue </summary>
        public Color SteelBlue { get; }

        /// <summary> Gets the maroon. </summary>
        /// <value> The maroon. </value>
        public Color Maroon { get; }

        /// <summary> Gets the light steel blue. </summary>
        /// <value> The light steel blue. </value>
        public Color LightSteelBlue { get; }

        /// <summary> The control interior color </summary>
        public Color DarkInterior { get; }

        /// <summary> The border dark </summary>
        public Color DarkBorder { get; }

        /// <summary> The form dark back color </summary>
        public Color DarkBackground { get; }

        /// <summary> Gets the dark blue. </summary>
        /// <value> The dark blue. </value>
        public Color DarkBlue { get; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ColorConfig"/>
        /// class.
        /// </summary>
        public ColorConfig( )
        {
            Blue = Color.FromArgb( 0, 120, 212 );
            HoverBlue = Color.FromArgb( 50, 93, 129 );
            Transparent = Color.Transparent;
            HoverGray = Color.FromArgb( 70, 70, 70 );
            DarkInterior = Color.FromArgb( 40, 40, 40 );
            Black = Color.Black;
            White = Color.White;
            Red = Color.FromArgb( 192, 0, 0 );
            DarkBorder = Color.FromArgb( 65, 65, 65 );
            DarkBackground = Color.FromArgb( 20, 20, 20 );
            DarkBlue = Color.FromArgb( 24, 47, 66 );
            Gray = Color.DarkGray;
            SteelBlue = Color.SteelBlue;
            Maroon = Color.Maroon;
            LightSteelBlue = Color.LightSteelBlue;
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}