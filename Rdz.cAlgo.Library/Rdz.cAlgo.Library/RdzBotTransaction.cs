using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdz.cAlgo.Library
{
	public abstract class RdzBotTransaction
	{
		public RdzBotTransaction() : base ()
		{
			ID = Guid.NewGuid();
		}
		internal Guid ID { get; private set; }
		internal Guid TrapLineID { get; set; }
		internal string Label { get; set; }
	}
}
