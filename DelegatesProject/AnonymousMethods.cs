using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate string SayHiDelegate(string name);
    internal class AnonymousMethods
    {
        public static string SayHi(string name)
        {
            return "Hi " + name;
        }
        static void Main()
        {
            SayHiDelegate sayHiDelegate = new SayHiDelegate(AnonymousMethods.SayHi);    //M1: Normal way of calling the method using delegate
           //SayHiDelegate sayHiDelegate1 = SayHi;                                      //M2 : Another way of calling the method using delegate
            Console.WriteLine(sayHiDelegate.Invoke("Sameer"));


            //Anonymous Method: Anonymous method is a method without a name. It is defined using the delegate keyword and without a name and return type.
            SayHiDelegate sd = delegate (string name)    //If we use this method , then we dont need to define the method SayHi and it can be commented out or removed
            {
                return "Hello " + name;
            };
            Console.WriteLine(sd("Sameer Singh"));



            //Console.WriteLine(AnonymousMethods.SayHi("Sameer"));                   //Type 1 of calling the method using normal method

        }
    }
}
