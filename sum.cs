using System;

public class Sum
{
    public Sum()
    {
        Console.WriteLine("Nhap hai so nguyen de tinh tong cua hai so do:");
        int x, y;
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tong hai so la: " + (x + y));
    }
}

class Program
{
    static void Main()
    {
        Sum sum = new Sum();
    }
}