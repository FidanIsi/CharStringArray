namespace ConsoleApp1
{
    internal class Program
    {
        //Exercise 1
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int wordsCount = words.Length;
            Console.WriteLine("Total number of words in the string is : " + wordsCount);
        }
    }
}