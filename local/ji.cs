using System;
class Program
{
    static bool AreStringsReverse(string str1, string str2)
    {
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();
        return str1 == new string(str2.ToCharArray().Reverse().ToArray());
    }
    static void Main()
    {
        string str1 = "racecar";
        string str2 = "racecar";
        bool result = AreStringsReverse(str1, str2);
        if (result)
        {
            Console.WriteLine("The strings are reverses of each other.");
        }
        else
        {
            Console.WriteLine("The strings are not reverses of each other.");
        }
    }
}


2.//Find the Smallest Sum of consecutive Number from given Array
using System;
class Program
{
    static int FindSmallestConsecutiveSum(int[] arr)
    {
        if (arr.Length == 0)
        {
            throw new ArgumentException("The array cannot be empty.");
        }
        int currentSum = arr[0];
        int smallestSum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            currentSum = Math.Min(arr[i], currentSum + arr[i]);
            smallestSum = Math.Min(smallestSum, currentSum);
        }
        return smallestSum;
    }

    static void Main()
    {
        int[] array = { 1, 2, -3, 4, -1, 2 };
        int smallestSum = FindSmallestConsecutiveSum(array);
        Console.WriteLine("The smallest sum of consecutive numbers is: " + smallestSum);
    }
}

3.//Find the Power without using math.pow function.
    using System;
class Program
{
    static double CalculatePower(double baseNumber, int exponent)
    {
        if (exponent < 0)
        {
            throw new ArgumentException("Exponent should be a non-negative integer.");
        }

        if (exponent == 0)
        {
            return 1; // Any number raised to the power of 0 is 1
        }
        double result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
    static void Main()
    {
        double baseNumber = 2;
        int exponent = 3;
        double result = CalculatePower(baseNumber, exponent);
        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
    }
}