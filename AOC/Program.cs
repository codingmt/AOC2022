﻿namespace AOC;
internal class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        var day = new Day13();
        day.Run1();
        Console.WriteLine();
        day.Run2();
        Console.WriteLine();
    }
}