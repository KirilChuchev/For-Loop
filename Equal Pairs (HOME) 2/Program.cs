using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs__HOME__2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int sum = 0;
			int sum2 = 0;
			int counter = 0;
			int diff = 0;

			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());
			sum = number1 + number2;

			if (n <= 1)
			{
				Console.WriteLine($"Yes, value={sum}");
			}
			else
			{
				for (int i = 1; i <= n - 1; i++)
				{
					
					number1 = int.Parse(Console.ReadLine());
					number2 = int.Parse(Console.ReadLine());

					sum2 = number1 + number2;

					if (sum != sum2)
					{
						counter++;
					}
					

					if (i == 1)
					{
						diff = Math.Abs(sum2 - sum);
					}

					if (Math.Abs(sum2 - sum) > diff)
					{
						diff = Math.Abs(sum2 - sum);
					}

					
					sum = sum2;
				}

				if (counter == 0)
				{
					Console.WriteLine($"Yes, value={sum}");
				}
				else
				{
					Console.WriteLine($"No, maxdiff={diff}");
				}
			}

			

		}
	}
}
