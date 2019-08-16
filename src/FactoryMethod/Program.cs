using System;

namespace FactoryMethod
{
	/// <summary>
	/// MainApp startup class for Structural 
	/// Factory Method Design Pattern.
	/// </summary>
	class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			// An array of creators
			Creator[] creators = new Creator[2];

			creators[0] = new ConcreteCreatorA();
			creators[1] = new ConcreteCreatorB();

			// Iterate over creators and create products
			foreach (Creator creator in creators)
			{
				Product product = creator.FactoryMethod();
				Console.WriteLine($"Created {product.GetType().Name}");
			}
		}
	}

	/// <summary>
	/// The 'Product' abstract class
	/// </summary>
	abstract class Product
	{
		public Product()
		{
			Console.WriteLine($"{nameof(Product)}.ctor");
		}
	}

	/// <summary>
	/// A 'ConcreteProduct' class
	/// </summary>
	class ConcreteProductA : Product
	{
		public ConcreteProductA()
		{
			Console.WriteLine($"{nameof(ConcreteProductA)}.ctor");
		}
	}

	/// <summary>
	/// A 'ConcreteProduct' class
	/// </summary>
	class ConcreteProductB : Product
	{
		public ConcreteProductB()
		{
			Console.WriteLine($"{nameof(ConcreteProductB)}.ctor");
		}
	}

	/// <summary>
	/// The 'Creator' abstract class
	/// </summary>
	abstract class Creator
	{
		public Creator()
		{
			Console.WriteLine($"{nameof(Creator)}.ctor");
		}

		public abstract Product FactoryMethod();
	}

	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	class ConcreteCreatorA : Creator
	{
		public ConcreteCreatorA()
		{
			Console.WriteLine($"{nameof(ConcreteCreatorA)}.ctor");
		}

		public override Product FactoryMethod()
		{
			return new ConcreteProductA();
		}
	}

	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	class ConcreteCreatorB : Creator
	{
		public ConcreteCreatorB()
		{
			Console.WriteLine($"{nameof(ConcreteCreatorB)}.ctor");
		}

		public override Product FactoryMethod()
		{
			return new ConcreteProductB();
		}
	}
}