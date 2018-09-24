﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToMassMomentOfInertia
{
    public static class NumberToMassMomentOfInertiaExtensions
    {
        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareCentimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia GramSquareCentimeters<T>(this T value) => MassMomentOfInertia.FromGramSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareDecimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia GramSquareDecimeters<T>(this T value) => MassMomentOfInertia.FromGramSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia GramSquareMeters<T>(this T value) => MassMomentOfInertia.FromGramSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromGramSquareMillimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia GramSquareMillimeters<T>(this T value) => MassMomentOfInertia.FromGramSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareCentimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia KilogramSquareCentimeters<T>(this T value) => MassMomentOfInertia.FromKilogramSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareDecimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia KilogramSquareDecimeters<T>(this T value) => MassMomentOfInertia.FromKilogramSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia KilogramSquareMeters<T>(this T value) => MassMomentOfInertia.FromKilogramSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilogramSquareMillimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia KilogramSquareMillimeters<T>(this T value) => MassMomentOfInertia.FromKilogramSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilotonneSquareCentimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia KilotonneSquareCentimeters<T>(this T value) => MassMomentOfInertia.FromKilotonneSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilotonneSquareDecimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia KilotonneSquareDecimeters<T>(this T value) => MassMomentOfInertia.FromKilotonneSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilotonneSquareMeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia KilotonneSquareMeters<T>(this T value) => MassMomentOfInertia.FromKilotonneSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromKilotonneSquareMilimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia KilotonneSquareMilimeters<T>(this T value) => MassMomentOfInertia.FromKilotonneSquareMilimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMegatonneSquareCentimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia MegatonneSquareCentimeters<T>(this T value) => MassMomentOfInertia.FromMegatonneSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMegatonneSquareDecimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia MegatonneSquareDecimeters<T>(this T value) => MassMomentOfInertia.FromMegatonneSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMegatonneSquareMeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia MegatonneSquareMeters<T>(this T value) => MassMomentOfInertia.FromMegatonneSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMegatonneSquareMilimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia MegatonneSquareMilimeters<T>(this T value) => MassMomentOfInertia.FromMegatonneSquareMilimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareCentimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia MilligramSquareCentimeters<T>(this T value) => MassMomentOfInertia.FromMilligramSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareDecimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia MilligramSquareDecimeters<T>(this T value) => MassMomentOfInertia.FromMilligramSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia MilligramSquareMeters<T>(this T value) => MassMomentOfInertia.FromMilligramSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromMilligramSquareMillimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia MilligramSquareMillimeters<T>(this T value) => MassMomentOfInertia.FromMilligramSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareFeet(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia PoundSquareFeet<T>(this T value) => MassMomentOfInertia.FromPoundSquareFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromPoundSquareInches(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia PoundSquareInches<T>(this T value) => MassMomentOfInertia.FromPoundSquareInches(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromTonneSquareCentimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia TonneSquareCentimeters<T>(this T value) => MassMomentOfInertia.FromTonneSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromTonneSquareDecimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia TonneSquareDecimeters<T>(this T value) => MassMomentOfInertia.FromTonneSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromTonneSquareMeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia TonneSquareMeters<T>(this T value) => MassMomentOfInertia.FromTonneSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="MassMomentOfInertia.FromTonneSquareMilimeters(UnitsNet.QuantityValue)" />
        public static MassMomentOfInertia TonneSquareMilimeters<T>(this T value) => MassMomentOfInertia.FromTonneSquareMilimeters(Convert.ToDouble(value));

    }
}
#endif
