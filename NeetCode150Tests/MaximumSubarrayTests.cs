using NeetCode150;

namespace NeetCode150Tests
{
    public class MaximumSubarrayTests
    {
        private MaximumSubarray maximumSubarray = new MaximumSubarray();
        [Fact]
        public void Test_Example1_PositiveAndNegativeNumbers()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int expected = 6;

            Assert.Equal(expected, maximumSubarray.MaxSubArray(nums));
        }

        [Fact]
        public void Test_Example2_SingleElementArray()
        {
            int[] nums = { 1 };
            int expected = 1;

            Assert.Equal(expected, maximumSubarray.MaxSubArray(nums));
        }

        [Fact]
        public void Test_Example3()
        {
            int[] nums = { 5, 4, -1, 7, 8 };
            int expected = 23;

            Assert.Equal(expected, maximumSubarray.MaxSubArray(nums));
        }

        [Fact]
        public void Test_AllNegative()
        {
            int[] nums = { -2, -1, -3, -4, -5 };
            int expected = -1;

            Assert.Equal(expected, maximumSubarray.MaxSubArray(nums));
        }
    }
}