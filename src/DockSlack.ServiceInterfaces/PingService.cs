using System;
using ServiceStack;
using DockSlack.ServiceModels;

namespace DockSlack.ServiceInterfaces
{
	public class PingService : Service
	{
		public object Any(Ping request)
		{
			return new PingResponse() 
			{
				Timestamp = DateTime.Now
			};
		}
	}
}

