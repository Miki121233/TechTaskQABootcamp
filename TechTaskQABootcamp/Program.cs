namespace TechTaskQABootcamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu.Init();
            int outputNumber;
        tryAgain:
            try
            {
                Console.Write("\nSelect your output:\n1. Full output, 2. Rounded Full Output: ");
                outputNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input, try again!");
                goto tryAgain;
            }
            Menu.Output(outputNumber);

        }
    }
}