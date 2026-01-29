using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số phần tử n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = null;
        if (n <= 0)
        {
            Console.WriteLine("Số phần tử chẵn trong mảng: 0");
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
            Console.WriteLine("Số phần tử chẵn trong mảng: 0");
            return;
        }
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("Số phần tử chẵn trong mảng: " + count);
    }
}