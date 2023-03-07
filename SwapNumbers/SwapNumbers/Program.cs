namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two a number");

            string inputOne = Console.ReadLine();           
            string inputTwo = Console.ReadLine();

            int parsedNumOne;
            int parsedNumTwo;

            bool parsedResultOne = int.TryParse(inputOne, out parsedNumOne);
            bool parsedResultTwo = int.TryParse(inputTwo, out parsedNumTwo);
            
            Console.WriteLine($"The first number is {parsedNumOne} and the second number is {parsedNumTwo}");
            
            parsedNumOne = parsedNumOne + parsedNumTwo;
            parsedNumTwo = parsedNumOne - parsedNumTwo;
            parsedNumOne = parsedNumOne - parsedNumTwo;

            Console.WriteLine($"After swapping the first number is {parsedNumOne} and the second number is {parsedNumTwo}");
        }
    }
}