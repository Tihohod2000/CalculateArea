namespace test;

public class CalcArea
{
    double _s;
    double _p;


    // Метод для вычисления площади треугольника
    public double CalculateTriangleArea(double a, double b, double c)
    {
        double[] sides = { a, b, c};
        Array.Sort(sides);
        if (sides[0] + sides[1] <= sides[2])
        {
            throw new ArgumentException("Невозможный треугольник");    
        }
        if (Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) == 0)
        {
            Console.WriteLine("Прямоугольный треугольник");    
        }
        else
        {
            Console.WriteLine("Треугольник");
        }

        
        _p = (a + b + c) / 2;
        _s = Math.Sqrt(_p * (_p - a) * (_p - b) * (_p - c));
        return _s;
    }

    //Метод вычисления площади круга
    public double CalculateCircleArea(double r)
    {
        Console.WriteLine("Круг");
        _s = Math.PI * Math.Pow(r, 2);
        return _s;
    }


}