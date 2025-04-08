namespace _2nd_largest_number;
class Program
{
   // ? Tìm số lớn nhất thứ 2 trong mảng chỉ dùng 1 vòng for
    static void Main(string[] args)
    {
       int[] arr = [1, 4, 6, 4];
       int Max = arr[0];
       int SecondMax = arr[0];
       for(int i = 0; i < arr.Length; i++) //! O(n)
       {
            if(Max < arr[i])
            {
                SecondMax = Max;
                Max = arr[i];
            } 
            else if(arr[i] < Max && arr[i] > SecondMax)
            {
                SecondMax = arr[i];
            }        
       }
       System.Console.WriteLine("Số lớn nhất thứ 2 : "+ SecondMax);
    }
}