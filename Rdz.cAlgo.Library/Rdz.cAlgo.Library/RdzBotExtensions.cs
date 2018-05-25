using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdz.cAlgo.Library
{
	public static class RdzBotExtensions
	{
		public static bool WithinTimeRange(this DateTime time, DateTime time1, DateTime time2)
		{
			return (time >= time1 && time <= time2);
		}
		public static string Repeat(this string input, int n)
		{
			var result = string.Empty;
			for (var i = 0; i < n; i++)
				result += input;
			return result;
		}
	}
}
