
namespace ProblemGeneratorCLI
{
    internal class FourDigitAddWorksheetGenerator
    {
        internal static void Run()
        {
            Console.WriteLine();
            Console.WriteLine(" Add 4-digit numbers worksheet");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            const int upperBound = 10000;
            const int numProblems = 10;

            var random = new Random();

            for (var i = 0; i < numProblems; ++i)
            {
                var firstInt = random.Next(upperBound);
                var secondInt = random.Next(upperBound);
                Console.WriteLine($"{firstInt} + {secondInt} = ____ ?");
            }
        }
    }
}
