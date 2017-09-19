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
	public abstract class RdzRobot : Robot
	{
		public RdzRobotUtility _utility;
		public RdzRobotUtility Utility
		{
			get
			{
				if (_utility != null) return _utility;
				else
				{
					_utility = new RdzRobotUtility(this);
					return _utility;
				}
			}
		}
	}
}
