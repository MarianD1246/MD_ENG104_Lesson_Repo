using NUnit.Framework;
using CK1;

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

    }
}