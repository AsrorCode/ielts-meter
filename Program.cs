using System;
using System.Collections;
using IeltsMeter;

class Program
{
    public static Printer printer = new Printer();

    static void Main()
    {
        StartIeltsMeter();
    }

    static void StartIeltsMeter()
    {

        printer.PrintLine("IELTS Meter ga xush kelibsiz \n");

        string[] skills = { "Speaking", "Reading", "Writing", "Listening" };

        decimal[] scores = new decimal[4];

        for (int i = 0; i < skills.Length; i++)
        {
            scores[i] = GetValidScore(skills[i]);
        }

        decimal overall = CalculateAverage.CalculateAverage1(scores);

        printer.PrintLine($"\n Sizning OVERALL balingiz: {overall}");

        //Loyihadan foydalangan insonga minnatdorchilik sifatidan yozdim
        printer.PrintLine("Bizning loyihamizdan foydalanganingiz uchun roxmat OOKAA");
        

        static decimal GetValidScore(string skillName)
{
    while (true)
    {
        try
        {
            printer.Print($"{skillName} balini kiriting (1 - 9): ");
            string input = Console.ReadLine()!;

            decimal score = decimal.Parse(input);

            if (score < 1 || score > 9)
            {
                DivideByZeroException myAcs = new();
                throw myAcs;
            }

            return score;
        }
        catch (DivideByZeroException)
        {
            printer.PrintLine("Xato: Ball 1 va 9 oralig‘ida bo‘lishi kerak!\n");
        }
        catch
        {
            printer.PrintLine("Xato: Mavjuda bolgan formatni kiriting! Son kiriting.\n");
        }
    }
 }
}
}
      