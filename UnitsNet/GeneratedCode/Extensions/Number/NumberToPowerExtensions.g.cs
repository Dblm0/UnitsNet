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
namespace UnitsNet.Extensions.NumberToPower
{
    public static class NumberToPowerExtensions
    {
        /// <inheritdoc cref="Power.FromBoilerHorsepower(UnitsNet.QuantityValue)" />
        public static Power BoilerHorsepower<T>(this T value) => Power.FromBoilerHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(UnitsNet.QuantityValue)" />
        public static Power BritishThermalUnitsPerHour<T>(this T value) => Power.FromBritishThermalUnitsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromDecawatts(UnitsNet.QuantityValue)" />
        public static Power Decawatts<T>(this T value) => Power.FromDecawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromDeciwatts(UnitsNet.QuantityValue)" />
        public static Power Deciwatts<T>(this T value) => Power.FromDeciwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromElectricalHorsepower(UnitsNet.QuantityValue)" />
        public static Power ElectricalHorsepower<T>(this T value) => Power.FromElectricalHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromFemtowatts(UnitsNet.QuantityValue)" />
        public static Power Femtowatts<T>(this T value) => Power.FromFemtowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromGigawatts(UnitsNet.QuantityValue)" />
        public static Power Gigawatts<T>(this T value) => Power.FromGigawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(UnitsNet.QuantityValue)" />
        public static Power HydraulicHorsepower<T>(this T value) => Power.FromHydraulicHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(UnitsNet.QuantityValue)" />
        public static Power KilobritishThermalUnitsPerHour<T>(this T value) => Power.FromKilobritishThermalUnitsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromKilowatts(UnitsNet.QuantityValue)" />
        public static Power Kilowatts<T>(this T value) => Power.FromKilowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(UnitsNet.QuantityValue)" />
        public static Power MechanicalHorsepower<T>(this T value) => Power.FromMechanicalHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMegawatts(UnitsNet.QuantityValue)" />
        public static Power Megawatts<T>(this T value) => Power.FromMegawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMetricHorsepower(UnitsNet.QuantityValue)" />
        public static Power MetricHorsepower<T>(this T value) => Power.FromMetricHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMicrowatts(UnitsNet.QuantityValue)" />
        public static Power Microwatts<T>(this T value) => Power.FromMicrowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMilliwatts(UnitsNet.QuantityValue)" />
        public static Power Milliwatts<T>(this T value) => Power.FromMilliwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromNanowatts(UnitsNet.QuantityValue)" />
        public static Power Nanowatts<T>(this T value) => Power.FromNanowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromPetawatts(UnitsNet.QuantityValue)" />
        public static Power Petawatts<T>(this T value) => Power.FromPetawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromPicowatts(UnitsNet.QuantityValue)" />
        public static Power Picowatts<T>(this T value) => Power.FromPicowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromTerawatts(UnitsNet.QuantityValue)" />
        public static Power Terawatts<T>(this T value) => Power.FromTerawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromWatts(UnitsNet.QuantityValue)" />
        public static Power Watts<T>(this T value) => Power.FromWatts(Convert.ToDouble(value));

    }
}
#endif
