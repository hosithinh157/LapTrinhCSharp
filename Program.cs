using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] arr = null;
        Console.Write("Nhập số phần tử n: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Số phần tử phải lớn hơn 0!");
            return;
        }
        arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        if (arr == null)
        {
            Console.WriteLine("Mảng chưa được khởi tạo!");
            return;
        }
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Tổng các phần tử trong mảng = " + sum);
    }
}