using System;
using ServiceStack;
using ServiceStack.Text;
using DockSlack.ServiceInterfaces;
using DockSlack.ServiceModels;

namespace DockSlack.Components.Extensions
{
	internal static class AppHostExtensions
	{
		public static void Initialize(this IAppHost appHost)
		{
			JsConfig.PropertyConvention = PropertyConvention.Lenient;
			JsConfig.EmitCamelCaseNames = false;
			JsConfig.EmitLowercaseUnderscoreNames = true;
			JsConfig.DateHandler = DateHandler.ISO8601;
			JsConfig.TreatEnumAsInteger = true;
		}
	}
}

