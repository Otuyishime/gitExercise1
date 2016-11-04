using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello from Main!");
            Console.WriteLine("Another message from Main()");
            Console.WriteLine("Another one!");
            Console.WriteLine("And another one!!!");
            MyClass.hello();

            Console.WriteLine("Another message after hello() execution!");
            Console.WriteLine("WriteLine after cloning!");
        }
    }
}
