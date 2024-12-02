using System;
using System.Collections.Generic;

class Fibbonaccia
{
    static string Fibb(int length = 3)
    {
        List<int> values = new List<int> { 1, 1 };
        for (int i = 2; i < length; i++)
        {
            int c = values[^1] + values[^2];
            values.Add(c);
        }
        return $"[{string.Join(", ", values)}]";
    }
    static void Main()
    {
        Console.WriteLine(Fibb(20));
    }
}