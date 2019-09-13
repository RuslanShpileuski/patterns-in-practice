namespace Bridge.RealWorld
{
	/// <summary>
	/// The device interface.
	/// </summary>
	interface IDevice
	{
		/// <summary>
		/// Gets a value indicating whether this instance is enabled.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is enabled; otherwise, <c>false</c>.
		/// </value>
		bool IsEnabled { get; }

		/// <summary>
		/// Enables this instance.
		/// </summary>
		void Enable();

		/// <summary>
		/// Disables this instance.
		/// </summary>
		void Disable();

		/// <summary>
		/// Gets the volume.
		/// </summary>
		/// <returns></returns>
		int GetVolume();

		/// <summary>
		/// Sets the volume.
		/// </summary>
		/// <param name="percent">The percent.</param>
		void SetVolume(int percent);

		/// <summary>
		/// Gets the channel.
		/// </summary>
		/// <returns></returns>
		int GetChannel();

		/// <summary>
		/// Sets the channel.
		/// </summary>
		/// <param name="channel">The channel.</param>
		void SetChannel(int channel);
	}
}