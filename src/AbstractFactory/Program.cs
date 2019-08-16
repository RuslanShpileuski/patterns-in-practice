using System;

namespace AbstractFactory
{
	/// <summary>
	/// MainApp startup class for Structural
	/// Abstract Factory Design Pattern.
	/// </summary>
	class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		public static void Main()
		{
			// Abstract factory #1
			AbstractFactory factory1 = new ConcreteFactory1();
			Client client1 = new Client(factory1);
			client1.Run();

			// Abstract factory #2
			AbstractFactory factory2 = new ConcreteFactory2();
			Client client2 = new Client(factory2);
			client2.Run();
			client2.Run();
		}
	}

	/// <summary>
	/// The 'AbstractFactory' abstract class
	/// </summary>
	abstract class AbstractFactory
	{
		public AbstractFactory()
		{
			Console.WriteLine("AbstractFactory.ctor");
		}

		public abstract AbstractProductA CreateProductA();
		public abstract AbstractProductB CreateProductB();
	}


	/// <summary>
	/// The 'ConcreteFactory1' class
	/// </summary>

	class ConcreteFactory1 : AbstractFactory
	{
		public ConcreteFactory1()
		{
			Console.WriteLine("ConcreteFactory1.ctor");
		}

		public override AbstractProductA CreateProductA()
		{
			return new ProductA1();
		}
		public override AbstractProductB CreateProductB()
		{
			return new ProductB1();
		}
	}

	/// <summary>
	/// The 'ConcreteFactory2' class
	/// </summary>
	class ConcreteFactory2 : AbstractFactory
	{
		public ConcreteFactory2()
		{
			Console.WriteLine("ConcreteFactory2.ctor");
		}
		public override AbstractProductA CreateProductA()
		{
			return new ProductA2();
		}
		public override AbstractProductB CreateProductB()
		{
			return new ProductB2();
		}
	}

	/// <summary>
	/// The 'AbstractProductA' abstract class
	/// </summary>
	abstract class AbstractProductA
	{
		public AbstractProductA()
		{
			Console.WriteLine("AbstractProductA.ctor");
		}
	}

	/// <summary>
	/// The 'AbstractProductB' abstract class
	/// </summary>
	abstract class AbstractProductB
	{
		public AbstractProductB()
		{
			Console.WriteLine("AbstractProductB.ctor");
		}

		public abstract void Interact(AbstractProductA a);
	}


	/// <summary>
	/// The 'ProductA1' class
	/// </summary>
	class ProductA1 : AbstractProductA
	{
		public ProductA1()
		{
			Console.WriteLine("ProductA1.ctor");
		}
	}

	/// <summary>
	/// The 'ProductB1' class
	/// </summary>
	class ProductB1 : AbstractProductB
	{
		public ProductB1()
		{
			Console.WriteLine("ProductB1.ctor");
		}

		public override void Interact(AbstractProductA a)
		{
			Console.WriteLine($"{GetType().Name} interacts with {a.GetType().Name}");
		}
	}

	/// <summary>
	/// The 'ProductA2' class
	/// </summary>
	class ProductA2 : AbstractProductA
	{
		public ProductA2()
		{
			Console.WriteLine("ProductA2.ctor");
		}
	}

	/// <summary>
	/// The 'ProductB2' class
	/// </summary>
	class ProductB2 : AbstractProductB
	{
		public ProductB2()
		{
			Console.WriteLine("ProductB2.ctor");
		}

		public override void Interact(AbstractProductA a)
		{
			Console.WriteLine($"{GetType().Name} interacts with {a.GetType().Name}");
		}
	}

	/// <summary>
	/// The 'Client' class. Interaction environment for the products.
	/// </summary>
	class Client
	{
		private AbstractProductA _abstractProductA;
		private AbstractProductB _abstractProductB;

		// Constructor
		public Client(AbstractFactory factory)
		{
			_abstractProductB = factory.CreateProductB();
			_abstractProductA = factory.CreateProductA();
		}

		public void Run()
		{
			_abstractProductB.Interact(_abstractProductA);
		}
	}
}