using System;
using System.Collections.Generic;

namespace Example11
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());

            // invoked on each of the derived classes, not the base class.
            foreach (var s in shapes)
            {
                Console.WriteLine($"---Invoke draw method of {s.GetType()}");
                s.Draw();
                Console.WriteLine();
            }

            Console.WriteLine("---Going to drawing a triangle...");

            var triangle = new Triangle();
            Console.WriteLine($"---Invoke draw method of {triangle.GetType()}");
            triangle.Draw();
        
            Console.WriteLine("---Going to drawing a triangle as shape...");
            var shape = triangle as Shape;
            Console.WriteLine($"---Invoke draw method of {shape.GetType()}");
            shape.Draw();
        }
    }

    public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
    
        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }

    class Triangle : Shape
    {
        public new void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
}
