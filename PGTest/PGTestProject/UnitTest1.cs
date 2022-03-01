using NUnit.Framework;
using CodeToTestPG;

namespace PGTestProject
{
    public class Tests
    {

        [Category("Out of bound cases")]
        [TestCase(-100)]
        [TestCase(-1)]
        public void GivenOutOfBoundCasesTestCases_AvalibleClassification(int age) 
        {
            Assert.That(() => Program.AvailableClassifications(age), Throws.TypeOf<System.ArgumentOutOfRangeException>());
        }

        [Category("Edge cases")]
        [TestCase(0, "U, PG are available.")]
        [TestCase(12, "U, PG &12 films are available.")]
        [TestCase(15, "U, PG, 12 & 15 films are available.")]
        [TestCase(18, "All films are available.")]

        [Category("Safe cases")]
        [TestCase(5, "U, PG are available.")]
        [TestCase(14, "U, PG &12 films are available.")]
        [TestCase(17, "U, PG, 12 & 15 films are available.")]
        [TestCase(24, "All films are available.")]
        [TestCase(54, "All films are available.")]
        [TestCase(84, "All films are available.")]
        [TestCase(124, "All films are available.")]
        [TestCase(1124, "All films are available.")]
        public void GivenTestCases_AvalibleClassification_OutputCorrectMessage(int age, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.AvailableClassifications(age)));
        }
    }
}