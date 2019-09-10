using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_without_remainder__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());

			double counter2 = 0;
			double counter3 = 0;
			double counter4 = 0;
			double counterTotal = 0;

			for (int i = 1; i <= n; i++)
			{
				int number = int.Parse(Console.ReadLine());

				counterTotal++;

				if (number % 2 == 0)
				{
					counter2++;
				}

				if (number % 3 == 0)
				{
					counter3++;
				}

				if (number % 4 == 0)
				{
					counter4++;
				}
			}

			double p1 = ((counter2 * 1.0) / counterTotal) * 100;
			double p2 = ((counter3 * 1.0) / counterTotal) * 100;
			double p3 = ((counter4 * 1.0) / counterTotal) * 100;

			Console.WriteLine($"{p1:F2}%");
			Console.WriteLine($"{p2:F2}%");
			Console.WriteLine($"{p3:F2}%");
		}
	}
}
