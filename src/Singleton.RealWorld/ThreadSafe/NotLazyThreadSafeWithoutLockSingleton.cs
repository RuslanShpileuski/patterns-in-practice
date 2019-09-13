namespace Singleton.RealWorld.ThreadSafe
{
	/// <summary>
	/// Fourth version - not quite as lazy, but thread-safe without using locks.
	/// </summary>
	public sealed class NotLazyThreadSafeWithoutLockSingleton
	{
		public static NotLazyThreadSafeWithoutLockSingleton Instance { get; } = new NotLazyThreadSafeWithoutLockSingleton();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static NotLazyThreadSafeWithoutLockSingleton()
		{
		}

		private NotLazyThreadSafeWithoutLockSingleton()
		{
		}
	}
}