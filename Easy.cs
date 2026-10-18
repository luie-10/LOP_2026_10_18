using System;
using System.Collections.Generic;
using System.Linq;

class Easy
{
    static void Main()
    {
        if (!int.TryParse(Console.ReadLine(), out int n)) return;

        Dictionary<string, int> studentDict = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            string name = parts[0];
            int score = int.Parse(parts[1]);

            studentDict[name] = score;
        }

        List<KeyValuePair<string, int>> sortedStudents = studentDict
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToList();

        int rank = 1;
        int count = 0;
        int previousScore = -1;

        foreach (KeyValuePair<string, int> student in sortedStudents)
        {
            count++;

            if (student.Value != previousScore)
            {
                rank = count;
            }

            Console.WriteLine($"{student.Key} {student.Value} {rank}");
            previousScore = student.Value;
        }
    }
}
