using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			//Q1判斷某數值是不是質數

			Console.WriteLine("請輸入一個數值");
			string input=Console.ReadLine();
			int u1 = Convert.ToInt32(input);

			int count = 0;
			for (int d = 2; d < u1; d++)
			{
				if (u1 % d == 0)
				{
					count = count + 1;
				}
			}
			if (count == 0)
			{
				Console.WriteLine("它是質數" + u1);
			}
			else
			{
				Console.WriteLine("它不是質數"+u1);
			}

			//Q2找出數值區間內的所有質數
				
			for (int i = 2; i <= 50; i++)
			{
			    int count2 = 0;
				for (int f = 2; f < i; f++)
				{
					if (i % f == 0)
					{
						count2=count2 + 1;	
					}
				}
				if (count2 == 0)
				{
					Console.WriteLine(i);
				}
			}

			//Q3
			double n1 = Math.Sqrt(1000);
			double n2 = Math.Ceiling(n1);
			int begin2 = (int)n2;

			double pow = 0;
			string str_pow = "";
			int end = (int)Math.Floor(Math.Sqrt(9999));

			string t1 = "";
			string t2 = "";
			string t3 = "";
			string t4 = "";
			for (int i = begin2; i <= end; i++)
			{
				pow = Math.Pow(i, 2);
				str_pow = pow.ToString();
				t1 = str_pow.Substring(0, 1);
				t2 = str_pow.Substring(1, 1);
				t3 = str_pow.Substring(2, 1);
				t4 = str_pow.Substring(3, 1);
				
				if (t1 == t2 && t3 == t4)
				{
					Console.WriteLine(str_pow);
				}
			}

			//Q4百元買百雞 

			int count3 = 0;
			for (int cock = 1; cock <= 100 / 5; cock++)
			{

				for (int hen = 1; hen <= (100 - 5 * cock) / 3; hen++)
				{
					count3++;
					int chicken = 100 - cock - hen;

					double price = 5 * cock + 3 * hen + (double)chicken / 3.0;
					if (price == 100)
					{
						Console.WriteLine($"公雞{cock}隻,母雞{ hen}隻,小雞{chicken}隻");
					}
				}	
			}
		}
	}
}
