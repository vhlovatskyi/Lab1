using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    public class Matrix
    {
        private int[,] _matrix; // Внутрішній двовимірний масив для зберігання елементів матриці
        private int _rows;      // Кількість рядків
        private int _cols;      // Кількість стовпців

        // Конструктор
        public Matrix(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
            _matrix = new int[rows, cols];
        }

        // Індексатор для доступу до елементів матриці
        public int this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < _rows && col >= 0 && col < _cols)
                {
                    return _matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Невірні індекси матриці.");
                }
            }
            set
            {
                if (row >= 0 && row < _rows && col >= 0 && col < _cols)
                {
                    _matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Невірні індекси матриці.");
                }
            }
        }

        // Метод для заповнення матриці з клавіатури
        public void InputMatrix()
        {
            Console.WriteLine("Введіть елементи матриці:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write($"Елемент [{i},{j}]: ");
                    _matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Метод для виведення матриці на консоль
        public void PrintMatrix()
        {
            Console.WriteLine("Матриця:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write(_matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Метод для знаходження максимального елемента матриці
        public int FindMax()
        {
            int max = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_matrix[i, j] > max)
                    {
                        max = _matrix[i, j];
                    }
                }
            }
            return max;
        }

        // Метод для знаходження мінімального елемента матриці
        public int FindMin()
        {
            int min = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_matrix[i, j] < min)
                    {
                        min = _matrix[i, j];
                    }
                }
            }
            return min;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Створення об'єкта матриці
            Console.Write("Введіть кількість рядків: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців: ");
            int cols = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(rows, cols);

            // Введення елементів матриці
            matrix.InputMatrix();

            // Виведення матриці
            matrix.PrintMatrix();

            // Знаходження максимального та мінімального елемента
            int max = matrix.FindMax();
            int min = matrix.FindMin();

            Console.WriteLine($"Максимальний елемент: {max}");
            Console.WriteLine($"Мінімальний елемент: {min}");
        }
    }
}
