using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.DelegatesExample
{
    internal class IndexDelegateExample
    {
        public IndexDelegateExample()
        {
            IndexDelegateExampleMethod();
        }

        public void IndexDelegateExampleMethod()
        {
            //DelegateExampleOne delegateExample = new DelegateExampleOne();
            DelegateExampleTwo delegateExampleTwo = new DelegateExampleTwo();
        }
    }
}

/*
 Why do we use Delegates?
Delegates provide a way to pass methods as parameters, enabling flexible and extensible code designs. 

When do we use Delegates?
Use delegates when you need a way to encapsulate a method an pass it as an arguement.

Where do we use Delegates?
Delegates are used in callback mechanisms, event handling, and designing flexible APIs
 */
