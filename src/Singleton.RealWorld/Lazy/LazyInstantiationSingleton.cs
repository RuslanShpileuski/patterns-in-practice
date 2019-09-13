namespace Singleton.RealWorld.Lazy
{
	/// <summary>
	/// Fifth version - fully lazy instantiation.
	/// </summary>
	public sealed class LazyInstantiationSingleton
	{
		private LazyInstantiationSingleton()
		{
		}

		public static LazyInstantiationSingleton Instance
		{
			get
			{
				return Nested.instance;
			}
		}

		private class Nested
		{
			/// <summary>
			/// Initializes the <see cref="Nested"/> class.
			/// Explicit static constructor to tell C# compiler
			/// not to mark type as beforefieldinit
			/// </summary>
			static Nested()
			{
			}

			internal static readonly LazyInstantiationSingleton instance = new LazyInstantiationSingleton();
		}
	}
}