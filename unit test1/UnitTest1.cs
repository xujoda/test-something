using NUnit.Framework;
using test_something;

namespace unit_test1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var calc = new Program();
            double arg1 = 8;
            double arg2 = 2;
            double expected = 4;
            // act
            //double result = calc.Div(arg1, arg2);
            // assert            
            //Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            var calc = new Program();
            double arg1 = 8;
            double arg2 = 0;
            //double result = calc.Div(arg1, arg2);
        }

        [Test]
        public void Test3()
        {
            var calc = new Program();
            double arg1 = 5;
            double arg2 = 3;
            double expected = 9;
            // act
            //double result = calc.AddWithInc(arg1, arg2);
            // assert            
            //Assert.AreEqual(expected, result);
        }
    }
}