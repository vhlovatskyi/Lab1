using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Оберіть дію:");
            Console.WriteLine("1. Ввести квадрат");
            Console.WriteLine("2. Ввести куб");
            Console.WriteLine("3. Порівняти два квадрати");
            Console.WriteLine("4. Додати два квадрати");
            Console.WriteLine("5. Відняти два квадрати");
            Console.WriteLine("6. Помножити квадрат на число");
            //Console.WriteLine("0. Вийти");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TSquare square = new TSquare();
                    square.Input();
                    square.Output();
                    break;

                case 2:
                    TCube cube = new TCube();
                    cube.Input();
                    cube.Output();
                    break;

                case 3:
                    Console.WriteLine("Порівняння двох квадратів:");
                    TSquare square1 = new TSquare();
                    square1.Input();
                    TSquare square2 = new TSquare();
                    square2.Input();
                    if (square1.Equals(square2))
                    {
                        Console.WriteLine("Квадрати рівні.");
                    }
                    else
                    {
                        Console.WriteLine("Квадрати не рівні.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Додавання двох квадратів:");
                    TSquare sq1 = new TSquare();
                    sq1.Input();
                    TSquare sq2 = new TSquare();
                    sq2.Input();
                    TSquare resultAdd = sq1 + sq2;
                    Console.WriteLine("Результат додавання: " + resultAdd.ToString());
                    break;

                case 5:
                    Console.WriteLine("Віднімання двох квадратів:");
                    TSquare subSq1 = new TSquare();
                    subSq1.Input();
                    TSquare subSq2 = new TSquare();
                    subSq2.Input();
                    TSquare resultSub = subSq1 - subSq2;
                    Console.WriteLine("Результат віднімання: " + resultSub.ToString());
                    break;

                case 6:
                    Console.WriteLine("Множення квадрата на число:");
                    TSquare multSq = new TSquare();
                    multSq.Input();
                    Console.WriteLine("Введіть число для множення:");
                    double factor = Convert.ToDouble(Console.ReadLine());
                    TSquare resultMult = multSq * factor;
                    Console.WriteLine("Результат множення: " + resultMult.ToString());
                    break;

                default:
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                    break;
            }
        }
    }
}
