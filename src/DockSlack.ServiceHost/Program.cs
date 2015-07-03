using System;
using DockSlack.Components;

namespace DockSlack.ServiceHost
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			new AppServiceHost().Init().Start("http://*:8080/");;

			Console.WriteLine("Press ENTER to exit...");
			Console.ReadLine();
		}
	}
}
