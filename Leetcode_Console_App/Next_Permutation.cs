namespace Leetcode_Console_App
{
    internal static class Next_Permutation
    {
        public static void Client()
        {
            int[] inputArr = new int[] { 1, 2, 3 };
            NextPermutation(inputArr);
        }

        // Approach: Single Pass Approach
        public static void NextPermutation(int[] nums)
        {
            int len = nums.Length;
            if (len < 2)
                return;

            int j = len - 2;
            while (j >= 0 && nums[j] >= nums[j + 1])
                j--;
            if (j < 0)
            {
                Reverse(nums, 0, len - 1);
                return;
            }
            int l = len - 1;
            while (nums[j] >= nums[l])
                l--;
            Swap(nums, j, l);
            Reverse(nums, j + 1, len - 1);
        }

        private static void Reverse(int[] arr, int l, int r)
        {
            while (l < r)
            {
                Swap(arr, l, r);
                l++;
                r--;
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
