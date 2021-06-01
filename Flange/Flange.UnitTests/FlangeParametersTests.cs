using NUnit.Framework;
using FlangeSizes;
using System;

namespace Flange.UnitTests
{
    /// <summary>
    /// Класс юнит-тестов параметров.
    /// </summary>
    [TestFixture]
    public class FlangeParameterTests
    {
        [TestCase(89, 49, 19, 11, 9, 3,
            TestName = "Тест на ввод некорректных значений")]
        public void UncorrectParametrs(double flangeExternalDiameter,
            double flangeInnerDiameter, double flangeCenterDistance, double flangeLength,
            double holeNumber, double holeDiameter)
        {
            //Setup
            var parameters = new FlangeParameters();

            //Assert
            Assert.Throws<ArgumentException>(
                () => { parameters.FlangeExternalDiameter = flangeExternalDiameter; });
            Assert.Throws<ArgumentException>(
                () => { parameters.FlangeInnerDiameter = flangeInnerDiameter; });
            Assert.Throws<ArgumentException>(
                () => { parameters.FlangeCenterDistance = flangeCenterDistance; });
            Assert.Throws<ArgumentException>(
                () => { parameters.FlangeLength = flangeLength; });
            Assert.Throws<ArgumentException>(
                () => { parameters.HoleNumber = holeNumber; });
            Assert.Throws<ArgumentException>(
                () => { parameters.HoleDiameter = holeDiameter; });
        }

        [TestCase(90, 50, 20, 12, 10, 4,
            TestName = "Тест на ввод корректных значений")]
        public void CorrectParametrs(double flangeExternalDiameter,
            double flangeInnerDiameter, double flangeCenterDistance, double flangeLength,
            double holeNumber, double holeDiameter)
        {
            //Setup
            var parameters = new FlangeParameters();

            //Assert
            Assert.Throws<ArgumentException>(
                () => { parameters.FlangeExternalDiameter = flangeExternalDiameter; });
            Assert.Throws<ArgumentException>(
                () => { parameters.FlangeInnerDiameter = flangeInnerDiameter; });
            Assert.Throws<ArgumentException>(
                () => { parameters.FlangeCenterDistance = flangeCenterDistance; });
            Assert.Throws<ArgumentException>(
                () => { parameters.FlangeLength = flangeLength; });
            Assert.Throws<ArgumentException>(
                () => { parameters.HoleNumber = holeNumber; });
            Assert.Throws<ArgumentException>(
                () => { parameters.HoleDiameter = holeDiameter; });
        }
    }
}
