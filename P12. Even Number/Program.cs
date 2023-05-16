namespace P12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i < 100; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    continue;
                }
            }
        }
    }
}