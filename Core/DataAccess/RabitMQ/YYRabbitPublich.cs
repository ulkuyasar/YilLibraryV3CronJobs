using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.RabitMQ
{
	public sealed class YYRabbitPublich
	{
		private static Publisher instance = null;
		private static readonly object padlock = new object();

		YYRabbitPublich()
		{
		}

		public static Publisher Instance
		{
			get
			{
				if (instance == null)
				{
					lock (padlock)
					{
						if (instance == null)
						{
							instance = new Publisher();
						}
					}
				}
				return instance;
			}
		}

	}
}
