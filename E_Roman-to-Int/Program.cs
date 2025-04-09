namespace E_Roman_to_Int;

class Program
{
    public int RomanToInt(string s)
    {
        //? https://leetcode.com/problems/roman-to-integer
        //! O(n) dựa vào độ dài chuỗi s
        int num = 0;
        Dictionary<char, int> dicRoman = new Dictionary<char, int>()
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000},
        };
        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && dicRoman[s[i]] < dicRoman[s[i + 1]])
            {
                num += (dicRoman[s[i + 1]] - dicRoman[s[i]]);
                i = i + 1;
            }
            else
            {
                num += dicRoman[s[i]];
            }
        }
        return num;
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        System.Console.WriteLine(program.RomanToInt("III"));

    }
}
