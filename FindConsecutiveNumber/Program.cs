/*
 Given a binary array nums, return the maximum number of consecutive 1's in the array.
 */

namespace FindConsecutiveNumber
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 1, 1, 2, 4, 4, 4, 4, 4 };

            Console.WriteLine(FindMaxConsecutiveOnes(nums));
        }
        public static int FindMaxConsecutiveOnes(int[] nums)
        {

            int maxConsecutiveNumber = 0;
            int currentConsecutiveNumber = 0;

            foreach (var i in nums)
            {
                if (i == 1)
                {
                    maxConsecutiveNumber++;
                    maxConsecutiveNumber = Math.Max(maxConsecutiveNumber, currentConsecutiveNumber);
                }
                else
                {
                    currentConsecutiveNumber = 0;
                }
            }

            return maxConsecutiveNumber;
        }
    }
}
