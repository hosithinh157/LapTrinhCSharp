using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine();
        if (hoTen == null)
        {
            Console.WriteLine("Chuỗi null, không tách");
            return;
        }
        hoTen = hoTen.Trim();
        string[] arr = hoTen.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (arr == null)
        {
            Console.WriteLine("Mảng kết quả null, không in");
            return;
        }
        Console.WriteLine("Các từ trong họ tên:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}