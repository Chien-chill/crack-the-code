using System.Runtime.CompilerServices;

namespace E_Two_Sum;
public class Program
{
    // ? https://leetcode.com/problems/two-sum/
    public int[] TwoSum(int[] nums, int target)
    {
        //! Way 1 : Brute force   O(n^2)
        /*
        int[] result = new int[2];
        for (int i = 0; i < nums.Length - 1; i++) //! O(n)
        {
            for (int j = i + 1; j < nums.Length; j++) //! O(n)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }
        return result;
        */

        //! Way 2 : Hash Map O(n)
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) //! O(n)
        {
            int check = target - nums[i];
            if (dict.ContainsKey(check))
            {
                return new int[] { dict[check], i };
            }
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        return new int[] { -1, -1 };

    }

    static void Main(string[] args)
    {

    }
}