using System;
using System.Collections.Generic;
using System.Linq;

    class CategorizeNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> intList = new List<int>();
            List<double> doubleList = new List<double>();
            for (int i = 0; i < input.Length; i++)
            {
                double tempNumber = double.Parse(input[i]);
                if (tempNumber - (int)tempNumber != 0)
                {
                    doubleList.Add(tempNumber);
                }
                else
                {
                    intList.Add((int)tempNumber);
                }
            }
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4}",
                string.Join(", ",intList),intList.Min(),intList.Max(),intList.Sum(),intList.Average());
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4}", 
                string.Join(", ", doubleList), doubleList.Min(), doubleList.Max(), doubleList.Sum(), doubleList.Average());
        }
    }

