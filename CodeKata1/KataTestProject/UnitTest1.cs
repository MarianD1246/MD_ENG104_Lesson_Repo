using NUnit.Framework;
using CK1;
using System;

namespace KataTestProject
{
    public class Tests
    {
        //"Your sentance has {vowelCounter} vowels."

        [Category("K1 Cases")]
        [TestCase("Invalid age.", 5)]
        [TestCase(" ", 0)]
        [TestCase("Testing diffrent sentances!", 7)]
        [TestCase("B", 0)]
        [TestCase("134565431 ", 0)]
        [TestCase("lizzard ", 2)]
        [TestCase("AAAAOOOO ", 8)]
        public void TestingK1_VowelsInSentance(string userInput, int expected)
        {
            Assert.That(expected, Is.EqualTo(CodeK1.VowelsInSentance(userInput)));
        }

        //return $"{Math.Floor(x)} {weeks} and {nrOfDays % 7} {days}";
        [Category("K2 Cases")]
        [TestCase(-3, "0 weeks and 0 days")]
        [TestCase(0, "0 weeks and 0 days")]
        [TestCase(1, "0 weeks and 1 day")]
        [TestCase(3, "0 weeks and 3 days")]
        [TestCase(7, "1 week and 0 days")]
        [TestCase(8, "1 week and 1 day")]
        [TestCase(10, "1 week and 3 days")]
        [TestCase(15, "2 weeks and 1 day")]
        [TestCase(30, "4 weeks and 2 days")]
        public void TestingK2_DaysAsWeeksAndDays(int days, string expected)
        {
            Assert.That(expected, Is.EqualTo(CodeK2.DaysAsWeeksAndDays(days)));
        }

        [Category("K3 Cases")]
        [Test, Description("It should return correct text")]
        //[TestCase("no one likes this", new string[0])]
        //[TestCase("Peter likes this", new string[] { "Peter" })]
        //[TestCase("Jacob and Alex like this", new string[] { "Jacob", "Alex" })]
        //[TestCase("Max, John and Mark like this", new string[] { "Max", "John", "Mark" })]
        //[TestCase("Alex, Jacob and 2 others like this", new string[] { "Alex", "Jacob", "Mark", "Max" })]
        public void TestingK3_Likes()//string expected, string[] names)
        {
            Assert.AreEqual("no one likes this", CodeK3.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", CodeK3.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", CodeK3.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", CodeK3.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", CodeK3.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }

        [Category("K4 Cases")]
        [TestCase("Invalid age.", "ia")]
        [TestCase("Marian Dumitriu", "amiru")]
        [TestCase("AaBbdodmoaaaB", "abdo")]
        [TestCase("1 2 1 aa 2", " 1a2")]
        public void TestingK4_DuplicationInSentance(string sentance, string expected)
        {
            Assert.That(expected, Is.EqualTo(CodeK4.DuplicationInSentance(sentance)));
        }

        [Category("K5 Cases")]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -2)]
        [TestCase(new int[] { 1, 1, 1, 1, 1}, 1)]
        public void TestingK5_ReturnSecondHighestNumber(int[] myIntArray, int expected)
        {
            Assert.That(expected, Is.EqualTo(CodeK5.ReturnSecondHighestNumber(myIntArray)));
        }
        [TestCase(new int[] {  }, "The array is empty!")]
        [TestCase(new int[] { 1 }, "The array should have at least 2 items!")]
        public void TestingK5_ReturnHighestNumber_Exceptions(int[] myIntArray, string errorMessage)
        {
            //var ex = Assert.Throws<ArgumentException>(() => CodeK5.ReturnSecondHighestNumber(myIntArray));
            //Assert.AreEqual(errorMessage, ex.Message);
            Assert.Throws(Is.TypeOf<ArgumentException>().And.Message.EqualTo(errorMessage), () => CodeK5.ReturnSecondHighestNumber(myIntArray));
        }

        [Category("K6 Cases")]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -1)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 1)]
        [TestCase(new int[] { -7, -5, 5, 8, 22 }, -5)]
        [TestCase(new int[] { 103, 540, -222, -102}, -102)]
        public void TestingK6_ClosestToZero(int[] myIntArray, int expected)
        {
            Assert.That(expected, Is.EqualTo(CodeK6.ClosestToZero(myIntArray))); ;
        }

        [TestCase(new int[] { })]
        public void TestingK6_ClosestToZero_Exceptions(int[] myIntArray)
        {
            Assert.Throws(Is.TypeOf<NullReferenceException>().And.Message.EqualTo("Array can't be empty!"), () => CodeK6.ClosestToZero(myIntArray));
        }

    }


} 