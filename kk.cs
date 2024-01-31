using System;
using System.Collections.Generic;

class Program
{
    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Create dictionaries to store character counts for both strings
        Dictionary<char, int> charCount1 = new Dictionary<char, int>();
        Dictionary<char, int> charCount2 = new Dictionary<char, int>();

        // Populate the character counts for the first string
        foreach (char c in str1)
        {
            if (charCount1.ContainsKey(c))
            {
                charCount1[c]++;
            }
            else
            {
                charCount1[c] = 1;
            }
        }

        // Populate the character counts for the second string
        foreach (char c in str2)
        {
            if (charCount2.ContainsKey(c))
            {
                charCount2[c]++;
            }
            else
            {
                charCount2[c] = 1;
            }
        }

        // Compare the character counts of both strings
        foreach (var kvp in charCount1)
        {
            if (!charCount2.ContainsKey(kvp.Key) || charCount2[kvp.Key] != kvp.Value)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        bool areAnagrams = AreAnagrams(str1, str2);

        if (areAnagrams)
        {
            Console.WriteLine($"{str1} and {str2} are anagrams.");
        }
        else
        {
            Console.WriteLine($"{str1} and {str2} are not anagrams.");
        }
    }
}


14.
//WAP to read name (program) and print letters in ascending order (agmoprr)
  using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        string sortedName = SortString(name);

        Console.WriteLine("Letters in ascending order: " + sortedName);
    }

    static string SortString(string input)
    {
        char[] characters = input.ToCharArray();
        Array.Sort(characters);
        return new string(characters);
    }
}