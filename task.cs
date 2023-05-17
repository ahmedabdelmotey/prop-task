using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the number of elments");
            int n = int.Parse(Console.ReadLine());
   
            int[] values = new int[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }
            int median = (n % 2 == 0) ? (values[n / 2] + values[n / 2 - 1]) / 2 : values[n / 2];
            Console.WriteLine("The median is {0}", median);          
            int mode = values[0];
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                if (values[i] == mode)
                {
                    count++;
                }
                else if (count > 1)
                {
                    mode = values[i];
                    count = 1;
                }
            }
            Console.WriteLine("The mode is {0}", mode);
            int min = values[0];
            int max = values[0];
            for (int i = 1; i < n; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            int range = max - min;
            Console.WriteLine("The range is {0}", range);           
            int firstQuartile = (n % 2 == 0) ? (values[n / 4] + values[n / 4 - 1]) / 2 : values[n / 4];
            Console.WriteLine("The first Quartile is {0}", firstQuartile);
            int thirdQuartile = (n % 2 == 0) ? (values[3 * n / 4] + values[3 * n / 4 - 1]) / 2 : values[3 * n / 4];
            Console.WriteLine("The third Quartile is {0}", thirdQuartile);
            int p90 = (n % 2 == 0) ? (values[9 * n / 10] + values[9 * n / 10 - 1]) / 2 : values[9 * n / 10];
            Console.WriteLine("The P90 is {0}", p90);
            int interquartileRange = thirdQuartile - firstQuartile;
            Console.WriteLine("The interquartile range is {0}", interquartileRange);
            double lowerOutlierBoundary = firstQuartile - 1.5 * interquartileRange;
            double upperOutlierBoundary = thirdQuartile + 1.5 * interquartileRange;
            Console.WriteLine("The boundaries of the outlier region are {0} and {1}", lowerOutlierBoundary, upperOutlierBoundary);
            int input = int.Parse(Console.ReadLine());
            if (input < lowerOutlierBoundary || input > upperOutlierBoundary)
            {
                Console.WriteLine("The value is an outlier.");
            }
            else
            {
                Console.WriteLine("The value is not an outlier.");
            }

           
        }
    }
    }

