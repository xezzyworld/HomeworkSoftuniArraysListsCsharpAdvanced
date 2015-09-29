using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse)).Distinct().ToList();

        double max = Math.Pow(2, numbers.Count);

        List<List<int>> listOfSubsets = new List<List<int>>();

        for (int i = 0; i < max; i++)
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
            if (sum == n && tempSubset.Count != 0)
            {
                listOfSubsets.Add(tempSubset);
            }
        }

        if (listOfSubsets.Count == 0)
        {
            Console.WriteLine("No matching subsets.");
        }

        else
        {
            int maxCount = 0;
            for (int i = 0; i < listOfSubsets.Count; i++)
            {
                if (maxCount < listOfSubsets[i].Count)
                {
                    maxCount = listOfSubsets[i].Count;
                }

            }

            List<List<int>> sortedSubset = new List<List<int>>();

            for (int i = 0; i <= maxCount; i++)
            {
                List<List<int>> temp = new List<List<int>>();

                for (int g = 0; g < listOfSubsets.Count; g++)
                {
                    if (listOfSubsets[g].Count == i)
                    {
                        temp.Add(listOfSubsets[g]);
                    }
                }

                for (int g = 0; g < temp.Count; g++)
                {
                    int tempMin = temp[g].Min();
                    int tempPos = g;
                    for (int z = g; z < temp.Count; z++)
                    {
                        if (tempMin > temp[z].Min())
                        {
                            tempMin = temp[z].Min();
                            tempPos = z;
                        }
                    }
                    List<int> forReplace = temp[tempPos];
                    if (tempPos != g)
                    {
                        temp[tempPos] = temp[g];
                        temp[g] = forReplace;
                    }
                }
                sortedSubset.AddRange(temp);
            }

            foreach (var item in sortedSubset)
            {
                item.Sort();
                Console.WriteLine(String.Join(" + ", item) + " = " + n);
            }


        }
    }
}
