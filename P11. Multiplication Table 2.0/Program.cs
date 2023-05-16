namespace P11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int timesTable = 0;

            
            if(times > 10)
            {
                timesTable = number * times;
                Console.WriteLine($"{number} X {times} = {timesTable}");

            }
            for (int i = times; i <= 10; i++)
            {
                
                timesTable = number * times;
                Console.WriteLine($"{number} X {times} = {timesTable}");
                times++;
            }
        }
    }
}