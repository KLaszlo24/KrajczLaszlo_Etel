namespace Étel
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Etel> etterem = new List<Etel>
			{
				new Levesek(2.2, 300, "FinomLeves", true),
				new Levesek(3.2, 400, "Kisleves", false),
				new Levesek(1.2, 100, "Jóleves", false),

				new Kenyérfélék(11.5, 400, "Fehérkenyér", false),
				new Kenyérfélék(5.2, 400, "Barnakenyér", true),
				new Kenyérfélék(1.0, 400, "Jókenyér", false),

				new SültHúsok(10.2, 100, "Csirkemell", false),
				new SültHúsok(2.2, 150, "Borjú", false),
				new SültHúsok(9.1, 160, "Nyúl", false),
			};

		}

		public double totalCalories(List<Etel> etterem)
		{
			double total = 0;
			for (int i = 0; i < etterem.Count; i++)
			{
				total += etterem[i].CaloriesPerDkg;
                Console.WriteLine($"Maximum kcal: {total}");
                return total;
			}
			return 0;
		}
	}
}
