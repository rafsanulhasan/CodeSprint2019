using System;

namespace Falguni
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			for (var i = 1; i <= 100; i++)
			{
				if (i > 2)
				{
					var cond1 = i % 3 == 0;
					var cond2 = i % 5 == 0;
					var outout = string.Empty;
					if (cond1 && cond2)
						outout = "Bangladesh";
					else if (cond1)
						outout = "Bangla";
					else if (cond2)
						outout = "Desh";
					else
						outout = $"{i}";
					Console.WriteLine(outout);
				}
				else
				{
					Console.WriteLine(i);
				}
			}

			Console.ReadLine();
		}
	}
}
