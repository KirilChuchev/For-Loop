using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10._02
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i=1; i<=1000; i++)
			{
				if (i%10 == 7)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
