using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    internal class Program
    { 
        abstract class Abparent
        {
            public void Add(int x , int y)
            {
                Console.WriteLine(x + y);
            }
            public void Sub(int x , int y)
            {
                Console.WriteLine(x - y);
            }
            public abstract void Mul(int x, int y);
            public abstract void Divide(int x, int y);
        }
        class Abchild : Abparent
        {
            public override void Mul(int x, int y)
            {
                Console .WriteLine(x * y);
            }
            public override void Divide(int x, int y)
            {
                Console.WriteLine(x / y);
            }
        }
        static void Main(string[] args)
        {
            //Create object from child class
            Abchild childClassObj = new Abchild();
            Abparent parentClassObj = childClassObj;

            parentClassObj.Add(23, 34);
            parentClassObj.Sub(45 ,32);
            childClassObj.Mul(25, 6);
            childClassObj.Divide(25, 5);
        }
    }
}
