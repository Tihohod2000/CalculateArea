using NUnit.Framework;
using System;
using test;

namespace UnitTest1
{
    public class CalcAreaTests
    {
        private CalcArea _calcArea;

        [SetUp]
        public void Setup()
        {
            _calcArea = new CalcArea();
        }

        [Test]
        public void TestCalculateTriangleArea_ValidInputs_ReturnsCorrectArea()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            double result = _calcArea.CalculateTriangleArea(a, b, c);

            // Assert
            Assert.AreEqual(6, result, 0.0001); // Площадь треугольника с такими сторонами должна быть 6
        }

        [Test]
        public void TestCalculateTriangleArea_InvalidInputs_ThrowsException()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 3;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calcArea.CalculateTriangleArea(a, b, c));
        }

        [Test]
        public void TestCalculateCircleArea_ValidInput_ReturnsCorrectArea()
        {
            // Arrange
            double r = 5;

            // Act
            double result = _calcArea.CalculateCircleArea(r);

            // Assert
            Assert.AreEqual(Math.PI * 25, result, 0.0001); // Площадь круга с радиусом 5 должна быть 25 * π
        }

       
    }
}
