namespace Top10_largest_number;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = [4, 1, 3, 5, 2, 4, 7, 3, 9, 6, 10, 11, 11, 12, 13];
        Array.Sort(arr); //! O(n logn)
        Array.Reverse(arr); //! O(n)
        int[] top10 = arr.Distinct().Take(10).ToArray();
        for (int i = 0; i < top10.Length; i++)
        {
            System.Console.Write(top10[i] + " ");
        }
    }
}