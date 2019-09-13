namespace Bridge.RealWorld
{
	/// <summary>
	/// The TV device.
	/// </summary>
	/// <seealso cref="Bridge.RealWorld.IDevice" />
	class TV : IDevice
	{
		/// <summary>
		/// Gets or sets a value indicating whether this instance is enabled.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is enabled; otherwise, <c>false</c>.
		/// </value>
		public bool IsEnabled { get; set; }

		/// <summary>
		/// Disables this instance.
		/// </summary>
		public void Disable()
		{
			this.IsEnabled = false;
		}

		/// <summary>
		/// Enables this instance.
		/// </summary>
		public void Enable()
		{
			this.IsEnabled = true;
		}

		/// <summary>
		/// Gets the channel.
		/// </summary>
		/// <returns></returns>
		public int GetChannel()
		{
			return 0;
		}

		/// <summary>
		/// Gets the volume.
		/// </summary>
		/// <returns></returns>
		public int GetVolume()
		{
			return 0;
		}

		/// <summary>
		/// Sets the channel.
		/// </summary>
		/// <param name="channel">The channel.</param>
		public void SetChannel(int channel)
		{
		}

		/// <summary>
		/// Sets the volume.
		/// </summary>
		/// <param name="percent">The percent.</param>
		public void SetVolume(int percent)
		{
		}
	}
}