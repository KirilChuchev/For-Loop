using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int totalSum = 0;
			int localSum1 = 0;
			int localSum2 = 0;
			int localSum3 = 0;
			int localSum4 = 0;
			int localSum5 = 0;

			for (int i = 1; i <= n; i++)
			{
				int number = int.Parse(Console.ReadLine());

				if (number < 200)
				{
					localSum1 += 1;
				}
				else if (number >= 200 && number <= 399)
				{
					localSum2 += 1;
				}
				else if (number >= 400 && number <= 599)
				{
					localSum3 += 1;
				}
				else if (number >= 600 && number <= 799)
				{
					localSum4 += 1;
				}
				else if (number >= 800)
				{
					localSum5 += 1;
				}

			}

			double p1 = (localSum1 * 1.0 / n) * 100;
			double p2 = (localSum2 * 1.0 / n) * 100;
			double p3 = (localSum3 * 1.0 / n) * 100;
			double p4 = (localSum4 * 1.0 / n) * 100;
			double p5 = (localSum5 * 1.0 / n) * 100;
			

			Console.WriteLine($"{p1:F2}%");
			Console.WriteLine($"{p2:F2}%");
			Console.WriteLine($"{p3:F2}%");
			Console.WriteLine($"{p4:F2}%");
			Console.WriteLine($"{p5:F2}%");
			
			
		}
	}
}
