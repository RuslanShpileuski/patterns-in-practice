namespace Bridge.RealWorld
{
	/// <summary>
	/// The remote control.
	/// </summary>
	class RemoteControl
	{
		/// <summary>
		/// The device.
		/// </summary>
		protected IDevice device;

		/// <summary>
		/// Initializes a new instance of the <see cref="RemoteControl"/> class.
		/// </summary>
		/// <param name="device">The device.</param>
		public RemoteControl(IDevice device)
		{
			this.device = device;
		}

		/// <summary>
		/// Toggles the power.
		/// </summary>
		public void TogglePower()
		{
			if (device.IsEnabled)
			{
				device.Disable();
			}
			else
			{
				device.Enable();
			}
		}

		/// <summary>
		/// Volumes down.
		/// </summary>
		public void VolumeDown()
		{
			this.device.SetVolume(device.GetVolume() - 10);
		}

		/// <summary>
		/// Volumes up.
		/// </summary>
		public void VolumeUp()
		{
			this.device.SetVolume(device.GetVolume() + 10);
		}

		/// <summary>
		/// Channels down.
		/// </summary>
		public void ChannelDown()
		{
			this.device.SetChannel(this.device.GetChannel() - 1);
		}

		/// <summary>
		/// Channels up.
		/// </summary>
		public void ChannelUp()
		{
			this.device.SetChannel(this.device.GetChannel() + 1);
		}
	}
}