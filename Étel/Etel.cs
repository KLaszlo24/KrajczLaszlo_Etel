using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Étel
{
	internal abstract class Etel
	{
		 double caloriesPerDkg;
		 double weight;
		 string name;
		public bool IsItDairyFree { get; set; }
		public double CaloriesPerDkg { get => caloriesPerDkg; set => caloriesPerDkg = value; }
		public double Weight { get => weight; set => weight = value; }
		public string Name { get => name; set => name = value; }

		public abstract double CountCalories();
		
		

		protected Etel(double caloriesPerDkg, double weight, string name)
		{
				this.caloriesPerDkg = caloriesPerDkg;
				this.weight = weight;
				this.name = name;
				IsItDairyFree = false;
		}
	}
}
