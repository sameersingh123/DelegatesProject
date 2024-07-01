using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate void RectDelegate(int a, int b);
    internal class Rectangle
    {
        public void GetArea(int a, int b)
        {
            Console.WriteLine("Area of Rectangle is : " + (a * b));
        }
        public void GetPerimeter(int a,int b)
        {
            Console.WriteLine("Perimeter of Rectangle is: "+ 2*(a+b));
        }
        static void Main()
        {
            Rectangle rect=new Rectangle();
            RectDelegate rd = new RectDelegate(rect.GetArea);
            rd=rd+rect.GetPerimeter;
            rd(10, 20);

        }
    }
}
