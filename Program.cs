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
            Console.WriteLine("Chuỗi không đối xứng");
            return;
        }
        string chuoiXuLy = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                chuoiXuLy += input[i];
            }
        }
        bool laDoiXung = true;
        int left = 0;
        int right = chuoiXuLy.Length - 1;
        while (left < right)
        {
            if (chuoiXuLy[left] != chuoiXuLy[right])
            {
                laDoiXung = false;
                break;
            }
            left++;
            right--;
        }
        if (laDoiXung)
        {
            Console.WriteLine("Chuỗi đối xứng");
        }
        else
        {
            Console.WriteLine("Chuỗi không đối xứng");
        }
    }
}