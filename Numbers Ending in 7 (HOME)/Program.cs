using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Ending_in_7__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = 0;

			for (int i = 1; i <= 1_000; i++)
			{
				number = i % 10;
				if (number == 7)
				{
					Console.WriteLine(i);
				}
				
			}


		}
	}
}
