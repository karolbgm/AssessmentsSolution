namespace Assessments;

internal class Program
{
    static void Main(string[] args)
    {
        //FIZZBUZZ
        for (int i = 1; i < 31; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write(" FIZZBUZZ ");
            } else if (i % 3 == 0)
            {
                Console.Write(" FIZZ ");
            } else if (i % 5 == 0)
            {
                Console.Write(" BUZZ ");
            } else
            {
                Console.Write($" {i} ");
            }
        }

        
    }
}
