using System;
using System.Collections.Generic;

class LongestIncreasingSeq
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int prev = int.Parse(input[0]);
        int tempcounter = 1;
        int counter = 0;
        int indexOfLongest = 0;
        List<string> sequence = new List<string>();

        for (int i = 1; i < input.Length; i++)
        {
            int next = int.Parse(input[i]);
            if(i+1==input.Length && prev<next)
            {
                tempcounter++;
                Console.Write(prev + " ");
                Console.Write(next);
                if (tempcounter > counter)
                {
                    counter = tempcounter;
                    indexOfLongest = i+1;
                }
                break;
            }
            if(i+1==input.Length && prev>=next)
            {
                Console.WriteLine(next);
                if (tempcounter > counter)
                {
                    counter = tempcounter;
                    indexOfLongest = i+1;
                }
                break;
            }
            if (prev < next)
            {
                tempcounter++;
                Console.Write(prev + " ");
            }
            else
            {
                Console.Write(prev);
                Console.WriteLine();
                if (tempcounter > counter)
                {
                    counter = tempcounter;
                    indexOfLongest = i;
                }
                tempcounter = 1;
            }

            prev = next;

        }
        Console.WriteLine();
        Console.Write("Longest: ");
        for (int i = indexOfLongest - counter; i < indexOfLongest; i++)
        {
            Console.Write(input[i] + " ");
        }
    }
}

