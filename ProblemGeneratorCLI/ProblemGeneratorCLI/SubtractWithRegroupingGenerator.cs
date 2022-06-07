
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
            const int mediumBound = 1000;
            const int lowBound = 100;
            const int numProblems = 10;

            var random = new Random();

            for (var i = 0; i < numProblems; ++i)
            {
                var firstInt = random.Next(lowBound);
                var secondInt = random.Next(lowBound);

                if (firstInt > secondInt)
                    Console.WriteLine($"{firstInt} - {secondInt} = ____ ?");
                else
                    Console.WriteLine($"{secondInt} - {firstInt} = ____ ?");
            }

            for (var i = 0; i < numProblems; ++i)
            {
                var firstInt = random.Next(mediumBound);
                var secondInt = random.Next(mediumBound);

                if (firstInt > secondInt)
                    Console.WriteLine($"{firstInt} - {secondInt} = ____ ?");
                else
                    Console.WriteLine($"{secondInt} - {firstInt} = ____ ?");
            }

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
