public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Brute force method in C#
        for (int i = 0; i < nums.Count(); i++) {
            for (int j = 0; j < nums.Count() && i != j; j++) {
                if (nums[i] + nums[j] == target) {
                    return [i, j];
                }
            }
        }
        return [-1, -1];

        // O(nlogn)
        // int i = 0;
        // int j = nums.Count() - 1;
        // int[] sorted_nums = nums;
        // Array.Sort(sorted_nums);
        // while (i < j) {
        //     int sum = sorted_nums[i] + sorted_nums[j];
        //     if (sum == target) {
        //         break;
        //     }
        //     else if (sum < target) {
        //         i++;
        //     }
        //     else if (sum > target) {
        //         j--;
        //     }
        // }
        // return [Array.Find(nums, sorted_nums[i]), Array.Find(nums, sorted_nums[j])];



        // Dictionary<int, int[]> nums_dict = new Dictionary<int, int[]>();

        // // Add all nums to dictionary
        // int i = 0;
        // foreach (int num in nums) {
        //     try {
        //         nums_dict.Add(num, new int[] { i });
        //     }
        //     catch (ArgumentException) {
        //         // Append num to array
        //         nums_dict[num] = nums_dict[num].Concat(new int[] { i++ }).ToArray();
        //     }
        //     i++;
        // }

        // int[] value = Array.Empty<int>();
        // for (i = 0; i < nums.Length; i++) {
        //     if (nums_dict.TryGetValue(target - nums[i], out value)) {
        //         Console.WriteLine("{0}", value);
        //         if (target - nums[i] != nums[i] || value.Length > 1)
        //             return [i, value[^1]];
        //     }
        // }
        // return [0];
    }
}