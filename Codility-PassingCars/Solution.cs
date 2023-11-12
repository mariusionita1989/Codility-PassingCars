using System.Runtime.CompilerServices;

namespace Codility_PassingCars
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;
        public const int THRESHOLD = 1000000000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if(N>=RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE)
            {
                int eastCars = 0;
                int passingPairs = 0;
                foreach (int car in A)
                {
                    if (car == 0)
                        eastCars++; // If car is traveling east, increment the count
                    else
                    {
                        // If car is traveling west, it forms passing pairs with all eastward cars
                        passingPairs += eastCars;
                        // Check for the exceeding condition
                        if (passingPairs > THRESHOLD)
                            return -1;
                    }
                }

                return passingPairs;
            }

            return -2;
        }
    }
}
