/*
Multiple Inheritance in C#
C# does not support multiple inheritance. 
However, you can use interfaces to implement multiple inheritance.
*/

using System;

namespace InheritanceApplication
{

    // Base class PaintCost
    public interface PaintCost
    {
        int getCost(int area);
    }
    
    class Shape
    {

        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Derived class
    class Rectangle : Shape, PaintCost
    {

        public int getArea()
        {
            return (width * height);
        }

        public int getCost(int area)
        {
            return area * 70;
        }
    }

    class RectangleTester
    {

        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));
            Console.ReadKey();
        }
    }
}