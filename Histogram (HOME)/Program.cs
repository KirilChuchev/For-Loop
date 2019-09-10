using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());

			int counter1 = 0;
			int counter2 = 0;
			int counter3 = 0;
			int counter4 = 0;
			int counter5 = 0;
			int counterTotal = 0;

			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());

				counterTotal++;

				if (number < 200)
				{
					counter1++;
				}
				else if (number >= 200 && number <= 399)
				{
					counter2++;
				}
				else if (number >= 400 && number <= 599)
				{
					counter3++;
				}
				else if (number >= 600 && number <= 799)
				{
					counter4++;
				}
				else if (number >= 800)
				{
					counter5++;
				}

			}

			double p1 = ((counter1 * 1.0) / counterTotal) * 100;
			double p2 = ((counter2 * 1.0) / counterTotal) * 100;
			double p3 = ((counter3 * 1.0) / counterTotal) * 100;
			double p4 = ((counter4 * 1.0) / counterTotal) * 100;
			double p5 = ((counter5 * 1.0) / counterTotal) * 100;

			Console.WriteLine($"{p1:F2}%");
			Console.WriteLine($"{p2:F2}%");
			Console.WriteLine($"{p3:F2}%");
			Console.WriteLine($"{p4:F2}%");
			Console.WriteLine($"{p5:F2}%");
			

		}
	}
}
