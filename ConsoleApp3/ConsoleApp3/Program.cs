namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string inputString = Console.ReadLine();
            char[] stringArray = inputString.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray).ToUpper();
            Console.WriteLine(reversedString);

        }
    }
}