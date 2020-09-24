﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AdaptiveExpressions.Memory;

namespace AdaptiveExpressions
{
    /// <summary>
    /// Extension methods for detecting or value testing of various types.
    /// </summary>
    public static partial class Extensions
    {
        private static readonly object _randomizerLock = new object();

        private static Random _random;
        private static int? previousSeed;

        /// <summary>
        /// Test an object to see if it is a numeric type.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>True if numeric type.</returns>
        public static bool IsNumber(this object value)
            => value is sbyte
            || value is byte
            || value is short
            || value is ushort
            || value is int
            || value is uint
            || value is long
            || value is ulong
            || value is float
            || value is double
            || value is decimal;

        /// <summary>
        /// Test an object to see if it is an integer type.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>True if numeric type.</returns>
        public static bool IsInteger(this object value)
            => value is sbyte
            || value is byte
            || value is short
            || value is ushort
            || value is int
            || value is uint
            || value is long
            || value is ulong;

        /// <summary>
        /// Generator random seed and value from properties.
        /// If value is not null, the mock random value result would be: min + (value % (max - min)).
        /// Else if seed is not null, the seed of the random would be fixed.
        /// </summary>
        /// <param name="memory">memory state.</param>
        /// <param name="min">The inclusive lower bound of the random number returned.</param>
        /// <param name="max">The exclusive upper bound of the random number returned. max must be greater than or equal to min.</param>
        /// <param name="seed">user seed.</param>
        /// <returns>Random seed and value.</returns>
        public static int RandomNext(this IMemory memory, int min, int max, int? seed = null)
        {
            if (memory.TryGetValue("Conversation.TestOptions.randomValue", out var randomValue)
                && randomValue.IsInteger())
            {
                var randomValueNum = Convert.ToInt32(randomValue, CultureInfo.InvariantCulture);
                return min + (randomValueNum % (max - min));
            }

            if (memory.TryGetValue("Conversation.TestOptions.randomSeed", out var randomSeed)
                    && randomSeed.IsInteger())
            {
                seed = Convert.ToInt32(randomSeed, CultureInfo.InvariantCulture);
            }

            if (seed != null && 
                (previousSeed == null || (previousSeed != null && previousSeed.Value != seed.Value)))
            {
                _random = new Random(seed.Value);
                previousSeed = seed;
            }

            lock (_randomizerLock)
            {
                if (_random == null)
                {
                    _random = new Random();
                }

                return _random.Next(min, max);
            }
        }
    }
}
