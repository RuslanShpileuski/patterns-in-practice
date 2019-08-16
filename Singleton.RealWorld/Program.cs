using System;

namespace Singleton.RealWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			var badSingleton = BadSigleton.Instance;
			var badSingletonSame = BadSigleton.Instance;

			var simpleThreadSafeSingleton = SimpleThreadSafeSingleton.Instance;
			var simpleThreadSafeSingletonSame = SimpleThreadSafeSingleton.Instance;

			var badThreadSafeDoubleCheckSingleton = BadThreadSafeDoubleCheckSingleton.Instance;
			var badThreadSafeDoubleCheckSingletonSame = BadThreadSafeDoubleCheckSingleton.Instance;

			var notLazyThreadSafeWithoutLockSingleton = NotLazyThreadSafeWithoutLockSingleton.Instance;
			var notLazyThreadSafeWithoutLockSingletonSame = NotLazyThreadSafeWithoutLockSingleton.Instance;

			var lazyInstantiationSingleton = LazyInstantiationSingleton.Instance;
			var lazyInstantiationSingletonSame = LazyInstantiationSingleton.Instance;

			var lazySingleton = LazySingleton.Instance;
			var lazySingletonSame = LazySingleton.Instance;

			Console.WriteLine($"[BadSigleton.Instance] objects are the same = {badSingleton.Equals(badSingletonSame)}");
			Console.WriteLine($"[SimpleThreadSafeSingleton.Instance] objects are the same = {simpleThreadSafeSingleton.Equals(simpleThreadSafeSingletonSame)}");
			Console.WriteLine($"[BadThreadSafeDoubleCheckSingleton.Instance] objects are the same = {badThreadSafeDoubleCheckSingleton.Equals(badThreadSafeDoubleCheckSingletonSame)}");
			Console.WriteLine($"[NotLazyThreadSafeWithoutLockSingleton.Instance] objects are the same = {notLazyThreadSafeWithoutLockSingleton.Equals(notLazyThreadSafeWithoutLockSingletonSame)}");
			Console.WriteLine($"[LazyInstantiationSingleton.Instance] objects are the same = {lazyInstantiationSingleton.Equals(lazyInstantiationSingletonSame)}");
			Console.WriteLine($"[LazySingleton.Instance] objects are the same = {lazySingleton.Equals(lazySingletonSame)}");
		}
	}

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

	/// <summary>
	/// Second version - simple thread-safety.
	/// </summary>
	public sealed class SimpleThreadSafeSingleton
	{
		private static SimpleThreadSafeSingleton instance = null;
		private static readonly object padlock = new object();

		SimpleThreadSafeSingleton()
		{
		}

		public static SimpleThreadSafeSingleton Instance
		{
			get
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new SimpleThreadSafeSingleton();
					}

					return instance;
				}
			}
		}
	}

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