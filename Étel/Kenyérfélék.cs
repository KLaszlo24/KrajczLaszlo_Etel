using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Étel
{
	internal class Kenyérfélék : Etel
	{
		public Kenyérfélék(double caloriesPerDkg, double weight, string name, bool isDairyFree) : base(caloriesPerDkg, weight, name)
		{
			IsItDairyFree = isDairyFree;
		}

		public override double CountCalories()
		{
			return (CaloriesPerDkg * Weight) / 100;
		}
	}
}
