using NUnit.Framework;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNunitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnNumber()
        {
            // 1. Arrange
            // Operations operations = new Operations();
            //  Operations operations = new();
            var operations = new Operations();
            int number1 = 2;
            int number2 = 5;
            int expectedResult = 7;

            // 2. Act
            int result = operations.Add(number1, number2);

            // 3.Assert
            Assert.That(result, Is.EqualTo(expectedResult));

            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));
        }
             [Test]
             [TestCase(10, ExpectedResult =true)]
             [TestCase(11, ExpectedResult =false)]
             [TestCase(14, ExpectedResult =true)]
        public bool IsEven_InputNumber_ReturnsTrue()
        {
            // 1. Arrange
            //igual que el var es
            Operations operations = new Operations();
            int number = 11;

            var result= operations.IsEven(number);

            return result;
        }

        [Test]
        [TestCase(2.2, 1.2)]
        [TestCase(2.23, 1.24)]
        //public double AddDecimal (double number1, double number2)
        //{
         //   return number1 + number2;
        //}
        public void AddDecimal_InputDoubleNumbers_ReturnsDoubleNumber(double number1, double number2)
        {
            // 1 arrange
            Operations operations1 = new ();

            //2 act
            double result= Operations.EqualsTo(3.4.within (0.1));

            //asserts
            // arreglar esto!!! Assert.res
        }
    }
}
