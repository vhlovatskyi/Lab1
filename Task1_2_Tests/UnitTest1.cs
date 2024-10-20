using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task1_2;

namespace Task1_2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Indexer_GetValue_ValidIndices_ReturnsCorrectValue() //  Перевіряє правильність отримання значення з матриці за правильними індексами.
        {
            var matrix = new Matrix(2, 2);
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;

            Assert.AreEqual(1, matrix[0, 0]);
            Assert.AreEqual(2, matrix[0, 1]);
            Assert.AreEqual(3, matrix[1, 0]);
            Assert.AreEqual(4, matrix[1, 1]);
        }

        [TestMethod]
        public void Indexer_GetValue_InvalidRowIndex_ThrowsException() // Перевіряє, чи виникне очікуваний виняток, і чи його повідомлення дорівнює "Невірні індекси матриці." при спробі звернутися до елемента за індексом рядка, який виходить за межі матриці
        {
            var matrix = new Matrix(2, 2);

            var ex = Assert.ThrowsException<IndexOutOfRangeException>(() => {
                var value = matrix[2, 0];
            });

            Assert.AreEqual("Невірні індекси матриці.", ex.Message);
        }

        [TestMethod]
        public void Indexer_GetValue_InvalidColumnIndex_ThrowsException() // Перевіряє, чи виникне очікуваний виняток з правильним повідомленням при спробі звернутися до елемента за індексом стовпця, який виходить за межі матриці, 
        {
            var matrix = new Matrix(2, 2);

            var ex = Assert.ThrowsException<IndexOutOfRangeException>(() => {
                var value = matrix[0, 2];
            });

            Assert.AreEqual("Невірні індекси матриці.", ex.Message);
        }

        [TestMethod]
        public void FindMax_ReturnsCorrectMaxValue() // Перевіряє, чи правильно знаходиться максимальний елемент у матриці.
        {
            var matrix = new Matrix(2, 2);
            matrix[0, 0] = 1;
            matrix[0, 1] = 3;
            matrix[1, 0] = -5;
            matrix[1, 1] = 2;

            var max = matrix.FindMax();

            Assert.AreEqual(3, max);
        }

        [TestMethod]
        public void FindMin_ReturnsCorrectMinValue() // Перевіряє, чи правильно знаходиться мінімальниий елемент у матриці.
        {
            var matrix = new Matrix(2, 2);
            matrix[0, 0] = 1;
            matrix[0, 1] = 3;
            matrix[1, 0] = -5;
            matrix[1, 1] = 2;

            var min = matrix.FindMin();

            Assert.AreEqual(-5, min);
        }

        [TestMethod]
        public void Indexer_SetValue_ValidIndices_SetsCorrectValue() // Перевіряє правильність встановлення значення в матрицю за правильними індексами.
        {
            var matrix = new Matrix(2, 2);

            matrix[0, 0] = 10;

            Assert.AreEqual(10, matrix[0, 0]);
        }

        [TestMethod]
        public void Indexer_SetValue_InvalidIndices_ThrowsException() // Перевіряє спробу встановити значення за індексами, які виходять за межі матриці
        {
            var matrix = new Matrix(2, 2);

            var ex = Assert.ThrowsException<IndexOutOfRangeException>(() => {
                matrix[2, 0] = 10;
            });

            Assert.AreEqual("Невірні індекси матриці.", ex.Message);
        }
    }
}
