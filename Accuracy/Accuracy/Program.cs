using System;

namespace Accuracy
{
    class Program
    {
        static void Main(string[] args)
        {
            //*double data type is quicker to execute but less accurate*
            //Console.Clear();
            //double result1 = 0.1 * 7;
            //double result2 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;

            //Console.WriteLine($"1st result is {result1:R}");
            //Console.WriteLine($"2nd result is {result2:R}");

            //double difference = result1 - result2;
            //Console.WriteLine($"The difference is {difference:R}");

            //*decimal data type is more accurate but takes longer to execute*
            Console.Clear();
            decimal result1 = 0.1m * 7m;
            decimal result2 = 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m;

            Console.WriteLine($"1st result is {result1}");
            Console.WriteLine($"2nd result is {result2}");

            decimal difference = result1 - result2;
            Console.WriteLine($"The difference is {difference}");

            bool checkResult = result1 - result2 == 0;
            Console.WriteLine($"The answer is {checkResult}");

        }
    }
}
