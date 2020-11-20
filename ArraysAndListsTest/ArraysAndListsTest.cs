using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraysAndLists;


namespace ArraysAndListsTest
{
    //#1
    [TestClass]
    public class FacebookLikesTest
    {
        // 1- When you post a message on Facebook, depending on the number of people who like your
        // post, Facebook returns different information.

        // Write a method that accepts any number of names of individuals that like your post.
        // Return a string based on the below pattern.
        // If no one likes your post, it returns null.
        // If only one person likes your post, it returns: "[Friend's Name] liked your post."
        // If two people like your post, it returns: "[Friend 1] and [Friend 2] liked your post."
        // If more than two people like your post, it returns: "[Friend 1], [Friend 2] and [Number of Other People] others liked your post."

        [TestMethod]
        public void NoPostLikes()
        {
            var actual = ArraysAndLists.ArraysAndLists.FacebookLikes();

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void PostWithOneLike()
        {
            var expected = "Jerry liked your post.";

            var actual = ArraysAndLists.ArraysAndLists.FacebookLikes("Jerry");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PostWithTwoLikes()
        {
            var expected = "Jerry and Sammy liked your post.";

            var actual = ArraysAndLists.ArraysAndLists.FacebookLikes("Jerry", "Sammy");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PostWithMultipleLikes()
        {
            var expected = "Jerry, Sammy and 2 others liked your post.";

            var actual = ArraysAndLists.ArraysAndLists.FacebookLikes("Jerry", "Sammy", "Tommy", "Rick");

            Assert.AreEqual(expected, actual);
        }
    }

    //#2
    [TestClass]
    public class ReverseNameTest
    {
        // 2- Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. Return "Error" if no text is inputted.

        [TestMethod]
        public void EmptyStringReturnsError()
        {
            var expected = "Error";

            var actual = ArraysAndLists.ArraysAndLists.ReverseName(string.Empty);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProperlyReverseString()
        {
            var expected = "llih eht pu nar god ehT";

            var actual = ArraysAndLists.ArraysAndLists.ReverseName("The dog ran up the hill");

            Assert.AreEqual(expected, actual);
        }
    }

    //#3
    [TestClass]
    public class NumberSorterTest
    {
        // 3- Write a method that accepts any number of integers (minimum of two integers). If an integer is a duplicate, return
        // "Error". If all integers are unique, then order them in ascending order and return the sorted
        // result as a string of integers seperated by spaces.

        [TestMethod]
        public void DuplicateError()
        {
            var expected = "Error";

            var actual = ArraysAndLists.ArraysAndLists.NumberSorter(5, 5, 1, 9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AscendingOrder()
        {
            var expected = "1 2 7 18 31";

            var actual = ArraysAndLists.ArraysAndLists.NumberSorter(1, 31, 2, 7, 18);

            Assert.AreEqual(expected, actual);
        }
    }

    //#4
    [TestClass]
    public class UniqueNumbersTest
    {
        // 4- Write a method that accepts any number of numbers (minimum of two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.

        [TestMethod]
        public void OnlyDistinctNumbers()
        {
            int[] expected = { 1, 5, 9 };

            var actual = ArraysAndLists.ArraysAndLists.UniqueNumbers(5, 5, 1, 9);

            Assert.AreEqual(expected, actual);
        }
    }

    //#5
    [TestClass]
    public class SmallestNumbersTest
    {
        // 5- Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string seperated by
        // spaces, sorted in ascending order.

        [TestMethod]
        public void ArrayEmpty()
        {
            var expected = "Invalid Array";

            var actual = ArraysAndLists.ArraysAndLists.SmallestNumbers();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArrayLessThan5()
        {
            var expected = "Invalid Array";

            var actual = new string[] {
                ArraysAndLists.ArraysAndLists.SmallestNumbers(1),
                ArraysAndLists.ArraysAndLists.SmallestNumbers(1, 2),
                ArraysAndLists.ArraysAndLists.SmallestNumbers(1, 2, 3),
                ArraysAndLists.ArraysAndLists.SmallestNumbers(5, 5, 1, 9),
            };

            bool LessThan5 = false;

            foreach (var item in actual)
            {
                if (item == expected)
                {
                    LessThan5 = true;
                }
            }

            Assert.IsTrue(LessThan5);
        }

        [TestMethod]
        public void ThreeSmallestNumbers()
        {
            var expected = "1 2 3";

            var actual = ArraysAndLists.ArraysAndLists.SmallestNumbers(7, 16, 2, 3, 9, 48, 1, 97, 34);

            Assert.AreEqual(expected, actual);
        }

    }

}