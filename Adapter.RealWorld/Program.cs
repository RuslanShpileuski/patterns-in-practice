using System;

namespace Adapter.RealWorld
{
	/// <summary>
	/// Program startup class for Real-World 
	/// Adapter Design Pattern.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			// Non-adapted chemical compound
			Compound unknown = new Compound("Unknown");
			unknown.Display();

			// Adapted chemical compounds
			Compound water = new RichCompound("Water");
			water.Display();

			Compound benzene = new RichCompound("Benzene");
			benzene.Display();

			Compound ethanol = new RichCompound("Ethanol");
			ethanol.Display();
		}
	}

	/// <summary>
	/// The 'Target' class
	/// </summary>
	class Compound
	{
		protected string chemical;
		protected float boilingPoint;
		protected float meltingPoint;
		protected double molecularWeight;
		protected string molecularFormula;

		// Constructor
		public Compound(string chemical)
		{
			this.chemical = chemical;
		}

		public virtual void Display()
		{
			Console.WriteLine("\nCompound: {0} ------ ", chemical);
		}
	}

	/// <summary>
	/// The 'Adapter' class
	/// </summary>
	class RichCompound : Compound
	{
		private ChemicalDatabank bank;

		// Constructor
		public RichCompound(string name)
		  : base(name)
		{
		}

		public override void Display()
		{
			// The Adaptee
			this.bank = new ChemicalDatabank();

			this.boilingPoint = this.bank.GetCriticalPoint(chemical, "B");
			this.meltingPoint = this.bank.GetCriticalPoint(chemical, "M");
			this.molecularWeight = this.bank.GetMolecularWeight(chemical);
			this.molecularFormula = this.bank.GetMolecularStructure(chemical);

			base.Display();
			Console.WriteLine(" Formula: {0}", this.molecularFormula);
			Console.WriteLine(" Weight : {0}", this.molecularWeight);
			Console.WriteLine(" Melting Pt: {0}", this.meltingPoint);
			Console.WriteLine(" Boiling Pt: {0}", this.boilingPoint);
		}
	}

	/// <summary>
	/// The 'Adaptee' class
	/// </summary>
	class ChemicalDatabank
	{
		// The databank 'legacy API'
		public float GetCriticalPoint(string compound, string point)
		{
			// Melting Point
			if (point == "M")
			{
				switch (compound.ToLower())
				{
					case "water": return 0.0f;
					case "benzene": return 5.5f;
					case "ethanol": return -114.1f;
					default: return 0f;
				}
			}
			// Boiling Point
			else
			{
				switch (compound.ToLower())
				{
					case "water": return 100.0f;
					case "benzene": return 80.1f;
					case "ethanol": return 78.3f;
					default: return 0f;
				}
			}
		}

		public string GetMolecularStructure(string compound)
		{
			switch (compound.ToLower())
			{
				case "water": return "H20";
				case "benzene": return "C6H6";
				case "ethanol": return "C2H5OH";
				default: return string.Empty;
			}
		}

		public double GetMolecularWeight(string compound)
		{
			switch (compound.ToLower())
			{
				case "water": return 18.015;
				case "benzene": return 78.1134;
				case "ethanol": return 46.0688;
				default: return 0d;
			}
		}
	}
}