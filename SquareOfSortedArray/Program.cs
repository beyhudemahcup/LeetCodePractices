
/*
 Given an integer array nums sorted in non-decreasing order, 
return an array of the squares of each number sorted in non-decreasing order.
 */

namespace SquareOfSortedArray
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = {-3, -5, 0,-12, 4, 7, -8};
            int[] sortedSquares = SortedSquares(nums);
            foreach (var i in sortedSquares)
            {
                Console.Write(i + ", ");
            }
        }
        public static int[] SortedSquares(int[] nums)
        {
            int[] sortedSquares = new int[nums.Length];

            //looks every member of the array and takes square of the each member
            for (int i = 0; i < nums.Length; i++)
            {
                sortedSquares[i] += nums[i] * nums[i];
            }

            //sorting and returning the new values
            Array.Sort(sortedSquares);

            return sortedSquares;
        }
    }
}