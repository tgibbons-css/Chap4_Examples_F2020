using System;
using System.Collections.Generic;
using System.Text;

namespace Chap4_Examples_F2020
{
    public class Book : IBillableItem
    {
        public Book(string newTitle, string newAuthor, decimal newWt)
        {
            Title = newTitle;
            Author = newAuthor;
            Wt = newWt;
        }

        string Title 
        {
            get;
            set;
        }
        string Author
        {
            get;
            set;
        }
        decimal Wt;
        public decimal ShippingWt
        {
            get { return Wt; }
            set { Wt = value; }
        }

        public string PrintDescription()
        {
            return ("This is a book by " + Author);
        }

        public decimal GetCost()
        {
            return 19.99M;
        }
    }
}
