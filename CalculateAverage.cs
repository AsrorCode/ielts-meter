namespace IeltsMeter
{
    public static class CalculateAverage
    {
        public static decimal CalculateAverage1(decimal[] scores)
        {
            decimal sum = 0;

            foreach (decimal score in scores)
            {
                sum += score;
            }

            return sum / scores.Length;
        }
    }
}