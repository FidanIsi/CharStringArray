using Microsoft.VisualBasic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string inputString = Console.ReadLine();
            string cleanedString = inputString.ToLower();

            int vowels = 0;
            int cons = 0;
            int len = cleanedString.Length;

            for (int i = 0; i < len; i++)
            {
                if (cleanedString[i] == 'a' || cleanedString[i] == 'e' || cleanedString[i] == 'i' || cleanedString[i] == 'o' || cleanedString[i] == 'u')
                {
                    vowels++;
                }
                else if (cleanedString[i] >= 'a' && cleanedString[i] <= 'z')
                {
                    cons++;
                }
            }
            
            Console.WriteLine("Total number of vowels in the string :" + vowels);
            Console.WriteLine("Total number of consonants in the string :" + cons);
        }
    }
}