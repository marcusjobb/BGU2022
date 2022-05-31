using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace BFU02_01
{
	public static class PercentFixer
	{
        public static double AddPercent(this double value, double percent) => value * (1 + percent / 100);
        public static int AddPercent(this int value, double percent) => (int)((double)value).AddPercent(percent);
        public static double SubtractPercent(this double value, double percent) => value * (percent / 100);
        public static int SubtractPercent(this int value, double percent) => (int)((double)value).SubtractPercent(percent);
    }
}