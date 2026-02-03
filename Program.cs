using System;

class Program
{
    static void Main()
    {
        StartIeltsMeter();
    }

    static void StartIeltsMeter()
    {
        Console.WriteLine("IELTS Meter ga xush kelibsiz \n");

        string[] skills = { "Speaking", "Reading", "Listening", "Writing" };
        decimal[] scores = new decimal[4];

        for (int i = 0; i < skills.Length; i++)
        {
            scores[i] = GetValidScore(skills[i]);
        }

        decimal overall = CalculateAverage(scores);

        Console.WriteLine($"\nO‘rta arifmetik: {overall}");
    }

    static decimal GetValidScore(string skillName)
    {
        while (true)
        {
            Console.Write($"{skillName} balini kiriting (0 - 9): ");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal score))
            {
                if (score >= 0 && score <= 9)
                    return score;
            }

            Console.WriteLine(" Noto‘g‘ri ball! Iltimos 0 va 9 oralig‘ida kiriting.\n");
        }
    }

    static decimal CalculateAverage(decimal[] scores)
    {
        decimal sum = 0;

        foreach (decimal score in scores)
        {
            sum += score;
        }

        return sum / scores.Length;
    }
}