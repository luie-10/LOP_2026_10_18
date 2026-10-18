using System;

class Program
{
    static void Main(string[] args)
    {
        if (!int.TryParse(Console.ReadLine(), out int n)) return;

        string[] inputParts = Console.ReadLine().Split(' ');
        int[] num = new int[n];
        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(inputParts[i]);
        }

        int currentSum = num[0];
        int maxSum = num[0];

        for (int i = 1; i < n; i++)
        {
            if (currentSum + num[i] > num[i])
            {
                currentSum = currentSum + num[i];
            }
            else
            {
                currentSum = num[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        Console.WriteLine(maxSum);
    }
}
