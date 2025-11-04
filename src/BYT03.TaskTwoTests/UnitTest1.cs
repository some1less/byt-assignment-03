using BYT03.TaskTwo;

namespace BYT03.TaskTwoTests
{
    public class Tests
    {
        
        Calculator addition = new Calculator(5,10,'+');
        Calculator substr = new Calculator(5,10,'-');
        Calculator mult = new Calculator(5,10,'*');
        Calculator div = new Calculator(5, -5, '/');
        Calculator divByZero = new Calculator(5, 0, '/');
        Calculator unknownOperator = new Calculator(5, 1, '?');

        [Test]
        public void TestAddition()
        {
            Assert.That(addition.Calculate(), Is.EqualTo(15).Within(0.001));
        }

        [Test]
        public void TestSubstraction()
        {
            Assert.That(substr.Calculate(), Is.EqualTo(-5).Within(0.001));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.That(mult.Calculate(), Is.EqualTo(50).Within(0.001));
        }

        [Test]
        public void TestDivision()
        {
            Assert.That(div.Calculate(), Is.EqualTo(-1).Within(0.001));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Assert.That(() => divByZero.Calculate(), Throws.TypeOf<System.DivideByZeroException>());
        }

        [Test]
        public void TestUnknownOperator()
        {
            Assert.That(() => unknownOperator.Calculate(), Throws.TypeOf<System.Exception>());
        }
    }
}

