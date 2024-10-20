using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2_2;
using System;

namespace Task2_2_Tests
{
    [TestClass]
    public class TSquare
    {
        [TestMethod]
        public void Constructor_Default_ShouldSetSideLengthToOne()
        {
            Task2_2.TSquare square = new Task2_2.TSquare();

            Assert.AreEqual(1.0, square.SideLength, "Стандартна довжина сторони має бути 1.0.");
        }

        [TestMethod]
        public void Constructor_WithParameter_ShouldSetCorrectSideLength()
        {
            double expectedLength = 5.0;
            Task2_2.TSquare square = new Task2_2.TSquare(expectedLength);

            Assert.AreEqual(expectedLength, square.SideLength, "Довжина сторони повинна відповідати вказаному значенню.");
        }

        [TestMethod]
        public void GetArea_ShouldReturnCorrectArea()
        {
            Task2_2.TSquare square = new Task2_2.TSquare(4.0);

            double area = square.GetArea();

            Assert.AreEqual(16.0, area, "Площа має бути квадратом довжини сторони.");
        }

        [TestMethod]
        public void GetPerimeter_ShouldReturnCorrectPerimeter()
        {
            Task2_2.TSquare square = new Task2_2.TSquare(4.0);

            double perimeter = square.GetPerimeter();

            Assert.AreEqual(16.0, perimeter, "Периметр повинен бути в 4 рази більше довжини сторони.");
        }

        [TestMethod]
        public void Operator_Addition_ShouldReturnCorrectResult()
        {
            Task2_2.TSquare square1 = new Task2_2.TSquare(3.0);
            Task2_2.TSquare square2 = new Task2_2.TSquare(2.0);

            Task2_2.TSquare result = square1 + square2;

            Assert.AreEqual(5.0, result.SideLength, "Оператор додавання має підсумовувати довжини сторін.");
        }

        [TestMethod]
        public void Operator_Subtraction_ShouldReturnCorrectResult()
        {
            Task2_2.TSquare square1 = new Task2_2.TSquare(5.0);
            Task2_2.TSquare square2 = new Task2_2.TSquare(3.0);

            Task2_2.TSquare result = square1 - square2;

            Assert.AreEqual(2.0, result.SideLength, "Оператор віднімання повинен відняти довжини сторін.");
        }

        [TestMethod]
        public void Operator_Subtraction_ShouldNotReturnNegativeSideLength()
        {
            Task2_2.TSquare square1 = new Task2_2.TSquare(2.0);
            Task2_2.TSquare square2 = new Task2_2.TSquare(3.0);

            Task2_2.TSquare result = square1 - square2;

            Assert.AreEqual(0.0, result.SideLength, "Довжина сторони не повинна бути від’ємною.");
        }

        [TestMethod]
        public void Operator_Multiplication_ShouldReturnCorrectResult()
        {
            Task2_2.TSquare square = new Task2_2.TSquare(4.0);
            double factor = 2.0;

            Task2_2.TSquare result = square * factor;

            Assert.AreEqual(8.0, result.SideLength, "Множення має помножити довжину сторони на коефіцієнт.");
        }

        [TestMethod]
        public void Equals_ShouldReturnTrueForEqualSquares()
        {
            Task2_2.TSquare square1 = new Task2_2.TSquare(4.0);
            Task2_2.TSquare square2 = new Task2_2.TSquare(4.0);

            bool isEqual = square1.Equals(square2);

            Assert.IsTrue(isEqual, "Квадрати з однаковою довжиною сторін повинні бути рівними.");
        }

        [TestMethod]
        public void Equals_ShouldReturnFalseForDifferentSquares()
        {
            Task2_2.TSquare square1 = new Task2_2.TSquare(4.0);
            Task2_2.TSquare square2 = new Task2_2.TSquare(5.0);

            bool isEqual = square1.Equals(square2);

            Assert.IsFalse(isEqual, "Квадрати з різною довжиною сторін не повинні бути рівними.");
        }
    }

    [TestClass]
    public class TCubeTests
    {
        [TestMethod]
        public void GetVolume_ShouldReturnCorrectVolume()
        {
            TCube cube = new TCube(3.0);

            double volume = cube.GetVolume();

            Assert.AreEqual(27.0, volume, "Об’єм має дорівнювати довжині сторони в кубі.");
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectString()
        {
            TCube cube = new TCube(2.0);

            string cubeDescription = cube.ToString();

            string expectedDescription = "Куб зі стороною 2, площа: 4, периметр: 8, об'єм: 8";
            Assert.AreEqual(expectedDescription, cubeDescription, "ToString має повернути правильний опис для куба.");
        }
    }
}

