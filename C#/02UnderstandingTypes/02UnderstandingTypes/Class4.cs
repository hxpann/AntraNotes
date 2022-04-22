using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
	public class CountTo24Program
    {
		public static void CountTo24()
		{
			for (int countBase = 1; countBase <= 24; countBase += 1)
			{
				Console.Write(countBase.ToString().PadLeft(4) + "|");
				for (int countUp = 0; countUp <= 24; countUp += countBase)
				{
					Console.Write(countUp.ToString().PadLeft(4));
				}

				Console.WriteLine();
			}
		}
	}
}
