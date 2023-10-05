using CalculatorLibrary;

namespace CalculatorTests
{
    [TestFixture(Author = "Anandha Padmanaban")]
    public class CalculatorShould
    {

        [Test]
        public void AddTwoAndThreeAndReturnsFive()
        {
            Assert.That(Calculator.Add(2, 3), Is.EqualTo(5));
        }

        [Test]
        public void SubtractThreeFromFiveAndReturnsTwo()
        {
            Assert.That(Calculator.Subtract(5, 3), Is.EqualTo(2));
        }

        [Test]
        public void MultiplyTwoAndThreeAndReturnsSix()
        {
            Assert.That(Calculator.Multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void DivideTenByTwoAndReturnsFive()
        {
            Assert.That(Calculator.Divide(10, 2), Is.EqualTo(5));
        }
    }
}