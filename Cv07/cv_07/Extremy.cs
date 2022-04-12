﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie7
{
    public class Extremy
    {
        public static T Largest<T>(params T[] values) where T : IComparable
        {
            T max = values[0];
            for (int i = 1; i < values.Length; i++)
                if (values[i].CompareTo(max) > 0) max = values[i];
            return max;

        }
        public static T Smallest<T>(params T[] values) where T : IComparable
        {
            T min = values[0];
            for (int i = 1; i < values.Length; i++)
                if (values[i].CompareTo(min) < 0) min = values[i];
            return min;

        }

    }
}
