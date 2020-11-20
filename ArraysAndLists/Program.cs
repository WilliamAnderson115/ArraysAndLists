using System;

namespace ArraysAndLists
{
    public static class ArraysAndLists
    {
        // 1- When you post a message on Facebook, depending on the number of people who like your
        // post, Facebook returns different information.

        // Write a method that accepts any number of names.
        // Return a string based on the below pattern.
        // If no one likes your post, it returns null.
        // If only one person likes your post, it returns: "[Friend's Name] likes your post."
        // If two people like your post, it returns: "[Friend 1] and [Friend 2] liked your post."
        // If more than two people like your post, it returns: "[Friend 1], [Friend 2] and [Number of Other People] others liked your post."
        public static string FacebookLikes(params string[] names)
        {
            return default;
        }

        // 3- Write a method that accepts any number of integers (minimum of two integers). If an
        // integer is a duplicate, return "Error". If all integers are unique, then order them in
        // ascending order and return the sorted result as a string of integers seperated by spaces.
        public static string NumberSorter(params int[] numbers)
        {
            return default;
        }

        // 2- Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. Return "Error" if no text is inputted.
        public static string ReverseName(string name)
        {
            return default;
        }
        // 5- Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string seperated by
        // spaces, sorted in ascending order.
        public static string SmallestNumbers(params int[] numbers)
        {
            return default;
        }

        // 4- Write a method that accepts any number of numbers (minimum of two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
        public static int[] UniqueNumbers(params int[] numbers)
        {
            return default;
        }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
}
