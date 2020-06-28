using System;

namespace SumLargeNumberString
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Console.WriteLine($"{Helpers.FuncHelper.Sum("10000000000000000000", "10000000000000000000")}");

            watch.Stop();
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");


        }
    }
}
