using Singleton.RealWorld.Bad;
using Singleton.RealWorld.Lazy;
using Singleton.RealWorld.ThreadSafe;
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
}