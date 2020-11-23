using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArraysAndListsTest
{
    // 1- When you post a message on Facebook, depending on the number of people who like your
    // post, Facebook returns different information.

    // Write a method that accepts any number of names.
    // Return a string based on the below pattern.
    // If no one likes your post, it returns an empty string.
    // If only one person likes your post, it returns: "[Friend's Name] liked your post."
    // If two people like your post, it returns: "[Friend 1] and [Friend 2] liked your post."
    // If more than two people like your post, it returns: "[Friend 1], [Friend 2] and [Number of Other People] others liked your post."
    [TestClass]
    public class FacebookLikesTest
    {
        [TestMethod]
        public void NoPostLikes()
        {
            var actual = ArraysAndLists.ArraysAndLists.FacebookLikes();

            actual.Should().BeNullOrEmpty(because: "if no one liked the post, there should be an empty string");
        }

        [TestMethod]
        public void PostWithOneLike()
        {
            var expected = "Jerry liked your post.";

            var actual = ArraysAndLists.ArraysAndLists.FacebookLikes("Jerry");

            actual.Should().Be(expected, because: "it should return '[Name] liked your post'");
        }

        [TestMethod]
        public void PostWithTwoLikes()
        {
            var expected = "Jerry and Sammy liked your post.";

            var actual = ArraysAndLists.ArraysAndLists.FacebookLikes("Jerry", "Sammy");

            actual.Should().Be(expected, because: "it should return '[Name 1] and [Name 2] liked your post'");
        }

        [TestMethod]
        public void PostWithMultipleLikes()
        {
            var expected = "Jerry, Sammy and 2 others liked your post.";

            var actual = ArraysAndLists.ArraysAndLists.FacebookLikes("Jerry", "Sammy", "Tommy", "Rick");

            actual.Should().Be(expected, because: "it should return '[Name 1], [Name 2] and [number of other people] others liked your post'");
        }
    }

    // 2 - Write a method that accepts any number of integers (minimum of two integers). If an
    // integer is a duplicate, return "Error". If all integers are unique, then order them in
    // ascending order and return the sorted result as a string of integers separated by spaces.
    [TestClass]
    public class NumberSorterTest
    {
        [TestMethod]
        public void DuplicateError()
        {
            var expected = "Error";

            var actual = ArraysAndLists.ArraysAndLists.NumberSorter(5, 5, 1, 9);

            actual.Should().Be(expected, because: "it should return return 'Error' if duplicates are found");
        }

        [TestMethod]
        public void AscendingOrder()
        {
            var expected = "1 2 7 18 31";

            var actual = ArraysAndLists.ArraysAndLists.NumberSorter(1, 31, 2, 7, 18);

            actual.Should().Be(expected, because: "it should return the passed numbers in ascending order");
        }
    }

    // 3 - Write a method that accepts a string for a name. Use an array to reverse the characters
    // then return the result as a string. "I like trains" should return "sniart ekil I". Return
    // "Error" if no text is inputted.
    [TestClass]
    public class ReverseNameTest
    {
        [TestMethod]
        public void EmptyStringReturnsError()
        {
            var expected = "Error";

            var actual = ArraysAndLists.ArraysAndLists.ReverseName(string.Empty);

            actual.Should().Be(expected, because: "it should return 'Error' if empty string is passed");
        }

        [TestMethod]
        public void ProperlyReverseString()
        {
            var expected = "llih eht pu nar god ehT";

            var actual = ArraysAndLists.ArraysAndLists.ReverseName("The dog ran up the hill");

            actual.Should().Be(expected, because: "it should properly reverse the passed input");

        }
    }

    // 4 - Write a method that accepts any number of integers. If none or less than 5 numbers,
    // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string seperated by
    // spaces, sorted in ascending order. Treat duplicate numbers normally.
    [TestClass]
    public class SmallestNumbersTest
    {
        [TestMethod]
        public void ArrayEmpty()
        {
            var expected = "Invalid Array";

            var actual = ArraysAndLists.ArraysAndLists.SmallestNumbers();

            actual.Should().Be(expected, because: "it should return 'Invalid Array' for an empty array");
        }

        [TestMethod]
        public void ArrayLessThan5()
        {
            var expected = "Invalid Array";

            var actual = new[]
                         {
                             ArraysAndLists.ArraysAndLists.SmallestNumbers(1),
                             ArraysAndLists.ArraysAndLists.SmallestNumbers(1, 2),
                             ArraysAndLists.ArraysAndLists.SmallestNumbers(1, 2, 3),
                             ArraysAndLists.ArraysAndLists.SmallestNumbers(5, 5, 1, 9)
                         };

            actual.Should().Contain(expected,
                because: "it should return 'Invalid Array' if input array has less than 5 integers");
        }


        [TestMethod]
        public void ArrayOf5Numbers()
        {
            var expected = "6 8 10";

            var actual = ArraysAndLists.ArraysAndLists.SmallestNumbers(8, 10, 46, 84, 6);

            actual.Should().Be(expected, because: "it should allow a array of size 5 to be processed");
        }

        [TestMethod]
        public void ThreeSmallestWithDuplicates()
        {
            var expected = "1 1 4";

            var actual = ArraysAndLists.ArraysAndLists.SmallestNumbers(1, 1, 4, 68, 57, 5);

            actual.Should().Be(expected, because: "it should return the 3 smallest integers, even if they are duplicates");
        }


        [TestMethod]
        public void InAscendingOrder()
        {
            var expected = "1 2 3";

            var actual = ArraysAndLists.ArraysAndLists.SmallestNumbers(7, 16, 2, 3, 9, 48, 1, 97, 34);

            actual.Should().Be(expected, because: "it should return the 3 smallest numbers in ascending order");
        }
    }

    // 5 - Write a method that accepts any number of integers (assume at least two numbers). The integers
    // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
    // So for example, an array consisting of [2, 2, 1, 3] should return [1, 2, 3].
    [TestClass]
    public class UniqueNumbersTest
    {
        [TestMethod]
        public void OnlyDistinctNumbers()
        {
            var actual = ArraysAndLists.ArraysAndLists.UniqueNumbers(5, 5, 1, 9, 9);

            actual.Should().OnlyHaveUniqueItems(because: "it should only return the unique numbers with no duplicates");
        }

        [TestMethod]
        public void InAscendingOrder()
        {
            var actual = ArraysAndLists.ArraysAndLists.UniqueNumbers(6, 9, 3);

            actual.Should().BeInAscendingOrder(because: "it should order the integers in ascending order");
        }

        [TestMethod]
        public void OnlyDuplicates()
        {
            var actual = ArraysAndLists.ArraysAndLists.UniqueNumbers(15, 15, 15, 15);

            actual.Should().HaveCount(1, because: "it should return a singular number if all the inputs are the same.");
        }
    }
}