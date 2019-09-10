using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());
			double salary = double.Parse(Console.ReadLine());
			bool lostSalary = false;


			for (int i = 1; i <= n; i++)
			{
				string site = Console.ReadLine();
				site = site.ToLower();

				switch (site)
				{
					case "facebook":
						{
							salary -= 150;
							if (salary <= 0)
							{
								lostSalary = true;
								break;
							}
						}
						break;
					case "instagram":
						{
							salary -= 100;
							if (salary <= 0)
							{
								lostSalary = true;
								break;
							}
						}
						break;
					case "reddit":
						{
							salary -= 50;
							if (salary <= 0)
							{
								lostSalary = true;
								break;
							}
						}
						break;
				}


				if (lostSalary)
				{
					i = n + 1;
				}
			}

			if (lostSalary)
			{
				Console.WriteLine("You have lost your salary.");
			}
			else
			{
				int remainder = (int)salary;
				Console.WriteLine(remainder);
			}




			
		}




	}
}
