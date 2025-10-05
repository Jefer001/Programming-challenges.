
namespace Maximum_Subarray_Sum
{
    public class Methods
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxSoFar = nums[0];
            int maxEndingHere = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }

        public static int MaxSubArray2(int[] nums)
        {
            int maxSum = 0;
            int currentSum = 0;
            foreach (int num in nums)
            {
                currentSum += num;
                if (currentSum < 0) currentSum = 0;
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }
}
