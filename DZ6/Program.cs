using System;

class Reverser
{
    static void Main()
    {
        int[] a = { 10, 20, 30, 40, 50 };
        int b = a.Length;
        Console.Write("Исходный массив: ");
        foreach (int c in a)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        int[] d = new int[b];
        for (int i = 0; i < b; i++)
        {
            int f = b - 1 - i;
            d[i] = a[f];
        }
        Console.Write("Перевернутый массив: ");
        foreach (int c in d)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}
