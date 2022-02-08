using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle oneCircle = new Circle();
            oneCircle.Show();
            oneCircle.Set(1, 1, 100);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey(true);
        }
    }

    class Circle
    {
        public int x = 0;
        public int y = 0;
        public int radius = 3;

        public static readonly string name = "Шар";
        public double Area => GeometryHelper.CircleArea(radius);
        public double Perimeter => GeometryHelper.CirclePerimeter(radius);
        public double Volume => GeometryHelper.CircleVolume(radius);
        public void Set(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public void Set(int radius)
        {
            this.radius = radius;
        }

        public void Show()
        {
            Console.WriteLine("Площадь окружности с центром в точке ({0},{1}) радиусом {2} будет: {3}", x, y, radius, Area);
            Console.WriteLine("Длина окружности с центром в точке ({0},{1}) радиусом {2} будет: {3}", x, y, radius, Perimeter);
            Console.WriteLine("Объём шара с центром в точке ({0},{1}) радиусом {2} будет: {3}", x, y, radius, Volume);
        }
    }

    public static class GeometryHelper
    {
        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CirclePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }

        internal static double CircleVolume(int radius)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }
    }
}