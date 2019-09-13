namespace Singleton.RealWorld.Bad
{
	/// <summary>
	/// First version - not thread-safe.
	/// </summary>
	sealed class BadSigleton
	{
		private static BadSigleton instance = null;

		private BadSigleton()
		{
		}

		public static BadSigleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new BadSigleton();
				}

				return instance;
			}
		}
	}
}