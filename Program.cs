using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập câu: ");
        string input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Chuỗi null, không xử lý");
            return;
        }
        input = input.Trim();
        if (input.Length == 0)
        {
            Console.WriteLine("Chuỗi rỗng, không có từ để xử lý");
            return;
        }
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string tuDaiNhat = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > tuDaiNhat.Length)
            {
                tuDaiNhat = words[i];
            }
        }
        Console.WriteLine("Từ dài nhất trong câu là: " + tuDaiNhat);
        Console.WriteLine("Độ dài: " + tuDaiNhat.Length);
    }
}