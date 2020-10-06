using System;

namespace Chap4_Examples_F2020
{
    class Program
    {
        /// <summary>
        /// This is example code from Chapter 4
        /// </summary>
        static void Main(string[] args)
        {
            // ======  Sample WITHOUT an interface ======
            SimpleInterfaceImplementation s = new SimpleInterfaceImplementation();

            s.ThisMethodRequiresImplementation();
            s.ThisIntegerPropertyOnlyNeedsAGetter = 7;
            s.ThisStringPropertyNeedsImplementingToo = "Hello";

            // ======  Sample WITH an interface ======
            ISimpleInterface i = new SimpleInterfaceImplementation();
            i.ThisMethodRequiresImplementation();
            //i.ThisIntegerPropertyOnlyNeedsAGetter = 7;
            i.ThisStringPropertyNeedsImplementingToo = "Hello";

            // ======  Sample with books and IBillableItem ======
            // This shows how you can pass an object to a method with an interface parameter
            Book b = new Book("Good night moon", "Margaret Wise Brown", 4.3M);
            PrintBill(b);

        }

        /// <summary>
        /// Method to print out any Billable Item
        /// </summary>
        /// <param name="item"></param>
        static void PrintBill(IBillableItem item)
        {
            Console.WriteLine("Items purchased:");
            Console.WriteLine(item.PrintDescription());
        }
    }
}

