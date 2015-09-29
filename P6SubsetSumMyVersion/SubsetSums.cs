using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse)).Distinct().ToList();
        double maxSubsets = Math.Pow(2, numbers.Count);  // 2^n = maximal possible subsets, where 'n' is the count of elements in the set
        bool checkIfMatching = false;
        for (int i = 0; i < maxSubsets; i++)
        {
            List<int> tempSubset = new List<int>();
            int bitmask = i;
            int pos = numbers.Count - 1;
            while (bitmask > 0)
            {
                if ((bitmask & 1) == 1)
                {
                    tempSubset.Add(numbers[pos]);
                }
                pos--;
                bitmask = bitmask >> 1;
            }
            int sum = tempSubset.Sum();
            tempSubset.Reverse(); // reverse because i start from the last element in the set

            if (sum == n && tempSubset.Count != 0)
            {
                Console.WriteLine(String.Join(" + ", tempSubset) + " = " + n);
                checkIfMatching = true;
            }
        }
        if(checkIfMatching == false)
        {
            Console.WriteLine("No matching subsets.");
        }
        
    }
}

