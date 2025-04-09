namespace E_SearchInsert;

class Program
{
    //? https://leetcode.com/problems/search-insert-position
    //TODO binary search 0(log n)
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                return mid;
            }
        }
        return left;
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        int[] nums = [1, 3, 5, 6];
        System.Console.WriteLine(program.SearchInsert(nums, 4));
    }
}
