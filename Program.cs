
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Bir sayı giriniz: ");
        int n = int.Parse(Console.ReadLine());

        
        int a = 0, b = 1;

        Console.WriteLine("Fibonacci Serisi:");

        
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");

            
            int temp = a + b;
            a = b;
            b = temp;
        }
    }
}
