using System;
using IeltsMeter;

class Program
{ public static Printer  printer=new Printer();

    static void Main()
    {
        StartIeltsMeter();
    }

    static void StartIeltsMeter()
    {
        
       printer.PrintLine("IELTS Meter ga xush kelibsiz \n");

        string[] skills = { "Speaking", "Reading", "Listening", "Writing" };
        decimal[] scores = new decimal[4];

        for (int i = 0; i < skills.Length; i++)
        {
            scores[i] = GetValidScore(skills[i]);
        }

        decimal overall = CalculateAverage.CalculateAverage1(scores);

        printer.PrintLine($"\n O‘rta arifmetik: {overall}");
    }

    static decimal GetValidScore(string skillName)
    {
        while (true)
        {
            printer.Print($"{skillName} balini kiriting (0 - 9): ");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal score))
            {
                if (score >= 0 && score <= 9)
                    return score;
            }

            printer.PrintLine(" Notogri ball! Iltimos 0 va 9 oraligida kiriting.\n");
        }
    }


    
        
   
}