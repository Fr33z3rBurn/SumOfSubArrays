using System;

namespace SumOfSubArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] testArray = new int[] { 34, -50, 42, 14, -5, 86 };
			GetMaxSum(testArray);
		}

		public static int GetMaxSum(int[] intArray)
		{
			int highestSum = 0;
			int candidate = 0;
			

			for (int i = 0; i < intArray.Length; i++)
			{
				for (int j = 0; j < intArray.Length; j++)
				{
					for (int k = i; k <= j; k++)
					{
						candidate += intArray[k];
					}

					if(candidate > highestSum)
					{
						highestSum = candidate;
					}

					candidate = 0;
				}
			}

			return highestSum;
		}
	}
}
