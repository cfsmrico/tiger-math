
namespace ProblemGeneratorCLI
{
    internal class RoundNumbersGenerator
    {
        static readonly Random random = new();

        internal static void GenerateAndWriteMsg(int roundingTo = 100, int upperBound = 100, int numProblems = 10)
        {

            for (var i = 0; i < numProblems; ++i)
            {
                var x = random.Next(upperBound);
                Console.WriteLine($" What is {x} rounded to the nearest {roundingTo}?");
            }
        }

        internal static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("     Round numbers to nearest 10 and 100");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            GenerateAndWriteMsg(roundingTo: 10, numProblems: 5);
            GenerateAndWriteMsg(roundingTo: 10, numProblems: 5, upperBound: 500);
            GenerateAndWriteMsg(roundingTo: 100, numProblems: 5);
            GenerateAndWriteMsg(roundingTo: 100, numProblems: 5, upperBound: 500);
            GenerateAndWriteMsg(roundingTo: 100, numProblems: 5, upperBound: 1000);
        }
    }
}

