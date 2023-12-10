
/*
 Given an array nums of integers, return how many of them contain an even number of digits.
 */

namespace FindEvenNumberInArray
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 123, 5435, 6352343, 123123, 32, 43 };

            Console.WriteLine(FindNumbers(nums));
        }
        public static int FindNumbers(int[] nums)
        {
            int count = 0;

            foreach (var num in nums)
            {
                int digitCount = 0;

                int absNum = Math.Abs(num);
                
                while(absNum > 0) 
                {
                    absNum /= 10;
                    digitCount++;
                }
                if (digitCount % 2 == 0)
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}