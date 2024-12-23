using System;
using test; // Замените на правильное имя пространства имен, если оно отличается

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var _calcArea = new CalcArea();

            // Вызов метода для расчёта площади треугольника
            Console.WriteLine(_calcArea.CalculateTriangleArea(3, 5, 4));

            // Вызов метода для расчёта площади круга
            Console.WriteLine(_calcArea.CalculateCircleArea(4));

        }
    }
}