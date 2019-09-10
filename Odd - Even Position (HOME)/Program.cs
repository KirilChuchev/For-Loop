using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd___Even_Position__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			double n = double.Parse(Console.ReadLine());

			
			double sumEven = 0;
			double sumOdd = 0;
			double minEven = double.MaxValue;
			double maxEven = double.MinValue;
			double minOdd = double.MaxValue;
			double maxOdd = double.MinValue;

			for (int i = 1; i <= n; i++)
			{

				double number = double.Parse(Console.ReadLine());	

				if (i % 2 == 0)
				{
					sumEven += number;
					if (number > maxEven)
					{
						maxEven = number;
					}
					if (number < minEven)
					{
						minEven = number;
					}
				}
				else 
				{
					sumOdd += number;
					if (number > maxOdd)
					{
						maxOdd = number;
					}
					if (number < minOdd)
					{
						minOdd = number;
					}
				}


			}

			if (n == 0)
			{
				Console.WriteLine($"OddSum={sumOdd:F2},");
				Console.WriteLine("OddMin=" + "No" + ",");
				Console.WriteLine("OddMax=" + "No" + ",");
				Console.WriteLine($"EvenSum={sumEven:F2},");
				Console.WriteLine("EvenMin=" + "No" + ",");
				Console.WriteLine("EvenMax=" + "No");
			}
			else if (n == 1)
			{
				Console.WriteLine($"OddSum={sumOdd:F2},");
				Console.WriteLine($"OddMin={minOdd:F2},");
				Console.WriteLine($"OddMax={maxOdd:F2},");
				Console.WriteLine($"EvenSum={sumEven:F2},");
				Console.WriteLine("EvenMin=" + "No" + ",");
				Console.WriteLine("EvenMax=" + "No");
			}
			else
			{
				Console.WriteLine($"OddSum={sumOdd:F2},");
				Console.WriteLine($"OddMin={minOdd:F2},");
				Console.WriteLine($"OddMax={maxOdd:F2},");
				Console.WriteLine($"EvenSum={sumEven:F2},");
				Console.WriteLine($"EvenMin={minEven:F2},");
				Console.WriteLine($"EvenMax={maxEven:F2}");

			}
		}
	}
}
