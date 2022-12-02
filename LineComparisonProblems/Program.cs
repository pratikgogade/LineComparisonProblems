using System;

namespace LineComparisonProblems

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L1 = 0, L2 = 0;
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Enter x1:");
                int x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter y1:");
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter x2:");
                int x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter y2:");
                int y2 = Convert.ToInt32(Console.ReadLine());

                double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                if (i == 0)
                {
                    Console.WriteLine("Length Of Line1: " + Length);
                    L1 = Length;
                }
                else
                {
                    Console.WriteLine("Length Of Line2: " + Length);
                    L2 = Length;
                }
            }
            if (L1 == L2)
            {
                Console.WriteLine("Lines Are Equal");
            }
            else if (L1 > L2)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
        }
    }
}