using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate void MulticastDelegate(int a, int b);
    public delegate void SayHiDelegates(string name);
    //public delegate int AddDelegates1(int a, int b, int c);    //can be commented out as we are using generic delegates( Func, Action, Predicate)
    //public delegate void AddDelegates2(int a, int b, int c);   //can be commented out as we are using generic delegates
    //public delegate bool PrintDelegates3(string s);
     class ReviseTestDelegate
    {
        public void AddNums(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void MultiplyNums(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        //public static void SayHi(string name)   //can be commented out as it is not being used because of the anonymous method
        //{
        //    Console.WriteLine("Hello " + name);
        //}

        //public static int AddingNums1(int a,int b,int c)   //can be commented out as it is being not being used because of lambda expression
        //{
        //    return a + b + c;

        //}
        //public static void AddingNums2(int a,int b, int c)
        //{
        //    Console.WriteLine(a+b+c);
        //}
        //public static bool PrintingAns(string s)
        //{
        //    if (s.Length > 5)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        static void Main()
            {
                ReviseTestDelegate test = new ReviseTestDelegate();
                test.AddNums(10, 20);
                MulticastDelegate ad = new DelegatesProject.MulticastDelegate(test.AddNums);     //Multicast Delegate
                ad += test.MultiplyNums;
                ad.Invoke(10, 20);

                SayHiDelegates sd = delegate (string name)     //Anonymous Method
                {
                    Console.WriteLine("Hello " + name);
                };
               sd.Invoke("Sameer Singh");


            SayHiDelegates sd1 = (name) =>                    //Lambda Expression
            {
                Console.WriteLine("Hi " + name);
            };
            sd1.Invoke("Sameer Singh");


            Func<int, int, int, int> addDelegates1 = (a, b, c) =>
            {
                return a + b + c;
            };
                
            Console.WriteLine(addDelegates1.Invoke(10, 20, 30));

            Action<int, int, int> addDelegates2 = (a, b, c) =>
            {
                Console.WriteLine(a + b + c);
            };

            addDelegates2.Invoke(10, 20, 30);

            Predicate<string> printDelegates3 =(s)=>
            {
                if (s.Length > 5)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(printDelegates3.Invoke("Sameer Singh"));

                


            } 

        
    }
}
