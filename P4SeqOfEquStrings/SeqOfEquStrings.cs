using System;
using System.Collections.Generic;
using System.Linq;

class SeqOfEquStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<string> inputList = input.ToList();
        int i = input.Length;
        while (i>0)
        {
            string temp = inputList[0];
            while (inputList.Contains(temp))
            {
                Console.Write(temp+" ");
                inputList.Remove(temp);
                i--;
            }
            Console.WriteLine();
        }
    }
}

