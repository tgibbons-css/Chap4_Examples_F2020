using System;
using System.Collections.Generic;
using System.Text;

namespace Chap4_Examples_F2020
{
    public interface IBillableItem
    {
        string PrintDescription();              // print the item's description in one line
        decimal GetCost();                      // returns the cost of the item
        decimal ShippingWt                      // stores the shiping weight for this item in oz
        {
            get;
            set;
        }

    }
}
