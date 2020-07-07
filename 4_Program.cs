/*
Classes and Structures have the following basic differences −

classes are reference types and structs are value types
structures do not support inheritance
structures cannot have default constructor

*/

using System;

namespace LibraryApplication
{
    struct Book
    {
        public int book_id;
        public string title;
    }

    enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
    class TestStructure
    {
        static void main(String[] args){
            Book book1;
            book1.book_id=1;
            book1.title="Title 1";

            // Enum
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

        }
    }
}