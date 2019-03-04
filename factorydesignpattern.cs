using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface Shape
    {
        void Draw();
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Circle Drawing");
        }
    }

    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Square Drawing");
        }
    }

    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Drawing");
        }
    }

    public enum ShapeType { CIRCLE, SQUARE, RECTANGLE }

    public interface Factory
    {
         Shape Create(ShapeType shapeType);
    }
    public class ConcreteFactory : Factory
    {
        public Shape Create(ShapeType shapeType)
        {
            Shape shape = null;
            switch (shapeType)
            {
                case ShapeType.CIRCLE:
                    shape = new Circle();
                    break;
                case ShapeType.SQUARE:
                    shape = new Square();
                    break;
                case ShapeType.RECTANGLE:
                    shape = new Rectangle();
                    break;
            }
            return shape;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Factory Create");
            Factory factory = new ConcreteFactory();
            List<Shape> shapes = new List<Shape>();

            shapes.Add(factory.Create(ShapeType.CIRCLE));
            shapes.Add(factory.Create(ShapeType.SQUARE));
            shapes.Add(factory.Create(ShapeType.RECTANGLE));

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadKey();
        }
    }
}
