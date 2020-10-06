using System;

namespace Chap4_Examples_F2020
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterfaceImplementation s = new SimpleInterfaceImplementation();

            s.ThisMethodRequiresImplementation();
            s.ThisIntegerPropertyOnlyNeedsAGetter = 7;
            s.ThisStringPropertyNeedsImplementingToo = "Hello";

            ISimpleInterface i = new SimpleInterfaceImplementation();
            i.ThisMethodRequiresImplementation();
            //i.ThisIntegerPropertyOnlyNeedsAGetter = 7;
            i.ThisStringPropertyNeedsImplementingToo = "Hello";

            Book b = new Book("Good night moon", "Margaret Wise Brown", 4.3M);
            PrintBill(b);

        }

        static void PrintBill(IBillableItem item)
        {
            Console.WriteLine("Items purchased:");
            Console.WriteLine(item.PrintDescription());
        }
    }
}
}
