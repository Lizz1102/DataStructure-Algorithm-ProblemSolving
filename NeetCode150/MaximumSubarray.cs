﻿namespace NeetCode150
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSoFar = nums[0];
            int maxEndingHere = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(maxEndingHere + nums[i], nums[i]);

                maxSoFar = Math.Max(maxSoFar, maxEndingHere);

            }
            return maxSoFar;
        }
    }
}
