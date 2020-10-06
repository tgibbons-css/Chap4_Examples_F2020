using System;
using System.Collections.Generic;
using System.Text;

namespace Chap4_Examples_F2020
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleInterfaceImplementation : ISimpleInterface
    {

        public void ThisMethodRequiresImplementation()
        {
            Console.WriteLine("Doing something");

        }

        public string ThisStringPropertyNeedsImplementingToo
        {
            get;
            set;
        }

        public int ThisIntegerPropertyOnlyNeedsAGetter
        {
            get
            {
                return this.encapsulatedInteger;
            }
            set
            {
                this.encapsulatedInteger = value;
            }
        }

        //event EventHandler<EventArgs> InterfacesCanContainEventsToo = delegate { };
        public event EventHandler<EventArgs> InterfacesCanContainEventsToo = delegate { };

        private int encapsulatedInteger;
    }

}
