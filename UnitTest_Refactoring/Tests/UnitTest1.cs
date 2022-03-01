using CodeToTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Category("Edge cases")]
        [TestCase(0, "Good evening!")]
        [TestCase(5, "Good morning!")]
        [TestCase(12, "Good morning!")]
        [TestCase(18, "Good afternoon!")]
        [TestCase(24, "Good evening!")]
        public void GivenEdgeCase_0_5_12_18_24_Greeting_returnRightMessage(int time, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));
        }


        [Category("Out of bound cases")]
        [TestCase(-1, "Out of bound!")]
        [TestCase(-250, "Out of bound!")]
        [TestCase(25, "Out of bound!")]
        [TestCase(1000, "Out of bound!")]
        public void GivenOutOfBoundCase_n1_n250_25_1000_Greeting_returnRightMessage(int time, string expected)
        {
            Assert.That(()=> Program.Greeting(time), Throws.TypeOf<System.ArgumentOutOfRangeException>());
        }

        [Category("In-range cases")]
        [TestCase(2, "Good evening!")]
        [TestCase(7, "Good morning!")]
        [TestCase(14, "Good afternoon!")]
        [TestCase(20, "Good evening!")]
        public void GivenInRangeCase_2_7_14_20_Greeting_returnRightMessage(int time, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));
        }



        //[TestCase(5)]
        //[TestCase(8)]
        //[TestCase(12)]
        //[Ignore ("Test method incomplete")]
        //public void GivenATimeBetween5and12Incluse_Greeting_returnGoodMorning(int time)
        //{
        //    Assert.That("Good morning!", Is.EqualTo(Program.Greeting(time)));  
        //}

        //[Category("Edge case")]
        //[TestCase(13, "Good afternoon!")]
        //[TestCase(12, "Good morning!")]
        //public void GiveTheTime12and13_Greeting_returnRightMessage(int time, string expected)
        //{
        //    Assert.That(expected, Is.EqualTo(Program.Greeting(time)));
        //}
    }
}

//First - principles of teting
//fast will bild up to thousnad of test
//independed, shouldn't depend on one another, always randomised, 
//repeatable - should work for next person when project is duplicated (make sure no libaries and databases included)
//self validating - 
//t