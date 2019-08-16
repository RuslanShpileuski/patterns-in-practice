using System;

namespace Singleton
{
	/// <summary>
	/// MainApp startup class for Structural
	/// Singleton Design Pattern.
	/// </summary>
	class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			// Constructor is protected -- cannot use new
			Singleton s1 = Singleton.Instance();
			Singleton s2 = Singleton.Instance();

			// Test for same instance
			if (s1 == s2)
			{
				Console.WriteLine("Objects are the same instance");
			}
		}
	}

	/// <summary>
	/// The 'Singleton' class.
	/// </summary>
	class Singleton
	{
		private static Singleton instance;

		// Constructor is 'protected'
		protected Singleton()
		{
		}

		public static Singleton Instance()
		{
			// Uses lazy initialization.
			// Note: this is not thread safe.
			if (instance == null)
			{
				instance = new Singleton();
			}

			return instance;
		}
	}
}