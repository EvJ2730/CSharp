using System;

namespace funWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            FunWithStrings();
        }

        static void FunWithStrings()
        {
            //user input
            Console.WriteLine("Enter a string");
            string userString = Console.ReadLine();

            //reverse string
            char[] charsFromString = userString.ToCharArray();
            Array.Reverse(charsFromString);
            string reverse = new string(charsFromString);

            //total sum of vowels
            int vowel = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == 'a' || userString[i] == 'e' || userString[i] == 'i' || userString[i] == 'o' || userString[i] == 'u' || userString[i] == 'A' || userString[i] == 'E' || userString[i] == 'I' || userString[i] == 'O' || userString[i] == 'U')
                {
                    vowel++;
                }

            }

            //lagest word
            string[] longestWord = userString.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int charachter = 0;
            foreach (String strings in longestWord)
            {
                if (strings.Length > charachter)
                {
                    word = strings;
                    charachter = strings.Length;
                }
            }

            //smallest word


            //count of words
            int wordCount = 0;
            for (int i = 0; i < userString.Length - 1; i++)
            {
                if (userString[i] == ' ' && Char.IsLetter(userString[i + 1]) && i > 0)
                {
                    wordCount++;

                }
            }
            wordCount++;



            Console.WriteLine("---------------------------");
            Console.WriteLine(reverse + " : This is the revesed string");//reverse string
            Console.WriteLine(vowel + " : This is the number of vowels in the string");//total numbers of vowels

            //palindrom check
            if (userString.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not a palindrome");
            }

            //most used character
            char[] charCount = new char[256];
            char mostUsedChar = ' ';
            int length = userString.Length;
            int maxCount = -1;
            for (int i = 0; i < length; i++)
            {
                charCount[userString[i]]++;
                if (maxCount < charCount[userString[i]])
                {
                    maxCount = charCount[userString[i]];
                    mostUsedChar = userString[i];
                }
            }


            Console.WriteLine(word + " : This is the largest word");//largest word
            //Console.WriteLine( + "This is the smallest word in the string");//smallest word // ne znam kako da napravam da raboti 
            Console.WriteLine(wordCount + " : This is the number of words");//count of words
            Console.WriteLine(mostUsedChar + " : This is the most used character : " + maxCount + $" : This is how many times the {mostUsedChar} is used");//most used character
        }
    }
}
