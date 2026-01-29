using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập chuỗi: ");
        string input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Số từ trong chuỗi: 0");
            return;
        }
        input = input.Trim();
        if (input.Length == 0)
        {
            Console.WriteLine("Số từ trong chuỗi: 0");
            return;
        }
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int count = words.Length;
        Console.WriteLine("Số từ trong chuỗi: " + count);
    }
}