/*
C# - Collections
Collection classes are specialized classes for data storage and retrieval. These classes provide support for stacks, 
queues, lists, and hash tables. Most collection classes implement the same interfaces.

Collection classes serve various purposes, such as allocating memory dynamically to elements and accessing a list of items on the basis of an index etc. 
These classes create collections of objects of the Object class, which is the base class for all data types in C#.
*/

/*
Arraylist
It represents an ordered collection of an object that can be indexed individually. It is basically an alternative to an array. However, unlike array you can add and remove items from a list at a specified position using an index and the array resizes itself automatically.
 It also allows dynamic memory allocation, adding, searching and sorting items in the list.
 https://www.tutorialspoint.com/csharp/csharp_arraylist.htm
*/

using System;
using System.Collections;

namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

// Adding some numbers:
// Capacity: 8
// Count: 7
// Content: 45 78 33 56 12 23 9
// Content: 9 12 23 33 45 56 78  

/*
HashTable Class

The Hashtable class represents a collection of key-and-value pairs that are organized based on the hash code of the key. 
It uses the key to access the elements in the collection.

A hash table is used when you need to access elements by using key, and you can identify a useful key value.
 Each item in the hash table has a key/value pair. The key is used to access the items in the collection.
*/

using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }

//  001: Zara Ali
// 002: Abida Rehman
// 003: Joe Holzner
// 004: Mausam Benazir Nur
// 005: M.Amlan
// 006: M.Arif
// 007: Ritesh Saikia
// 008: Nuha Ali 

/*
SortedList Class

The SortedList class represents a collection of key-and-value pairs that are sorted by the keys and are accessible by key and by index.
A sorted list is a combination of an array and a hash table. It contains a list of items that can be accessed using a key or an index. 
If you access items using an index, it is an ArrayList, and if you access items using a key, 
it is a Hashtable. The collection of items is always sorted by the key value.
*/

using System;
using System.Collections;

namespace CollectionsApplication
    {
        class Program
        {
            static void Main(string[] args)
            {
                SortedList sl = new SortedList();

                sl.Add("001", "Zara Ali");
                sl.Add("002", "Abida Rehman");
                sl.Add("003", "Joe Holzner");
                sl.Add("004", "Mausam Benazir Nur");
                sl.Add("005", "M. Amlan");
                sl.Add("006", "M. Arif");
                sl.Add("007", "Ritesh Saikia");

                if (sl.ContainsValue("Nuha Ali"))
                {
                    Console.WriteLine("This student name is already in the list");
                }
                else
                {
                    sl.Add("008", "Nuha Ali");
                }

                // get a collection of the keys. 
                ICollection key = sl.Keys;

                foreach (string k in key)
                {
                    Console.WriteLine(k + ": " + sl[k]);
                }
            }
        }
    }
    // 001: Zara Ali
    // 002: Abida Rehman
    // 003: Joe Holzner
    // 004: Mausam Banazir Nur
    // 005: M.Amlan 
    // 006: M.Arif
    // 007: Ritesh Saikia
    // 008: Nuha Ali

    /*
    StackClass

    It represents a last-in, first out collection of object. It is used when you need a last-in, first-out access of items. 
    When you add an item in the list, 
    it is called pushing the item and when you remove it, it is called popping the item.
    https://www.tutorialspoint.com/csharp/csharp_stack.htm
    */

    Live Demo
using System;
using System.Collections;

namespace CollectionsApplication
    {
        class Program
        {
            static void Main(string[] args)
            {
                Stack st = new Stack();

                st.Push('A');
                st.Push('M');
                st.Push('G');
                st.Push('W');

                Console.WriteLine("Current stack: ");
                foreach (char c in st)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();

                st.Push('V');
                st.Push('H');
                Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
                Console.WriteLine("Current stack: ");

                foreach (char c in st)
                {
                    Console.Write(c + " ");
                }

                Console.WriteLine();

                Console.WriteLine("Removing values ");
                st.Pop();
                st.Pop();
                st.Pop();

                Console.WriteLine("Current stack: ");
                foreach (char c in st)
                {
                    Console.Write(c + " ");
                }
            }
        }
    }

// Current stack: 
// W G M A
// The next poppable value in stack: H
// Current stack: 
// H V W G M A
// Removing values
// Current stack: 
// G M A

/*
Queue Class

It represents a first-in, first out collection of object. It is used when you need a first-in, first-out access of items. 
When you add an item in the list, it is called enqueue, and when you remove an item, it is called deque.
https://www.tutorialspoint.com/csharp/csharp_queue.htm
*/

using System;
using System.Collections;

namespace CollectionsApplication
    {
        class Program
        {
            static void Main(string[] args)
            {
                Queue q = new Queue();

                q.Enqueue('A');
                q.Enqueue('M');
                q.Enqueue('G');
                q.Enqueue('W');

                Console.WriteLine("Current queue: ");
                foreach (char c in q) Console.Write(c + " ");

                Console.WriteLine();
                q.Enqueue('V');
                q.Enqueue('H');
                Console.WriteLine("Current queue: ");
                foreach (char c in q) Console.Write(c + " ");

                Console.WriteLine();
                Console.WriteLine("Removing some values ");
                char ch = (char)q.Dequeue();
                Console.WriteLine("The removed value: {0}", ch);
                ch = (char)q.Dequeue();
                Console.WriteLine("The removed value: {0}", ch);

                Console.ReadKey();
            }
        }
    }

// Current queue: 
// A M G W
// Current queue: 
// A M G W V H
// Removing values
// The removed value: A
// The removed value: M


/*
BitArray Class

The BitArray class manages a compact array of bit values, which are represented as Booleans, 
where true indicates that the bit is on (1) and false indicates the bit is off (0).

It is used when you need to store the bits but do not know the number of bits in advance. 
You can access items from the BitArray collection by using an integer index, which starts from zero.
https://www.tutorialspoint.com/csharp/csharp_bitarray.htm

*/

using System;
using System.Collections;

namespace CollectionsApplication
    {
        class Program
        {
            static void Main(string[] args)
            {
                //creating two  bit arrays of size 8
                BitArray ba1 = new BitArray(8);
                BitArray ba2 = new BitArray(8);

                byte[] a = { 60 };
                byte[] b = { 13 };

                //storing the values 60, and 13 into the bit arrays
                ba1 = new BitArray(a);
                ba2 = new BitArray(b);

                //content of ba1
                Console.WriteLine("Bit array ba1: 60");

                for (int i = 0; i < ba1.Count; i++)
                {
                    Console.Write("{0, -6} ", ba1[i]);
                }
                Console.WriteLine();

                //content of ba2
                Console.WriteLine("Bit array ba2: 13");

                for (int i = 0; i < ba2.Count; i++)
                {
                    Console.Write("{0, -6} ", ba2[i]);
                }
                Console.WriteLine();
                BitArray ba3 = new BitArray(8);
                ba3 = ba1.And(ba2);

                //content of ba3
                Console.WriteLine("Bit array ba3 after AND operation: 12");

                for (int i = 0; i < ba3.Count; i++)
                {
                    Console.Write("{0, -6} ", ba3[i]);
                }
                Console.WriteLine();
                ba3 = ba1.Or(ba2);

                //content of ba3
                Console.WriteLine("Bit array ba3 after OR operation: 61");

                for (int i = 0; i < ba3.Count; i++)
                {
                    Console.Write("{0, -6} ", ba3[i]);
                }
                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }

// Bit array ba1: 60 
// False False True True True True False False
// Bit array ba2: 13
// True False True True False False False False
// Bit array ba3 after AND operation: 12
// False False True True False False False False
// Bit array ba3 after OR operation: 61
// True False True True False False False False 

