using NUnit.Framework;
using FlangeSizes;
using System;

namespace Flange.UnitTests
{
    /// <summary>
    /// Класс юнит-тестов параметров.
    /// </summary>
    public class FlangeParametersTest
    {
        [TestCase(TestName = "Тест на ввод корректных значений внешнего диаметра.")]
        public void ExternalDiameter_GoodExternalDiameter_ReturnsSameExternalDiameter()
        {
            //Setup
            var parameters = new FlangeParameters();
            const double sourceFlangeExternalDiameter = 90;
            const double expectedFlangeExternalDiameter = sourceFlangeExternalDiameter;

            //Act
            parameters.FlangeExternalDiameter = sourceFlangeExternalDiameter;
            var actualFlangeExternalDiameter = parameters.FlangeExternalDiameter;

            //Assert
            Assert.AreEqual(expectedFlangeExternalDiameter, actualFlangeExternalDiameter);
        }

        [TestCase(TestName = "Тест на ввод некорректных значений внешнего диаметра, " +
            "меньше минимального (90).")]
        public void ExternalDiameter_WrongExternalDiameter_ThrowsException()
        {
            //Setup
            var parameters = new FlangeParameters();
            const double wrongFlangeExternalDiameter = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.FlangeExternalDiameter = wrongFlangeExternalDiameter;
                }
            );
        }

        [TestCase(TestName = "Тест на ввод корректных значений внутреннего диаметра.")]
        public void InnerDiameter_GoodInnerDiameter_ReturnsSameInnerDiameter()
        {
            //Setup
            var parameters = new FlangeParameters();
            const double sourceFlangeInnerDiameter = 20;
            const double expectedFlangeInnerDiameter = sourceFlangeInnerDiameter;

            //Act
            parameters.FlangeInnerDiameter = sourceFlangeInnerDiameter;
            var actualFlangeInnerDiameter = parameters.FlangeInnerDiameter;

            //Assert
            Assert.AreEqual(expectedFlangeInnerDiameter, actualFlangeInnerDiameter);
        }

        [TestCase(TestName = "Тест на ввод некорректных значений внутреннего диаметра, " +
            "меньше минимального (20).")]
        public void InnerDiameter_WrongInnerDiameter_ThrowsException()
        {
            //Setup
            var parameters = new FlangeParameters();
            const double wrongFlangeInnerDiameter = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.FlangeInnerDiameter = wrongFlangeInnerDiameter;
                }
            );
        }

        [TestCase(TestName = "Тест на ввод корректных значений межосевого расстояния.")]
        public void CenterDistance_GoodCenterDistance_ReturnsSameCenterDistance()
        {
            //Setup
            var parameters = new FlangeParameters();
            const double sourceFlangeCenterDistance = 50;
            const double expectedFlangeCenterDistance = sourceFlangeCenterDistance;

            //Act
            parameters.FlangeCenterDistance = sourceFlangeCenterDistance;
            var actualFlangeCenterDistance = parameters.FlangeCenterDistance;

            //Assert
            Assert.AreEqual(expectedFlangeCenterDistance, actualFlangeCenterDistance);
        }

        [TestCase(TestName = "Тест на ввод некорректных значений межосевого расстояния, " +
            "меньше минимального (50).")]
        public void CenterDistance_WrongCenterDistance_ThrowsException()
        {
            //Setup
            var parameters = new FlangeParameters();
            const double wrongFlangeCenterDistance = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.FlangeCenterDistance = wrongFlangeCenterDistance;
                }
            );
        }

        [TestCase(TestName = "Тест на ввод корректных значений толщины фланца.")]
        public void Length_GoodLength_ReturnsSameLength()
        {
            //Setup
            var parameters = new FlangeParameters();
            const double sourceFlangeLength = 10;
            const double expectedFlangeLength = sourceFlangeLength;

            //Act
            parameters.FlangeLength = sourceFlangeLength;
            var actualFlangeLength = parameters.FlangeLength;

            //Assert
            Assert.AreEqual(expectedFlangeLength, actualFlangeLength);
        }

        [TestCase(TestName = "Тест на ввод некорректных значений толщины фланца, " +
            "меньше минимального (10).")]
        public void CenterLength_WrongLength_ThrowsException()
        {
            //Setup
            var parameters = new FlangeParameters();
            const double wrongFlangeLength = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.FlangeLength = wrongFlangeLength;
                }
            );
        }

        [TestCase(TestName = "Тест на ввод корректных значений количества отверстий.")]
        public void HoleNumber_GoodHoleNumber_ReturnsSameHoleNumber()
        {
            //Setup
            var parameters = new FlangeParameters();
            const int sourceHoleNumber = 4;
            const int expectedHoleNumber = sourceHoleNumber;

            //Act
            parameters.HoleNumber = sourceHoleNumber;
            var actualHoleNumber = parameters.HoleNumber;

            //Assert
            Assert.AreEqual(expectedHoleNumber, actualHoleNumber);
        }

        [TestCase(TestName = "Тест на ввод некорректных значений количества отверстий, " +
            "меньше минимального (4).")]
        public void HoleNumber_WrongHoleNumber_ThrowsException()
        {
            //Setup
            var parameters = new FlangeParameters();
            const int wrongHoleNumber = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.HoleNumber = wrongHoleNumber;
                }
            );
        }

        [TestCase(TestName = "Тест на ввод корректных значений диаметра отверстий.")]
        public void HoleDiameter_GoodHoleDiameter_ReturnsSameHoleDiameter()
        {
            //Setup
            var parameters = new FlangeParameters();
            const int sourceHoleDiameter = 12;
            const int expectedHoleDiameter = sourceHoleDiameter;

            //Act
            parameters.HoleDiameter = sourceHoleDiameter;
            var actualHoleDiameter = parameters.HoleDiameter;

            //Assert
            Assert.AreEqual(expectedHoleDiameter, actualHoleDiameter);
        }

        [TestCase(TestName = "Тест на ввод некорректных значений диаметра отверстий, " +
            "меньше минимального (12).")]
        public void HoleDiameter_WrongHoleDiameter_ThrowsException()
        {
            //Setup
            var parameters = new FlangeParameters();
            const int wrongHoleDiameter = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.HoleDiameter = wrongHoleDiameter;
                }
            );
        }
    }
}
