using System.Linq;
using System.Collections;
using System;


namespace ArraysAndLists
{
    public static class ArraysAndLists
    {
        // 1- When you post a message on Facebook, depending on the number of people who like your
        // post, Facebook returns different information.

        // Write a method that accepts any number of names.
        // Return a string based on the below pattern.
        // If no one likes your post, it returns an empty string.
        // If only one person likes your post, it returns: "[Friend's Name] liked your post."
        // If two people like your post, it returns: "[Friend 1] and [Friend 2] liked your post."
        // If more than two people like your post, it returns: "[Friend 1], [Friend 2] and [Number of Other People] others liked your post."
        public static string FacebookLikes(params string[] names)
        {
            var countNames = names.Length;
            var result = string.Empty;

            switch (countNames)
            {
                case 0:
                    break;
                case 1:
                    result = $"{names[0]} liked your post.";
                    break;
                case 2:
                    result = $"{names[0]} and {names[1]} liked your post.";
                    break;
                default:
                    result = $"{names[0]}, {names[1]} and {countNames - 2} others liked your post.";
                    break;
            }

            return result;
        }

        // 2 - Write a method that accepts any number of integers (minimum of two integers). If an
        // integer is a duplicate, return "Error". If all integers are unique, then order them in
        // ascending order and return the sorted result as a string of integers seperated by spaces.
        public static string NumberSorter(params int[] numbers)
        {
            var result = string.Empty;

            var lengthOfDistinct = numbers.Distinct().Count();
            var lengthOfInput    = numbers.Length;

            if (lengthOfDistinct != lengthOfInput)
            {
                result = "Error";
            }
            else
            {
                Array.Sort(numbers);
                result = numbers.Aggregate(result, (current, number) => current + (number + " "));

                result = result[0..^1]; 
            }

            return result;
        }

        // 3 - Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. "I like trains" should return "sniart ekil I". Return
        // "Error" if no text is inputted.
        public static string ReverseName(string name)
        {
            var result     = string.Empty;
            var nameLength = name.Length;

            if (nameLength != 0)
            {
                for (var i = nameLength - 1; i >= 0; i--)
                {
                    result += name[i];
                }
            }
            else
            {
                result = "Error";
            }

            return result;
        }

        // 4 - Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string seperated by
        // spaces, sorted in ascending order. Treat duplicate numbers normally.
        public static string SmallestNumbers(params int[] numbers)
        {
            var result = string.Empty;

            Array.Sort(numbers);

            result = numbers.Length < 5 ? "Invalid Array" : $"{numbers[0]} {numbers[1]} {numbers[2]}";

            return result;
        }

        // 5 - Write a method that accepts any number of numbers (assume at least two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
        // So for example, an array consisting of [2, 2, 1, 3] should return [1, 2, 3].
        public static int[] UniqueNumbers(params int[] numbers)
        {
             
            Array.Sort(numbers);
            var result = numbers.Distinct().ToArray();

            return result;
        }

        private static class Program
        {
            private static void Main()
            {
                // Use this section to test code should you feel the need.
                // Console.WriteLine(whatever);
            }
        }
    }
}