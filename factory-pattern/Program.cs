using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory_pattern
{
    public interface Shape
    {
        void Draw();
    }
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle draw.");
        }
    }
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Circle draw.");
        }
    }
    public class ShapeFactory 
    {
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null) 
                return null;
            if (shapeType.Equals("circle", StringComparison.OrdinalIgnoreCase))
                return new Circle();
            if (shapeType.Equals("rectangle", StringComparison.OrdinalIgnoreCase))
                return new Rectangle();
            return null;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Shape shape1 = shapeFactory.GetShape("circle");
            shape1.Draw();
            Shape shape2 = shapeFactory.GetShape("rectangle");
            shape2.Draw();
        }
    }
}
