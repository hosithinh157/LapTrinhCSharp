using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số phần tử n: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Mảng rỗng, không xử lý");
            return;
        }
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        if (arr == null)
        {
            Console.WriteLine("Mảng null, không xử lý");
            return;
        }
        if (arr.Length == 0)
        {
            Console.WriteLine("Mảng rỗng, không xử lý");
            return;
        }
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Giá trị lớn nhất trong mảng là: " + max);
    }
}
