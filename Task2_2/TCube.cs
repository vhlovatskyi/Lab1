using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class TCube : TSquare
    {
        // Конструктор без параметрів
        public TCube() : base()
        {
        }

        // Конструктор з параметрами
        public TCube(double sideLength) : base(sideLength)
        {
        }

        // Конструктор копіювання
        public TCube(TCube otherCube) : base(otherCube.SideLength)
        {
        }

        // Метод для визначення об'єму куба
        public double GetVolume()
        {
            return SideLength * SideLength * SideLength;
        }

        // Перевантаження методу ToString для куба
        public override string ToString()
        {
            return $"Куб зі стороною {SideLength}, площа: {GetArea()}, периметр: {GetPerimeter()}, об'єм: {GetVolume()}";
        }
    }
}
