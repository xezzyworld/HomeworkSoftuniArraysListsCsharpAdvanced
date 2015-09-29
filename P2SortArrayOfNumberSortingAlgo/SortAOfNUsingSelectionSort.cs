using System;

class SortAOfNUsingSelectionSort
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
            for (int i = 0; i < parsedInput.Length; i++)
            {
                int minValue = parsedInput[i];
                int minPos = i;
                for (int c = i+1 ; c < parsedInput.Length; c++)
                {
                    if (minValue > parsedInput[c])
                    {
                        minValue = parsedInput[c];
                        minPos = c;
                    }

                }
                if (parsedInput[i] != minValue)
                {
                    parsedInput[minPos] = parsedInput[i];
                    parsedInput[i] = minValue;
                }
            }
            Console.WriteLine(string.Join(" ", parsedInput));
        }
    }

