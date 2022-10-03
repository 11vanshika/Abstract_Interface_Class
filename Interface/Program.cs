using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
         interface ITestInterface1
        {
            void Add(int x, int y);
        }
        interface ITestInterface2
        {
            void Sub(int x, int y);
        }
        class ImplementationClass : ITestInterface2
        {
            public void Add(int x,int y ) {
                Console.WriteLine(x + y);
            }
            public void Sub(int x, int y) {
                Console.WriteLine(x - y);
            }
        }
        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            obj.Add(1,2);
            obj.Sub(2,1);
        }
    }
}
