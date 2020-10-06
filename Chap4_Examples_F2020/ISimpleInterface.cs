using System;
using System.Collections.Generic;
using System.Text;

namespace Chap4_Examples_F2020
{
    public interface ISimpleInterface
    {
        void ThisMethodRequiresImplementation();

        string ThisStringPropertyNeedsImplementingToo
        {
            get;
            set;
        }

        int ThisIntegerPropertyOnlyNeedsAGetter
        {
            get;
        }

        //public event EventHandler<EventArgs> InterfacesCanContainEventsToo;
        event EventHandler<EventArgs> InterfacesCanContainEventsToo;
    }

}
