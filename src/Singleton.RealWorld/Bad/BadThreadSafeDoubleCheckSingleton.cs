namespace Singleton.RealWorld.Bad
{
	/// <summary>
	/// Third version - attempted thread-safety using double-check locking.
	/// </summary>
	sealed class BadThreadSafeDoubleCheckSingleton
	{
		private static BadThreadSafeDoubleCheckSingleton instance = null;
		private static readonly object padlock = new object();

		BadThreadSafeDoubleCheckSingleton()
		{
		}

		public static BadThreadSafeDoubleCheckSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					lock (padlock)
					{
						if (instance == null)
						{
							instance = new BadThreadSafeDoubleCheckSingleton();
						}
					}
				}

				return instance;
			}
		}
	}
}