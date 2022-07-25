using NUnit.Framework;

namespace WithTestProject.Tests
{
    public class BitsToStringTest
    {
        [Test]
        public void ToStringTest()
        {
            string answer;
            answer = BitsToString.ToString(false, false, false, false);
            Assert.That(answer, Is.EqualTo("00"));
            answer = BitsToString.ToString(false, false, false, true);
            Assert.That(answer, Is.EqualTo("01"));
            answer = BitsToString.ToString(false, false, true, false);
            Assert.That(answer, Is.EqualTo("02"));
            answer = BitsToString.ToString(false, true, false, false);
            Assert.That(answer, Is.EqualTo("04"));
            answer = BitsToString.ToString(true, false, false, false);
            Assert.That(answer, Is.EqualTo("08"));
            answer = BitsToString.ToString(true, true, true, true);
            Assert.That(answer, Is.EqualTo("15"));
        }
    }
}
