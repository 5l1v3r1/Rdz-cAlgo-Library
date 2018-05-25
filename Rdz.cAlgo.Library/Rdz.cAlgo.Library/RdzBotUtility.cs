using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdz.cAlgo.Library
{
	public class RdzBotUtility
	{
		public RdzBotUtility(RdzBot Robot)
		{
			this.Robot = Robot;
		}
		public RdzBot Robot { get; internal set; }

		public int Gap(double value1, double value2)
		{
			int gap = (int)((value1 - value2) / Robot.Symbol.TickSize);
			return (gap < 0 ? gap * -1 : gap); //returns to always positive number
		}
		public double ShiftPrice(double price, int points)
		{
			var priceDiff = Robot.Symbol.TickSize * points;
			return price + priceDiff;
		}

		public long LotSizeToVolume(double LotSize)
		{
			return Robot.Symbol.NormalizeVolume((Robot.Symbol.LotSize * LotSize));
		}
	}
}
