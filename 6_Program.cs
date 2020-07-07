/*
Static Members of a C# Class
We can define class members as static using the static keyword. When we declare a member of a class as static, 
it means no matter how many objects of the class are created, there is only one copy of the static member.

The keyword static implies that only one instance of the member exists for a class. Static variables are used for
 defining constants because their values can be retrieved by invoking the class without creating an instance of it. 
 Static variables can be
 initialized outside the member function or class definition. You can also initialize static variables inside the class definition.

 You can also declare a member function as static. Such functions can access only static variables. 
 The static functions exist even before the object is created. The following example demonstrates the use of static functions −


*/

using System;

namespace StaticVarApplication
{

    class StaticVar
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public static int getNum()
        {
            return num;
        }
    }

    class StaticTester
    {

        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("Variable num: {0}", StaticVar.getNum());
            Console.ReadKey();
        }
    }
}