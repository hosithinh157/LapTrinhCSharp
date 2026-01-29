using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Nhập số phần tử
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        // 2. Khai báo mảng
        string[] arr = null;

        // Nếu n <= 0 thì mảng null
        if (n <= 0)
        {
            Console.WriteLine("Mảng null hoặc rỗng, số chuỗi hợp lệ = 0");
            return;
        }

        // 3. Khởi tạo mảng
        arr = new string[n];

        // 4. Nhập từng phần tử
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = Console.ReadLine(); // có thể là null hoặc ""
        }

        // 5. Check mảng null
        if (arr == null)
        {
            Console.WriteLine("Mảng null, số chuỗi hợp lệ = 0");
            return;
        }

        // 6. Đếm số chuỗi khác null và khác rỗng
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != null && arr[i] != "")
            {
                count++;
            }
        }

        // 7. In kết quả
        Console.WriteLine("Số chuỗi khác null và khác rỗng là: " + count);
    }
}