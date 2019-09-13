using System;

namespace AbstractFactory.RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Abstract Factory Design Pattern.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		public static void Main()
		{
			// Create and run the African animal world
			ContinentFactory africa = new AfricaFactory();
			AnimalWorld world = new AnimalWorld(africa);
			world.RunFoodChain();

			// Create and run the American animal world
			ContinentFactory america = new AmericaFactory();
			world = new AnimalWorld(america);
			world.RunFoodChain();
		}
	}

	/// <summary>
	/// The 'AbstractFactory' abstract class
	/// </summary>
	abstract class ContinentFactory
	{
		public ContinentFactory()
		{
			Console.WriteLine("ContinentFactory.ctor");
		}

		public abstract Herbivore CreateHerbivore();
		public abstract Carnivore CreateCarnivore();
	}

	/// <summary>
	/// The 'ConcreteFactory1' class
	/// </summary>
	class AfricaFactory : ContinentFactory
	{
		public AfricaFactory()
		{
			Console.WriteLine("AfricaFactory.ctor");
		}

		public override Herbivore CreateHerbivore()
		{
			return new Wildebeest();
		}

		public override Carnivore CreateCarnivore()
		{
			return new Lion();
		}
	}

	/// <summary>
	/// The 'ConcreteFactory2' class
	/// </summary>
	class AmericaFactory : ContinentFactory
	{
		public AmericaFactory()
		{
			Console.WriteLine("AmericaFactory.ctor");
		}

		public override Herbivore CreateHerbivore()
		{
			return new Bison();
		}

		public override Carnivore CreateCarnivore()
		{
			return new Wolf();
		}
	}

	/// <summary>
	/// The 'AbstractProductA' abstract class
	/// </summary>
	abstract class Herbivore
	{
		public Herbivore()
		{
			Console.WriteLine("Herbivore.ctor");
		}
	}

	/// <summary>
	/// The 'AbstractProductB' abstract class
	/// </summary>
	abstract class Carnivore
	{
		public Carnivore()
		{
			Console.WriteLine("Carnivore.ctor");
		}

		public abstract void Eat(Herbivore h);
	}

	/// <summary>
	/// The 'ProductA1' class
	/// </summary>
	class Wildebeest : Herbivore
	{
		public Wildebeest()
		{
			Console.WriteLine("Wildebeest.ctor");
		}
	}

	/// <summary>
	/// The 'ProductB1' class
	/// </summary>
	class Lion : Carnivore
	{
		public Lion()
		{
			Console.WriteLine("Lion.ctor");
		}

		public override void Eat(Herbivore h)
		{
			// Eat Wildebeest
			Console.WriteLine($"{GetType().Name} eats {h.GetType().Name}");
		}
	}

	/// <summary>
	/// The 'ProductA2' class
	/// </summary>
	class Bison : Herbivore
	{
		public Bison()
		{
			Console.WriteLine("Bison.ctor");
		}
	}

	/// <summary>
	/// The 'ProductB2' class
	/// </summary>
	class Wolf : Carnivore
	{
		public Wolf()
		{
			Console.WriteLine("Wolf.ctor");
		}

		public override void Eat(Herbivore h)
		{
			// Eat Bison
			Console.WriteLine($"{GetType().Name} eats {h.GetType().Name}");
		}
	}

	/// <summary>
	/// The 'Client' class 
	/// </summary>
	class AnimalWorld
	{
		public AnimalWorld()
		{
			Console.WriteLine("AnimalWorld.ctor");
		}

		private Herbivore herbivore;
		private Carnivore carnivore;

		// Constructor
		public AnimalWorld(ContinentFactory factory)
		{
			carnivore = factory.CreateCarnivore();
			herbivore = factory.CreateHerbivore();
		}

		public void RunFoodChain()
		{
			carnivore.Eat(herbivore);
		}
	}
}