
/*
 Given a fixed-length integer array arr, duplicate each occurrence of zero, 
 shifting the remaining elements to the right.
 */

namespace DublicateZeros
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, -3, -5, 0, -12, 4, 7, -8 };

            int[] arrArranged = DublicateZero(nums);
            foreach (var i in arrArranged)
            {
                Console.Write(i + ", ");
            }
        }
        public static int[] DublicateZero(int[] nums)
        {
            int length = nums.Length;
            int i = 0;

            //for every index, while loop checks if there is any 0 
            while (i < length)
            {
                if (nums[i] == 0)
                {
                    //when we find 0 as a member of an array, we slide every member to the right
                    for (int j = length-1; j > i; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    //give 0 next to the other 0, we found
                    if (i + 1 < length)
                    {
                        nums[i + 1] = 0;
                    }

                    //go to next position(2 because we have double zero next to each other)
                    i += 2;
                    
                }

                else
                {
                    //increase the counter if there is not any 0
                    i++;
                }
            }
            return nums;
        }
    }
}