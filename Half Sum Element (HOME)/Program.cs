using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int maxNumber = int.MinValue;
			int sumNumbers = 0;
			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				if (number > maxNumber )
				{
					maxNumber = number;
				}
				sumNumbers += number;

			}


			if (maxNumber == sumNumbers - maxNumber)
			{
				Console.WriteLine("Yes");
				Console.WriteLine($"Sum = {maxNumber}");
			}
			else
			{
				Console.WriteLine("No");
				Console.WriteLine($"Diff = {Math.Abs(maxNumber - (sumNumbers - maxNumber))}");
			}
		}
	}
}
