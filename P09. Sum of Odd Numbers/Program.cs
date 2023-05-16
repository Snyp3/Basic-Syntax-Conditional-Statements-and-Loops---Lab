namespace P09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double oddNumbersCount = double.Parse(Console.ReadLine());
            float oddNumbersSum = 0;
            for (int i = 1; i <= oddNumbersCount; i++)
            {
                Console.WriteLine("{0} ", 2 * i - 1);
                oddNumbersSum += 2 * i - 1;
            }
            Console.WriteLine($"Sum: {oddNumbersSum}");
        }
    }
}