using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate string GreetingsDelegate(string name);
    internal class LambdaExpressions
    {
       //public static string Greetings(string name)
       // {
       //     return "Hello " + name;
       // }
        static void Main()
        {
            //GreetingsDelegate gd = new GreetingsDelegate(Greetings);     //Normal way of calling the method using delegate
            //Console.WriteLine(gd.Invoke("Sameer"));


            //GreetingsDelegate gd = delegate (string name)               //Anonymous Method
            //{
            //    return "Hello " + name;
            //};
            //Console.WriteLine(gd.Invoke("Sameer Singh"));               

            //Lambda Expression: Lambda expression is a short hand syntax for defining anonymous methods. It is defined using the lambda operator =>.
            GreetingsDelegate gd = (name) =>                            //Lambda Expression
            {
                return "Hello " + name;
            };
            Console.WriteLine(gd.Invoke("Sameer"));

        }
    }
}
