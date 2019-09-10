using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			//double sumMax = double.MinValue;
			double sum1 = 0;
			double sum2 = 0;
			double diff1 = 0;
						
			double maxDiff = 0;
			bool equalPairs = false;

			for (int i = 1; i <= n; i++)
			{
				
				
				

					sum2 = sum1;
					sum1 = 0;
					for (int j = 1; j <= 2; j++)
					{

						double number1 = double.Parse(Console.ReadLine());
						sum1 += number1;
					}

					if (i > 1)
					{
						maxDiff = diff1;
						diff1 = Math.Abs(sum1 - sum2);
					}
					


					if (diff1 >= maxDiff)
					{
						maxDiff = diff1;
					}
					else { }
					else if (sum1 == sum2)
					{
						equalPairs = true;
					}


				

				

			}

			


			if (equalPairs || n == 1)
			{
				Console.WriteLine($"Yes, value ={sum1:F2}");
			}
			else
			{
				Console.WriteLine($"No, maxdiff ={maxDiff:F2}");
			}

		}
	}
}
