using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class TSquare
    {
        // Поле для зберігання довжини сторони квадрата
        public double SideLength { get; set; }

        // Конструктор без параметрів
        public TSquare()
        {
            SideLength = 1.0;
        }

        // Конструктор з параметрами
        public TSquare(double sideLength)
        {
            SideLength = sideLength;
        }

        // Конструктор копіювання
        public TSquare(TSquare otherSquare)
        {
            SideLength = otherSquare.SideLength;
        }

        // Визначення площі
        public double GetArea()
        {
            return SideLength * SideLength;
        }

        // Визначення периметру
        public double GetPerimeter()
        {
            return 4 * SideLength;
        }

        // Перевантаження методу ToString
        public override string ToString()
        {
            return $"Квадрат зі стороною {SideLength}, площа: {GetArea()}, периметр: {GetPerimeter()}";
        }

        // Перевантаження оператора +
        public static TSquare operator +(TSquare a, TSquare b)
        {
            return new TSquare(a.SideLength + b.SideLength);
        }

        // Перевантаження оператора -
        public static TSquare operator -(TSquare a, TSquare b)
        {
            return new TSquare(Math.Max(a.SideLength - b.SideLength, 0));
        }

        // Перевантаження оператора *
        public static TSquare operator *(TSquare a, double factor)
        {
            return new TSquare(a.SideLength * factor);
        }

        // Метод для порівняння з іншим квадратом
        public bool Equals(TSquare otherSquare)
        {
            return this.SideLength == otherSquare.SideLength;
        }

        // Метод введення даних з консолі
        public void Input()
        {
            Console.WriteLine("Введіть довжину сторони квадрата:");
            SideLength = Convert.ToDouble(Console.ReadLine());
        }

        // Метод виведення даних на консоль
        public void Output()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
