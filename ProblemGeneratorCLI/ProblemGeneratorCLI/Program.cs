

namespace ProblemGeneratorCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourDigitAddWorksheetGenerator.Run();
            SubtractWithRegroupingGenerator.Run();

            Console.WriteLine();
            Console.WriteLine("DONE");
            Console.WriteLine();
        }
    }
}