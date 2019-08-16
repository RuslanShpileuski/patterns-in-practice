﻿using System;

namespace Prototype
{
	/// <summary>
	/// MainApp startup class for Structural
	/// Prototype Design Pattern.
	/// </summary>
	class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			// Create two instances and clone each
			ConcretePrototype1 p1 = new ConcretePrototype1("I");
			ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
			Console.WriteLine("Cloned: {0}", c1.Id);

			ConcretePrototype2 p2 = new ConcretePrototype2("II");
			ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
			Console.WriteLine("Cloned: {0}", c2.Id);
		}
	}

	/// <summary>
	/// The 'Prototype' abstract class
	/// </summary>
	abstract class Prototype
	{
		// Gets id
		public string Id { get; }

		// Constructor
		public Prototype(string id)
		{
			Id = id;
		}

		public abstract Prototype Clone();
	}

	/// <summary>
	/// A 'ConcretePrototype' class 
	/// </summary>
	class ConcretePrototype1 : Prototype
	{
		// Constructor
		public ConcretePrototype1(string id)
		  : base(id)
		{
		}

		// Returns a shallow copy
		public override Prototype Clone()
		{
			return (Prototype)MemberwiseClone();
		}
	}

	/// <summary>
	/// A 'ConcretePrototype' class 
	/// </summary>
	class ConcretePrototype2 : Prototype
	{
		// Constructor
		public ConcretePrototype2(string id)
		  : base(id)
		{
		}

		// Returns a shallow copy
		public override Prototype Clone()
		{
			return (Prototype)MemberwiseClone();
		}
	}
}