﻿using System;
using ServiceStack;
using Funq;
using DockSlack.Components.Extensions;
using DockSlack.ServiceModels;
using DockSlack.ServiceInterfaces;

namespace DockSlack.Components
{
	public class AppServiceHost : AppSelfHostBase
	{
		public AppServiceHost() 
			: base("DockSlack", typeof(PingService).Assembly) 
		{ }

		public override void Configure(Container container) 
		{
			this.Initialize();
		}
	}
}

