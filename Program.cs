namespace Topic_8___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment One

            bool done = true;

            int listSize, maxNum, minNum;
            Random generator = new Random();

            List<string> colour = new List<string>();

            List<int> numbers = new List<int>();

            Console.WriteLine("How many colours do you have?");
            while (!int.TryParse(Console.ReadLine(), out listSize) || listSize < 0)
            {
                Console.WriteLine("Please try again!");
            }


            for (int i = 0; i <= listSize; i++)
            {
                Console.WriteLine("Please enter colour");
                colour.Add(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine(string.Join(", ", colour));
            Console.WriteLine();
            Console.WriteLine(colour[generator.Next(colour.Count)]);
            Console.WriteLine();

            //Assignment two

            Console.WriteLine("How many numbers do you have?");
            while (!int.TryParse(Console.ReadLine(), out listSize) || listSize < 0)
            {
                Console.WriteLine("Please try again!");

            }

            Console.WriteLine("What is your smallest number?");
            while (!int.TryParse(Console.ReadLine(), out minNum))
            {
                Console.WriteLine("Please try again!");

            }


            Console.WriteLine("What is your largest number?");
            while (!int.TryParse(Console.ReadLine(), out maxNum) || maxNum < minNum)
            {
                Console.WriteLine("Please try again!");
            }


            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine(numbers[generator.Next(numbers.Count)]);
            }
        }
    }
}
