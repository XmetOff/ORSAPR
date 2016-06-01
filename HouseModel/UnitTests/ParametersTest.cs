using System;
using House;
using HouseModel;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class ParametersTests
    {
        [Test]

        [TestCase(15.0, TestName = "Вводимое значение параметра равно 15")]
        public void NotPositiveValueTest(double testValue)
        {
            Assert.Throws<ValueException>(() => new HouseParameter(testValue, 0.0, 10.0));
        }

        [TestCase(5, TestName = "Вводимое значение параметра равно 5")]
        public void PositiveValueTest(double testValue)
        {
            Assert.DoesNotThrow(() => new HouseParameter(testValue, 0.0, 10.0));
        }

        [TestCase(double.PositiveInfinity, TestName = "Вводимое значение параметра равно бесконечности")]
        public void InfinityValueTest(double testValue)
        {
            Assert.Throws<ValueException>(() => new HouseParameter(testValue, 0.0, 10.0));
        }

        [TestCase(double.NaN, TestName = "Вводимое значение параметра равно Not-a-number")]
        public void NanValueTest(double testValue)
        {
            Assert.Throws<ValueException>(() => new HouseParameter(testValue, 0.0, 10.0));
        }

        [TestCase(double.MaxValue, TestName = "Максимальное значение параметра")]
        public void MaxValueTest(double testValue)
        {
            Assert.Throws<ValueException>(() => new HouseParameter(testValue, 0.0, 10.0));
        }

        [TestCase(double.MaxValue, double.MaxValue, TestName = "Максимальные значения пределов параметра")]
        public void MaxLimitTest(double testLimit1, double testLimit2)
        {
            Assert.Throws<ValueException>(() => new HouseParameter(15, testLimit1, testLimit2));
        }

        [TestCase(double.MinValue, double.MinValue, TestName = "Минимальные значения пределов параметра")]
        public void MinLimitTest(double testLimit1, double testLimit2)
        {
            Assert.Throws<ValueException>(() => new HouseParameter(15, testLimit1, testLimit2));
        }

        [TestCase(double.MinValue, TestName = "Минимальное значение параметра")]
        public void MinValueTest(double testValue)
        {
            Assert.Throws<ValueException>(() => new HouseParameter(testValue, 0.0, 10.0));
        }



        [TestCase(5, TestName = "Тест того, что невалидное значение не сохраняется")]
        public void ValueIsNotSaved(double testValue)
        {
            HouseParameter _parameter = new HouseParameter(testValue, 0.0, 10.0);
            try
            {
                _parameter.Value = testValue;
            }
            catch (Exception)
            {
                Assert.AreNotEqual(_parameter.Value, testValue);
            }
        }
    }
}
