using System;

namespace Bridge.RealWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			var remote = new RemoteControl(new TV());
			remote.TogglePower();

			remote = new AdvancedRemoteControl(new Radio());
			remote.ChannelUp();
		}
	}
}