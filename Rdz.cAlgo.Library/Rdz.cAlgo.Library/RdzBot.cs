using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cAlgo.API;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;
using cAlgo.Indicators;
using Rdz.cAlgo.Library;


namespace Rdz.cAlgo.Library
{
	public abstract class RdzBot : Robot
	{
		public RdzBotUtility _utility;
		public RdzBotUtility Utility
		{
			get
			{
				if (_utility != null) return _utility;
				else
				{
					_utility = new RdzBotUtility(this);
					return _utility;
				}
			}
		}

		public void PrintTestingData()
		{
			Print("ASK: {0} and BID: {1}", Symbol.Ask.ToString(), Symbol.Bid.ToString());
			Print("TICKSIZE: {0} and TICKVALUE: {1}", Symbol.TickSize.ToString("#0." + "0".Repeat(Symbol.Digits)), Symbol.TickValue.ToString("#0." + "0".Repeat(Symbol.Digits)));
			Print("SPREAD: {0} and DIGITS: {1}", Symbol.Spread.ToString(), Symbol.Digits.ToString());
			Print("CODE: {0} and LEVERAGE: {1}", Symbol.Code, Symbol.PreciseLeverage.ToString());
			Print("LOTSIZE: {0}", Symbol.LotSize.ToString());
			Print("PIPSIZE: {0} and PIPVALUE: {1}", Symbol.PipSize.ToString("#0." + "0".Repeat(Symbol.Digits)), Symbol.PipValue.ToString("#0." + "0".Repeat(Symbol.Digits)));
			Print("UNREALIZED PROFITS -> GROSS: {0} and NET: {1}", Symbol.UnrealizedGrossProfit.ToString(), Symbol.UnrealizedNetProfit.ToString());
			Print("VOLUME -> MAX: {0}, MIN: {1} and STEP: {2}", Symbol.VolumeMax.ToString(), Symbol.VolumeMin.ToString(), Symbol.VolumeStep.ToString());
			Print("VolumeToQuantity(100000) = {0}", Symbol.VolumeToQuantity(100000).ToString());
			Print("QuantityToVolume(0.01) = {0}", Symbol.QuantityToVolume(0.01).ToString());
			Print("NormalizeVolume(123456) = {0}", Symbol.NormalizeVolume(123456).ToString());
		}
	}
}
