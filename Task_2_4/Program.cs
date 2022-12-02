using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Task_2_4
{
	class Programm
	{
		static void Main(string[] agrs)
		{
			int k = 5;

			for (int i = 6; i <= 10; i++)
			{
				for (int j = 0; j < k; j++)
				{
					Console.Write(i + "\t");
				}

				Console.WriteLine();
				k--;
			}
		}
	}
}