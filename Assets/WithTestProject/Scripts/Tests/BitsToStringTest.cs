using NUnit.Framework;

namespace WithTestProject.Tests
{
    public class BitsToStringTest
    {
        [Test]
        public void ToStringTest()
        {
            var bitsToString = new BitsToString();
            string answer;
            answer = bitsToString.ToString(false, false, false, false);
            Assert.That(answer, Is.EqualTo("00"));
            answer = bitsToString.ToString(false, false, false, true);
            Assert.That(answer, Is.EqualTo("01"));
            answer = bitsToString.ToString(false, false, true, false);
            Assert.That(answer, Is.EqualTo("02"));
            answer = bitsToString.ToString(false, true, false, false);
            Assert.That(answer, Is.EqualTo("04"));
            answer = bitsToString.ToString(true, false, false, false);
            Assert.That(answer, Is.EqualTo("08"));
            answer = bitsToString.ToString(true, true, true, true);
            Assert.That(answer, Is.EqualTo("15"));
        }
    }
}
