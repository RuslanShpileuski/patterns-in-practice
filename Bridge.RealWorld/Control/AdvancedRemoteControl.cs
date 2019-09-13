namespace Bridge.RealWorld
{
	/// <summary>
	/// The advanced remote control.
	/// </summary>
	/// <seealso cref="Bridge.RealWorld.RemoteControl" />
	class AdvancedRemoteControl : RemoteControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AdvancedRemoteControl"/> class.
		/// </summary>
		/// <param name="device">The device.</param>
		public AdvancedRemoteControl(IDevice device)
			: base(device)
		{
		}

		/// <summary>
		/// Mutes this instance.
		/// </summary>
		public void Mute()
		{
			this.device.SetVolume(0);
		}
	}
}