/*
A default constructor does not have any parameter but if you need, a constructor can have parameters.
 Such constructors are called parameterized constructors.

A destructor is a special member function of a class that is executed
 whenever an object of its class goes out of scope. A destructor has exactly 
 the same name as that of the class with a prefixed tilde (~) and it can neither return
 a value nor can it take any parameters.

Destructor can be very useful for releasing memory resources before exiting the program.
 Destructors cannot be inherited or overloaded.

*/
using System;

namespace LineApplication
{

    class Line
    {
        private double length;   // Length of a line

        public Line()
        {
            Console.WriteLine("Object is being created");
        }


        ~Line()
        {   //destructor
            Console.WriteLine("Object is being deleted");
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadKey();
        }
    }
}