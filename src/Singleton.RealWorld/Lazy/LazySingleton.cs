using System;

namespace Singleton.RealWorld.Lazy
{
	/// <summary>
	/// Sixth version - using .NET 4's Lazy<T> type.
	/// </summary>
	public sealed class LazySingleton
	{
		private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());

		public static LazySingleton Instance
		{
			get
			{
				return lazy.Value;
			}
		}

		private LazySingleton()
		{
		}
	}
}