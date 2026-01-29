using System;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            Console.WriteLine("Họ tên không được để trống!");
            return;
        }
        hoTen = hoTen.Trim();
        string[] tu = hoTen.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < tu.Length; i++)
        {
            string word = tu[i].ToLower();
            tu[i] = char.ToUpper(word[0]) + word.Substring(1);
        }
        string hoTenChuanHoa = string.Join(" ", tu);
        Console.WriteLine("Họ tên sau khi chuẩn hóa:");
        Console.WriteLine(hoTenChuanHoa);
    }
}