public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++) 
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        throw new System.Exception("No two sum solution");
    }
    public static void Main() 
    {
        int[] nums = new int[] { 2, 3, 4, 6};
        int target = 9;

        Solution solution = new Solution(); 
        int[] result = solution.TwoSum(nums, target); 
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }
}