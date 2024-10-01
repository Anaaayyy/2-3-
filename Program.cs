using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_
{
    using System;

    // Абстрактный класс Г.ф.
    abstract class Shape
    {
        // Абстрактный метод для вычисления площади
        public abstract double GetArea();

        // Метод для вывода площади фигуры
        public void PrintArea()
        {
            Console.WriteLine($"Площадь фигуры: {GetArea()}");
        }
    }

    // Класс "Круг", наследник Shape
    class Circle : Shape
    {
        // Публичное поле для радиуса круга
        public double Radius;

        // Конструктор для инициализации радиуса
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Реализация метода для вычисления площади круга
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Класс "Прямоугольник", наследник Shape
    class Rectangle : Shape
    {
        // Публичные поля для ширины и высоты прямоугольника
        public double Width;
        public double Height;

        // Конструктор для инициализации ширины и высоты
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Реализация метода для вычисления площади прямоугольника
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Класс "Треугольник", наследник Shape
    class Triangle : Shape
    {
        // Публичные поля для основания и высоты треугольника
        public double Base;
        public double Height;

        // Конструктор для инициализации основания и высоты
        public Triangle(double triangleBase, double height)
        {
            Base = triangleBase;
            Height = height;
        }

        // Реализация метода для вычисления площади треугольника
        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание объектов различных фигур
            Shape circle = new Circle(15);
            Shape rectangle = new Rectangle(19, 20);
            Shape triangle = new Triangle(12, 3);

            // Вывод площади каждой фигуры
            circle.PrintArea();
            rectangle.PrintArea();
            triangle.PrintArea();

            Console.ReadLine();
        }
    }

}
