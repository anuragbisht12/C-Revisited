/*
C# - Polymorphism
The word polymorphism means having many forms. 
In object-oriented programming paradigm, polymorphism is often expressed as 'one interface, multiple functions'.

Polymorphism can be static or dynamic. In static polymorphism, the response to a function is 
determined at the compile time. In dynamic polymorphism, it is decided at run-time.

Static Polymorphism
The mechanism of linking a function with an object during compile time is called early binding. It is also called static binding.
C# provides two techniques to implement static polymorphism. They are −

Static
Function overloading : Same name differnt method signature
Operator overloading: Same as above

Dynamic:
Function overriding
virtual

*/

// Function overloading
using System;

namespace PolymorphismApplication
{

    class Printdata
    {


        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }

        static void Main(string[] args)
        {
            Printdata p = new Printdata();

            // Call print to print integer
            p.print(5);

            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello C++");
            Console.ReadKey();
        }
    }
}

/*
Dynamic Polymorphism
C# allows you to create abstract classes that are used to provide partial class implementation of an interface. 
Implementation is completed when a derived class inherits from it. Abstract classes contain abstract methods, 
which are implemented by the derived class. The derived classes have more specialized functionality.

Here are the rules about abstract classes −

You cannot create an instance of an abstract class

You cannot declare an abstract method outside an abstract class

When a class is declared sealed, it cannot be inherited, abstract classes cannot be declared sealed.
*/

using System;

namespace PolymorphismApplication
{

    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }

        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }

    class RectangleTester
    {

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();
        }
    }
}


/*
When you have a function defined in a class that 
you want to be implemented in an inherited class(es), you use virtual functions. 
The virtual functions could be implemented differently in different inherited class and the 
call to these functions will be decided at runtime.

Dynamic polymorphism is implemented by abstract classes and virtual functions.

Virtual functions

*/

using System;

namespace PolymorphismApplication
{

    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }

        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {

        }

        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }

    class Tester
    {

        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }
    }
}


// Operator overloading

using System;

namespace OperatorOvlApplication
{

    class Box
    {
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }

    class Tester
    {

        static void Main(string[] args)
        {
            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            Box Box3 = new Box();   // Declare Box3 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // box 2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            Box3 = Box1 + Box2;

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();
        }
    }
}

