using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdz.cAlgo.Library
{
	public static class RdzRobotExt
	{
		public static bool WithinTimeRange(this DateTime time, DateTime time1, DateTime time2)
		{
			return (time >= time1 && time <= time2);
		}
	}
}
