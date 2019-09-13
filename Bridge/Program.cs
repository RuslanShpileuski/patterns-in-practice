using System;

namespace Bridge
{
	/// <summary>
	/// Program startup class for Structural
	/// Bridge Design Pattern.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			Abstraction ab = new RefinedAbstraction();

			// Set implementation and call
			ab.Implementor = new ConcreteImplementorA();
			ab.Operation();

			// Change implemention and call
			ab.Implementor = new ConcreteImplementorB();
			ab.Operation();
		}
	}

	/// <summary>
	/// The 'Abstraction' class
	/// </summary>
	class Abstraction
	{
		/// <summary>
		/// The implementor.
		/// </summary>
		protected Implementor implementor;

		/// <summary>
		/// Sets the implementor.
		/// </summary>
		/// <value>
		/// The implementor.
		/// </value>
		public Implementor Implementor
		{
			set { implementor = value; }
		}

		public virtual void Operation()
		{
			implementor.Operation();
		}
	}

	/// <summary>
	/// The 'Implementor' abstract class
	/// </summary>
	abstract class Implementor
	{
		/// <summary>
		/// Operations this instance.
		/// </summary>
		public abstract void Operation();
	}

	/// <summary>
	/// The 'RefinedAbstraction' class
	/// </summary>
	class RefinedAbstraction : Abstraction
	{
		/// <summary>
		/// Operations this instance.
		/// </summary>
		public override void Operation()
		{
			implementor.Operation();
		}
	}

	/// <summary>
	/// The 'ConcreteImplementorA' class
	/// </summary>
	class ConcreteImplementorA : Implementor
	{
		/// <summary>
		/// Operations this instance.
		/// </summary>
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorA Operation");
		}
	}

	/// <summary>
	/// The 'ConcreteImplementorB' class
	/// </summary>
	class ConcreteImplementorB : Implementor
	{
		/// <summary>
		/// Operations this instance.
		/// </summary>
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorB Operation");
		}
	}
}