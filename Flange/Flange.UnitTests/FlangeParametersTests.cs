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
        [TestCase(TestName = "afdgfdshsdfg")]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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
