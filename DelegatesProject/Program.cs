using System;
namespace DelegatesProject
{
    //Defining a delegate : Delegate is a type safe function pointer which dosent have a body and it just points(pointer) to the method
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string name);
    class Program
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AddNums(10, 20);                                     //Type 1 of calling the method

            Console.WriteLine(Program.SayHello("Sameer Singh"));  //Type 2 of calling the method




            //Type 3 of calling the method using delegate

            AddDelegate ad=new AddDelegate(p.AddNums);    //AddNums is a non-static method and we cannot directly call it from static method Main, so we need to create an object of Program class and then call the method
            ad(10, 20);
            ad.Invoke(10, 40); //Type 3: Another way to call the delegate

            SayDelegate sa = new SayDelegate(Program.SayHello);   //SayHello is a static method and we can directly call it from static method Main
            Console.WriteLine(sa("Sameer"));




            //p.AddNums(10, 20);
           // Console.WriteLine(Program.SayHello("Sameer"));
        }
    }
}