using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringExercises
{
    class Program
    {
        #region String Functionality

        static void lengthOfString()
        {
            int count = 0;
            Console.WriteLine("Enter a string");
            string getString = Console.ReadLine();

            for (int lengthCount = 0; getString.Count() > lengthCount; lengthCount++)
            {
                count++;
            }
            Console.WriteLine("Length of string is - {0}", count);
        }

        static void copyString()
        {
            string getString = string.Empty;
            char[] StringCopy = new char[50];
            int lengthCount;

            Console.WriteLine("Enter a string");
            getString = Console.ReadLine();

            for (lengthCount = 0; getString.Count() > lengthCount; lengthCount++)
            {
                StringCopy[lengthCount] = getString[lengthCount];
            }
            Console.WriteLine("Length of string is - {0}", lengthCount);
            Console.WriteLine("Copied string is - {0}", StringCopy);
        }

        static void ConcatenateString()
        {
            int size = 20;
            int lengthCount;
            char[] firstString = new char[size];

            Console.WriteLine("Enter first string");
            string firstStringScan = Console.ReadLine();

            for (int m = 0; firstStringScan.Count() > 0 && m < firstStringScan.Count(); m++)
            {
                firstString[m] = firstStringScan[m];
            }

            Console.WriteLine("Enter second string");
            string secondString = Console.ReadLine();
            int firstStringCount = 0;
            for (int i = 0; firstString[i] != '\0'; i++)
            {
                firstStringCount++;
            }

            int firstStringlength = firstStringCount;
            int startIndex = firstStringlength;

            for (lengthCount = 0; secondString.Count() > lengthCount; lengthCount++)
            {
                firstString[startIndex] = secondString[lengthCount];
                startIndex++;
            }
            Console.WriteLine("Length of string is - {0}", lengthCount);
            Console.WriteLine("Concatenated string is - ");
            for (int i = 0; i < firstString.Length && firstString[i] != '\0'; i++)
            {
                Console.Write(firstString[i]);
            }
        }

        static void Compare2Strings()
        {
            Console.WriteLine("Enter first string");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter second string");
            string secondString = Console.ReadLine();

            char[] charFirst = new char[20];
            char[] charSecond = new char[20];
            int i = 0;

            for (int m = 0; firstString.Count() > 0 && m < firstString.Count(); m++)
            {
                charFirst[m] = firstString[m];
            }

            for (int m = 0; secondString.Count() > 0 && m < secondString.Count(); m++)
            {
                charSecond[m] = secondString[m];
            }

            for (i = 0; i < firstString.Length && i < secondString.Length; i++)
            {
                if (charFirst[i] == charSecond[i])
                {
                    if (charFirst[i] == '\0' && charSecond[i] == '\0')
                        break;
                }
                else
                {
                    break;
                }
            }
            int res = charFirst[i] - charSecond[i];

            if (res == 0)
            {
                Console.WriteLine("\nString 1 - {0}\nString 2 - {1} \nBoth are equal", firstString, secondString);
            }
            else if (res < 0)
            {
                Console.WriteLine("First string is lexicographically smaller than second.");
            }
            else
            {
                Console.WriteLine("First string is lexicographically greater than second.");
            }

            List<string> collectin = new List<string>();
            collectin.Add("string1");
            collectin.Add("astring2");
            IEnumerable<string> b = new List<string>();
            b = collectin.Where(co => co.StartsWith("a"));
        }

        static void reverseString()
        {
            int lengthCount;
            char[] revString = new char[20];
            Console.WriteLine("Enter a string");
            string getString = Console.ReadLine();

            int stringlength = getString.Count();
            int startIndex = stringlength - 1;

            for (lengthCount = 0; getString.Count() > lengthCount; lengthCount++)
            {
                revString[lengthCount] = getString[startIndex];
                startIndex--;
            }
            Console.WriteLine("Length of string is - {0}", lengthCount);

            for (int j = 0; j < revString.Count() && revString[j] != '\0'; j++)
            {
                Console.Write("{0}", revString[j]);
            }
        }

        static void checkPalindrome()
        {
            int lengthCount;
            int startIndex = 0;
            char[] charGetString = new char[20];
            Console.WriteLine("Enter a string");
            string getString = Console.ReadLine();

            int stringlength = getString.Count();
            int lastIndex = stringlength - 1;

            for (int m = 0; getString.Count() > m; m++)
            {
                charGetString[m] = getString[m];
            }

            for (lengthCount = 0; getString.Count() > lengthCount; lengthCount++)
            {
                if (charGetString[startIndex] == charGetString[lastIndex])
                {

                }
                else
                {
                    break;
                }
                startIndex++;
                lastIndex--;
            }

            if (startIndex >= lastIndex)
            {
                Console.WriteLine("String is Palindrome.");
            }
            else
            {
                Console.WriteLine("String is Not Palindrome.");
            }
        }

        static void addNumericString()
        {
            Console.WriteLine("Enter a number");
            int getNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int m = 0; getNumber != 0; m++)
            {
                sum = sum + getNumber % 10;
                getNumber = getNumber / 10;
            }
            Console.WriteLine("Result is - {0}", sum);


        }

        static void uniqueCharacters()
        {
            Console.WriteLine("Enter a string");
            string getString = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < getString.Length; i++)
            {
                for (int j = i + 1; j < getString.Length; j++)
                {
                    if (getString[i] == getString[j])
                    {
                        Console.WriteLine("String have duplicate characters");
                        flag = true;
                        return;
                    }
                }
            }
            if (!flag)
            {
                Console.WriteLine("String have unique characters");
            }
        }

        static void stringCompression()
        {
            Console.WriteLine("Enter a string");
            string getString = Console.ReadLine();


            
        }
        #endregion

        static void Main(string[] args)
        {
            //lengthOfString();
            //copyString();
            //reverseString();
            //ConcatenateString();
            // Compare2Strings();
            //checkPalindrome();
            //  addNumericString();
            uniqueCharacters();

            Console.ReadKey();
        }
    }
}
