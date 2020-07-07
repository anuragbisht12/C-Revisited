/*
Encapsulation is defined 'as the process of enclosing one or more items within a
 physical or logical package'. Encapsulation, in object oriented programming methodology, 
 prevents access to implementation details.

Abstraction and encapsulation are related features in object oriented programming. 
Abstraction allows making relevant information visible and encapsulation enables a 
programmer to implement the desired level of abstraction.

Encapsulation is implemented by using access specifiers. An access specifier defines 
the scope and visibility of a class member. C# supports the following access specifiers −


Public
Private
Protected  Protected access specifier allows a child class to access the member variables and member functions of its base class
Internal  Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly
Protected internal  The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application.

Access specifiers specify the access rules for the members as well as the class itself. If not mentioned, then the default access specifier for a class type is internal. Default access for the members is private.

Data type specifies the type of variable, and return type specifies the data type of the data the method returns, if any.

To access the class members, you use the dot (.) operator.

The dot operator links the name of an object with the name of a member.


*/


using System;

namespace RectangleApplication
{
    class Rectangle{
        internal double length;
        internal double width;

        double GetArea(){
            return length * width;
        }

        public void Display(){
            Console.WriteLine("Length {0} ",length);
            Console.WriteLine("Width {0} ", width);
            Console.WriteLine("Area {0} ", GetArea());

        }

        public int FindMax(int length, int width){
            if(length>with){
                return length;
            }
            else
            {
                return width;
            }
        }

        public int Factorial(int number){
            if (number == 1){
                return 1;
            }
            else{
                return number*Factorial(number-1);
            }
        }

    }

    class ExecuteRectangle{
        static void main(String[] args){
            int? num2=45;

            Rectangle r= new Rectangle();
            r.length=5;
            r.width=2;
            r.Display();
            int max=r.FindMax(r.length,r.width);
            Console.ReadKey();

            r.Factorial(4);

            // Initialization of array
            int [] marks= new int[5] {1,2,3,4,5};
            for(int i=0;i<5;i++){
                Console.WriteLine("Element {0}: {1}",i,marks[i]);
            }

            foreach(int j in n){

            }


        }

    }
}