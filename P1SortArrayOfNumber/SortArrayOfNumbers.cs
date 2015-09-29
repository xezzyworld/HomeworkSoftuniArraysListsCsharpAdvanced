using System;

class SortArrayOfNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');
            int[] parsedInput = new int[splittedInput.Length];
            for (int i = 0; i < splittedInput.Length; i++)
            {
                parsedInput[i] = int.Parse(splittedInput[i]);
            }
            Array.Sort(parsedInput);
            Console.WriteLine(string.Join(" ",parsedInput));
        }
    }

