using System.ComponentModel;

namespace E_palindrome_number;

class Program
{
    //? https://leetcode.com/problems/palindrome-number/
    public bool IsPalindrome(int x)
    {
        if (x < 0) { return false; }


        //! Way 1 : Chuyển thành chuỗi rồi đảo ngược O(log n)
        /*
        string original = x.ToString();
        string reversed = new string(original.Reverse().ToArray());
        return original == reversed;
        */

        //! Way 2 : Sử dụng phép chia, phép dư O(log n)
        int cop = x;
        int reversed = 0;
        while (cop != 0)
        {
            int temp = cop % 10;
            reversed = reversed * 10 + temp;
            cop = cop / 10;
        }
        return reversed == x;

    }
    static void Main(string[] args)
    {
        Program program = new Program();
        System.Console.WriteLine(program.IsPalindrome(1221));
    }
}
