using Delegates.GenericsExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.Generics
{
    internal class IndexGenericsExample
    {
        public IndexGenericsExample()
        {
            IndexGenericsExampleMethod();
        }

        private void IndexGenericsExampleMethod()
        {
            GenericsExampleOne genericsExampleOne = new GenericsExampleOne();
            //Console.WriteLine("Hello from Gernerics class!");
        }
    }
}

/*
 What are Generics?
Generics are a way to make your code more flexible and reusable by allowing it to work with any data type. 

Think of generics as tenplates that you can fill in with diferent types, when you use them. 

Why yould you use Generics?

Flexibility. You can write one method, class or interface and use it with different data types without writting multiple versions. 
1. Type Safety (catch erros during comppile time)
2. Performance, Generics avoid the need fr boxing and unboxing when working with value types, which can improve performance. 

 */
