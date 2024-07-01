using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    //public delegate double Delegate1(int a, float b, double c);
    //public delegate void Delegate2(int a, float b, double c);
    //public delegate bool Delegate3(string s);
    internal class GenericDelegates
    {
        //public static double AddNums1(int a, float b, double c)
        //{
        //    return a + b + c;
        //}
        //public static void AddNums2(int a, float b, double c)
        //{
        //    Console.WriteLine(a+b+c);
        //}
        //public static bool CheckLength(string s)
        //{
        //    if (s.Length > 5)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        static void Main()
        {
            Func<int, float, double, double> d1 = (a, b, c) => 
            {
                return a + b + c;
            };
            Console.WriteLine(d1.Invoke(4, 5, 6.78));
            Action<int, float, double> d2 = (a,b,c)=>
            {
                Console.WriteLine(a + b + c);
            }
            ;
            d2.Invoke(6, 8, 8.88);
            Predicate<string> d3 = (s)=>
            {
                if (s.Length > 5)
                {
                    return true;
                }
                return false;
            }
            ;
            Console.WriteLine(d3.Invoke("abcdef")); 
        }
    }
}
