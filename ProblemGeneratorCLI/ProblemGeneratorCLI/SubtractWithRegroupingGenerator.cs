
namespace ProblemGeneratorCLI
{
    internal class SubtractWithRegroupingGenerator
    {
        internal static void Run()
        {
            Console.WriteLine();
            Console.WriteLine(" Subtract with (possible) regrouping worksheet");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            const int upperBound = 10000;
            const int numProblems = 10;

            var random = new Random();

            for (var i = 0; i < numProblems; ++i)
            {
                var firstInt = random.Next(upperBound);
                var secondInt = random.Next(upperBound);

                if (firstInt > secondInt)
                    Console.WriteLine($"{firstInt} - {secondInt} = ____ ?");
                else
                    Console.WriteLine($"{secondInt} - {firstInt} = ____ ?");
            }
        }
    }
}
